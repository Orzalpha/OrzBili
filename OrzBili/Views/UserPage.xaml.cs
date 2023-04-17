using Microsoft.UI.Xaml.Controls;

using OrzBili.ViewModels;

namespace OrzBili.Views;

public sealed partial class UserPage : Page
{
    public UserViewModel ViewModel
    {
        get;
    }

    public UserPage()
    {
        ViewModel = App.GetService<UserViewModel>();
        InitializeComponent();
    }

}
