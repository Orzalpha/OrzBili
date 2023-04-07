using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrzBili.Contracts.Services;
using Windows.Storage;

namespace OrzBili.ViewModels;

public partial class TestViewModel : ObservableRecipient
{
    //private readonly IGetpgcService _getpgcService;

    [ObservableProperty]
    public string? testContent;

    public TestViewModel()
    {
        //_getpgcService = App.GetService<IGetpgcService>();
    }

    [CommunityToolkit.Mvvm.Input.RelayCommand]
    public async void Button()
    {
        //var result = await _getpgcService.Testtask();
        //TestContent = string.Empty;
        //foreach (var res in result)
        //{
        //    TestContent += res.ToString() + '\n';
        //}
        //return;
    }
   
}
    