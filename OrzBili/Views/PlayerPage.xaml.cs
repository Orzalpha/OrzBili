using Microsoft.UI.Xaml.Controls;

using OrzBili.ViewModels;

namespace OrzBili.Views;

public sealed partial class PlayerPage : Page
{
    public PlayerViewModel ViewModel
    {
        get;
    }

    public PlayerPage()
    {
        ViewModel = App.GetService<PlayerViewModel>();
        InitializeComponent();
    }
}
