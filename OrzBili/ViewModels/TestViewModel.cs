using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;
using OrzBili.Core.Contracts.Services;
using Windows.Storage;

namespace OrzBili.ViewModels;

public partial class TestViewModel : ObservableRecipient, INavigationAware
{
    //private readonly IGetpgcService _getpgcService;

    [ObservableProperty]
    public string? testContent;

    private readonly INavigationService _navigationService;
    private readonly IFileService _fileService;
    private readonly IBiliApiService _biliApiService;

    public TestViewModel(INavigationService navigationService, IFileService fileService, IBiliApiService biliApiService)  
    {
        _navigationService = navigationService;
        _fileService = fileService;
        _biliApiService = biliApiService;
        
    }

    public void OnNavigatedTo(object parameter)
    {
    
    }

    public void OnNavigatedFrom() { }

    [RelayCommand]
    public async void Button()
    {
        //var result = await _getpgcService.Testtask();
        //TestContent = string.Empty;
        //foreach (var res in result)
        //{
        //    TestContent += res.ToString() + '\n';
        //}

        var account = await _biliApiService.GetAccountInfoAsync();
        TestContent = account.ToString();
        await Task.CompletedTask;
    }

}
    