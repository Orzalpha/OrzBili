using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OrzBili.ApiModels.BangumiPlayurlModel;
using OrzBili.Contracts.Services;
using OrzBili.Models;
using Windows.Devices.Radios;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;
using Windows.Web.Http;

namespace OrzBili.Services;


public class GetStreamService : IGetStreamService
{
    private readonly Windows.Web.Http.HttpClient _httpClient = new();
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly System.Net.Http.HttpClient _httpClient2;

    public GetStreamService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = new();
        _httpClient.DefaultRequestHeaders.Referer = new Uri("http://www.bilibili.com/");
        _httpClient.DefaultRequestHeaders.Add("Origin", "http://www.bilibili.com/");
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/112.0");
        _httpClientFactory = httpClientFactory;
        _httpClient2 = _httpClientFactory.CreateClient("StreamClient");
    }

    public async Task<MediaSource> CreateMediaSource(Video video, Audio audio)
    {

        var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/DashMPDTemplate.xml"));
        var mpdBase = await FileIO.ReadTextAsync(file);
        //var mpdBase =  File.ReadAllText("ms-appx:///Assets/DashMPDTemplate.xml");
        var videoStr =
                    $@"<Representation bandwidth=""{video.bandwidth}"" codecs=""{video.codecs}"" height=""{video.height}"" mimeType=""{video.mimeType}"" id=""{video.id}"" width=""{video.width}"">
                               <BaseURL></BaseURL>
                               <SegmentBase indexRange=""{video.SegmentBase!.indexRange}"">
                                   <Initialization range=""{video.SegmentBase.Initialization}"" />
                               </SegmentBase>
                           </Representation>
        ";
        var audioStr =
       $@"<Representation bandwidth=""{audio.bandwidth}"" codecs=""{audio.codecs}"" mimeType=""{audio.mimeType}"" id=""{audio.id}"">
                               <BaseURL></BaseURL>
                               <SegmentBase indexRange=""
            {audio.SegmentBase!.indexRange}"">
                                   <Initialization range=""
            {audio.SegmentBase.Initialization}"" />
                               </SegmentBase>
                           </Representation>
            ";
        videoStr = videoStr.Trim();
        audioStr = audioStr.Trim();
        mpdBase = mpdBase.Replace("{video}", videoStr)
                         .Replace("{audio}", audioStr)
                         .Replace("{bufferTime}", $"PT4S");
        var stream = new MemoryStream(Encoding.UTF8.GetBytes(mpdBase)).AsInputStream();
        var result = await AdaptiveMediaSource.CreateFromStreamAsync(stream, new Uri(video.baseUrl!), "application/dash+xml", _httpClient);
        if (result.Status == AdaptiveMediaSourceCreationStatus.Success)
        {
            result.MediaSource.DownloadRequested += (sender, args) =>
            {
                if (args.ResourceContentType == "audio/mp4")
                {
                    args.Result.ResourceUri = new Uri(audio.baseUrl!);
                }
            };
            return MediaSource.CreateFromAdaptiveMediaSource(result.MediaSource);
        }
        await Task.CompletedTask;
        return null!;
    }
    /*
public async Task<Stream> CreateStream(string path)
{
var stream = await _httpClient2.GetStreamAsync(path);
return stream;
}
*/
}
