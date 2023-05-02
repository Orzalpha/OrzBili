using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrzBili.ApiModels.BangumiListModell;
using OrzBili.Contracts.Records;
using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;
using OrzBili.Core.Contracts.Services;
using OrzBili.Core.Services;
using OrzBili.Models;
using Windows.Storage;

namespace OrzBili.ViewModels;

public partial class UserViewModel : ObservableRecipient, INavigationAware
{
    private long mid { get; set; } = -1;
    private int total { get; set; } = 0;
    private int nowPage { get; set; } = 1;
    private readonly object nowPageLock = new();
    public int totalPage => (total + 29) / 30;

    [ObservableProperty]
    public bool isLoading = false;
    [ObservableProperty]
    public bool infobarVisibility = false;

    public ObservableCollection<BangumiListItem> BangumiListItems { get; set; } = new();

    private readonly INavigationService _navigationService;
    private readonly IBiliApiService _biliApiService;
    private readonly IBiliGlobalRecord _biliGlobalRecord;
    private readonly IFileService _fileService;


    public UserViewModel(
        INavigationService navigationService,
        IBiliApiService biliApiService,
        IBiliGlobalRecord biliGlobalRecord,
        IFileService fileService
        )
    {
        _navigationService = navigationService;
        _biliApiService = biliApiService;
        _biliGlobalRecord = biliGlobalRecord;
        _fileService = fileService;
    }

    [RelayCommand]
    public async void LoadMore()
    {
        lock (nowPageLock)
        {
            if (nowPage >= totalPage)
            {
                return;
            }
            nowPage++;
        }
        var para = new ApiParameterModel.BangumiListPara(mid, 1);
        para.pn = nowPage;
        if (await _biliApiService.GetInfoAsync(Services.BiliApiService.Info.BangumiList, para) is BangumiList result)
        {
            if (result.data != null && result.data.list != null)
            {
                foreach (var item in result.data.list)
                {
                    BangumiListItems.Add(item);
                }
            }
        }
        return;
    }

    [RelayCommand]
    public void Logout()
    {
        _fileService.Delete(ApplicationData.Current.LocalFolder.Path, "StoredInfo.json");
        InfobarVisibility = true;
    }

    public void JumptoPlay(int season_id, int media_id)
    {
        var para = new NavigateParaModel.PlayerpagePara(season_id, media_id);
        _navigationService.NavigateTo(typeof(PlayerViewModel).FullName!, para);
    }

    public void OnNavigatedFrom()
    {

    }
    public async void OnNavigatedTo(object parameter)
    {
        IsLoading = true;
        lock (_biliGlobalRecord)
        {
            if (_biliGlobalRecord.Mid != null)
            {
                mid = (long)_biliGlobalRecord.Mid;
            }
        }
        if (mid != -1)
        {
            var para = new ApiParameterModel.BangumiListPara(mid, 1);
            if (await _biliApiService.GetInfoAsync(Services.BiliApiService.Info.BangumiList, para) is BangumiList result)
            {
                if (result.data != null && result.data.list != null)
                {
                    foreach (var item in result.data.list)
                    {
                        BangumiListItems.Add(item);
                    }
                }
                total = (int)(result.data != null && result.data.total != null ? result.data.total : 0);


            }
            else
            {
                // to set a flyout
                return;
            }
        }
        else
        {
            // to set a flyout
            return;
        }
        IsLoading = false;

    }
}
