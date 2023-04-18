using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Navigation;
using OrzBili.Contracts.ViewModels;
using OrzBili.Models;

namespace OrzBili.ViewModels;

public class PlayerViewModel : ObservableRecipient, INavigationAware
{

    public PlayerViewModel()
    {
    }

    public void OnNavigatedFrom()
    {
    }
    public void OnNavigatedTo(object parameter)
    {
        if (parameter is NavigateParaModel.PlayerpagePara para)
        {

        }
        else
        {
            //  to set visibility
        }
    }
}
