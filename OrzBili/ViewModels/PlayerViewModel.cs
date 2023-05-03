using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Navigation;
using OrzBili.ApiModels.BangumiPlayurlModel;
using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;
using OrzBili.Models;
using OrzBili.Models.BangumiDetailModel;
using Windows.Media.Playback;
using Windows.UI.Core;

namespace OrzBili.ViewModels;

public partial class PlayerViewModel : ObservableRecipient, INavigationAware
{
    [ObservableProperty]
    public string testString = string.Empty;
    [ObservableProperty]
    public bool infobarVisibility = false;
    public ObservableCollection<Episode> EpisodesItems = new();
    public MediaPlayerElement AnimeElement { get; set; } = null!;
    public MediaPlayer AnimePlayer { get; } = new();


    private readonly IBiliApiService _biliApiService;
    private readonly IGetStreamService _getStreamService;

    public PlayerViewModel(IBiliApiService biliApiService, IGetStreamService getStreamService)
    {
        _biliApiService = biliApiService;
        _getStreamService = getStreamService;
    }

    public async void PlayEpisode(Episode episode)
    {
        var para = new ApiParameterModel.BangumiPlayurlPara(episode.aid, episode.bvid, episode.cid, episode.id);
        if (await _biliApiService.GetInfoAsync(Services.BiliApiService.Info.BangumiPlayurl, para) is BangumiPlayurl playurl && playurl.result != null && playurl.result.dash != null)
        {
            var dash = playurl.result.dash;
            var source = await _getStreamService.CreateMediaSource(dash.video![0], dash.audio![0]);
            AnimePlayer.Source = source;
            AnimePlayer.Play();
        }
        else
        {
            //  cannot play
            InfobarVisibility = true;
        }
        return;
    }

    public void OnNavigatedFrom()
    {
        if (AnimePlayer != null)
        {
            AnimePlayer.Dispose();
        }
    }
    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is NavigateParaModel.PlayerpagePara naviPara)
        {
            //TestString += para.season_id.ToString() + ' ' + para.media_id.ToString();
            var detailPara = new ApiParameterModel.BangumiDetailPara(naviPara.season_id, null);
            if (await _biliApiService.GetInfoAsync(Services.BiliApiService.Info.BangumiDetail, detailPara) is BangumiDetail bangumiDetail && bangumiDetail.result != null && bangumiDetail.result.episodes != null)
            {
                foreach (var episode in bangumiDetail.result.episodes)
                {
                    EpisodesItems.Add(episode);
                }
            }

        }
        else
        {
            //  to set visibility
        }
    }

}
