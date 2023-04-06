using Microsoft.UI.Xaml.Controls;

using OrzBili.ViewModels;

namespace OrzBili.Views;

public sealed partial class TestPage : Page
{
    public TestViewModel ViewModel
    {
        get;
    }

    public TestPage()
    {
        ViewModel = App.GetService<TestViewModel>();
        InitializeComponent();
    }
}
