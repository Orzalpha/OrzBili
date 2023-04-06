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

    private void TestButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TestTextBlock.Text = Environment.CurrentDirectory;
    }
}
