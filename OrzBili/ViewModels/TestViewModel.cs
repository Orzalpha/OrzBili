using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;
using OrzBili.Core.Contracts.Services;
using OrzBili.Models;
using OrzBili.Models.BangumiDetailModel;
using OrzBili.Services;
using Windows.Storage;

namespace OrzBili.ViewModels;


public partial class TestViewModel : ObservableRecipient, INavigationAware
{
    //private readonly IGetpgcService _getpgcService;

    [ObservableProperty]
    public string testContent = "something";

    private readonly INavigationService _navigationService;
    private readonly IFileService _fileService;
    private readonly IBiliApiService _biliApiService;

    public TestViewModel(INavigationService navigationService, IFileService fileService, IBiliApiService biliApiService)
    {
        _navigationService = navigationService;
        _fileService = fileService;
        _biliApiService = biliApiService;

        
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
        TestContent = "updated!";
        Items.Add(new gridviewItem { Source = "http://i0.hdslb.com/bfs/bangumi/image/20ee5a611f71b848d2136aa93ad8fbf5d1b2b23a.png" });
        //var paras = new ApiParameterModel.BangumiDetailPara(5997, null);
        //var result = await _biliApiService.GetInfoAsync(BiliApiService.Info.BangumiDetail, paras) as BangumiDetail;
        //TestContent = result!.code!.ToString()!;
        await Task.CompletedTask;
        return;
    }

}
public class gridviewItem
{
    public string Source { get; set; } = string.Empty;
}