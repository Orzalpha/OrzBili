using CommunityToolkit.Mvvm.ComponentModel;
using OrzBili.Contracts.Records;
using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;
using OrzBili.Core.Contracts.Services;
using OrzBili.Models;
using Windows.Storage;

namespace OrzBili.ViewModels;

public class UserViewModel : ObservableRecipient , INavigationAware
{
    public long Mid
    {
        get;
        set;
    }

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
    public void OnNavigatedTo(object parameter)
    {
        lock(_biliGlobalRecord)
        {
            if (_biliGlobalRecord.Mid != null)
            {
                Mid = (long)_biliGlobalRecord.Mid;
            }
            else
            {
                Mid = -1;
            }
        }
        if (Mid == -1)
        {
            // to set a flyout
            return;
        }

        
    }
}
