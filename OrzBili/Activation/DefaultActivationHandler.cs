using Microsoft.UI.Xaml;

using OrzBili.Contracts.Services;
using OrzBili.Contracts.Records;
using OrzBili.ViewModels;
using OrzBili.Core.Contracts.Services;
using OrzBili.Models;
using Windows.Storage;

namespace OrzBili.Activation;

public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    private readonly INavigationService _navigationService;
    private readonly IFileService _fileService;
    private readonly IBiliGlobalRecord _biliGlobalRecord;
    private readonly IBiliApiService _biliApiService;

    public DefaultActivationHandler(
        INavigationService navigationService,
        IFileService fileService, 
        IBiliGlobalRecord biliGlobalRecord,
        IBiliApiService biliApiService)
    {
        _navigationService = navigationService;
        _fileService = fileService;
        _biliGlobalRecord = biliGlobalRecord;
        _biliApiService = biliApiService;
    }

    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return _navigationService.Frame?.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        var storageInfo =  _fileService.Read<UserStorageInfoModel>(ApplicationData.Current.LocalFolder.Path, "StoredInfo.json");
        if (storageInfo == null)
        {
            _navigationService.NavigateTo(typeof(LoginViewModel).FullName!, args.Arguments);
        }
        else
        {
            _biliApiService.SetCookie(storageInfo.Cookie);
            lock(_biliGlobalRecord)
            {
                _biliGlobalRecord.Mid = storageInfo.Mid;
            }
            _navigationService.NavigateTo(typeof(UserViewModel).FullName!, args.Arguments);
        }
        
        await Task.CompletedTask;
    }
}
