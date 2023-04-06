using CommunityToolkit.Mvvm.ComponentModel;
using OrzBili.Core.Contracts.Services;
using Windows.Storage;

namespace OrzBili.ViewModels;

public class UserViewModel : ObservableRecipient
{
    private readonly string cookiePath = "UserInfo/cookie.json";
    private readonly IFileService fileService;
    public UserViewModel()
    {
        fileService = App.GetService<IFileService>();


    }
}
