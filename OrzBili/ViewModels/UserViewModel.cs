using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using OrzBili.ApiModels.BangumiListModell;
using OrzBili.Contracts.Records;
using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;
using OrzBili.Core.Contracts.Services;
using OrzBili.Models;
using Windows.Storage;

namespace OrzBili.ViewModels;

public class UserViewModel : ObservableRecipient, INavigationAware
{
    private long Mid { get; set; } = -1;

    public ObservableCollection<BangumiListItem> BangumiListItems
    {
        get; set;
    } = new();

    private readonly INavigationService _navigationService;
    private readonly IBiliApiService _biliApiService;
    private readonly IBiliGlobalRecord _biliGlobalRecord;


    public UserViewModel(
        INavigationService navigationService,
        IBiliApiService biliApiService,
        IBiliGlobalRecord biliGlobalRecord)
    {
        _navigationService = navigationService;
        _biliApiService = biliApiService;
        _biliGlobalRecord = biliGlobalRecord;
    }



    public void OnNavigatedFrom()
    {

    }
    public async void OnNavigatedTo(object parameter)
    {
        lock (_biliGlobalRecord)
        {
            if (_biliGlobalRecord.Mid != null)
            {
                Mid = (long)_biliGlobalRecord.Mid;
            }
        }
        if (Mid != -1)
        {
            var para = new ApiParameterModel.BangumiListPara(Mid, 1);
            if (await _biliApiService.GetInfoAsync(Services.BiliApiService.Info.BangumiList, para) is BangumiList result &&
                result.data != null &&
                result.data.list != null)
            {
                foreach (var item in result.data.list)
                {
                    BangumiListItems.Add(item);
                }
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

    }
}
