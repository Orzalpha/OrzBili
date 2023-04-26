using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;
using OrzBili.Core.Contracts.Services;
using OrzBili.Models;
using OrzBili.Models.BangumiDetailModel;
using OrzBili.Services;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;


namespace OrzBili.ViewModels;


public partial class TestViewModel : ObservableRecipient, INavigationAware
{
    //private readonly IGetpgcService _getpgcService;

    [ObservableProperty]
    public string testContent = "something";

    public MediaPlayerElement TestMediaPlayerElement
    {
        get;
        set;
    } = null!;

    private readonly INavigationService _navigationService;
    private readonly IFileService _fileService;
    private readonly IBiliApiService _biliApiService;
    private readonly IGetStreamService _getStreamService;


    public TestViewModel(
        INavigationService navigationService,
        IFileService fileService,
        IBiliApiService biliApiService,
        IGetStreamService getStreamService)
    {
        _navigationService = navigationService;
        _fileService = fileService;
        _biliApiService = biliApiService;
        _getStreamService = getStreamService;

    }

    public ObservableCollection<gridviewItem> Items = new();


    public void OnNavigatedTo(object parameter)
    {

    }

    public void OnNavigatedFrom()
    {
    }

    
    [RelayCommand]
    public async void Button()
    {
        /*
        var url = new Uri("https://cn-hbwh-fx-01-06.bilivideo.com/upgcxcode/28/43/16224328/16224328_da8x4-1-30077.m4s?e=ig8euxZM2rNcNbdlhoNvNC8BqJIzNbfqXBvEqxTEto8BTrNvN0GvT90W5JZMkX_YN0MvXg8gNEV4NC8xNEV4N03eN0B5tZlqNxTEto8BTrNvNeZVuJ10Kj_g2UB02J0mN0B5tZlqNCNEto8BTrNvNC7MTX502C8f2jmMQJ6mqF2fka1mqx6gqj0eN0B599M=&uipk=5&nbs=1&deadline=1682444750&gen=playurlv2&os=bcache&oi=976231394&trid=000051c12243356d4143b5ed6888f9d7b795p&mid=3493126192761680&platform=pc&upsig=9d6b0414ac0874b800483da5c1a5f40b&uparams=e,uipk,nbs,deadline,gen,os,oi,trid,mid,platform&cdnid=3876&bvc=vod&nettype=0&orderid=0,3&buvid=18C266E4-570B-89EF-8332-B6F2E47FCFF337135infoc&build=0&agrr=1&np=151388311&bw=82583&logo=80000000");
        var source = await _getStreamService.CreateMediaSource(url);    

        TestMediaPlayerElement.SetMediaPlayer(new());
        TestMediaPlayerElement.MediaPlayer.Source = source;
        TestMediaPlayerElement.MediaPlayer.Play();

        TestMediaPlayerElement.MediaPlayer.MediaFailed += (s, e) =>
        {
            var sender = s;

        };
        */
        await Task.CompletedTask;
        return;
    }
}
public class gridviewItem
{
    public string Source { get; set; } = string.Empty;
}