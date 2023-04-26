using Microsoft.UI.Xaml.Controls;
using OrzBili.Models.BangumiDetailModel;
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

        ViewModel.mediaPlayerElement = PlayerElement;
    }

    private async void EpisodeListview_SelectionChange(object sender, SelectionChangedEventArgs e)
    {
        if (EpisodeListview.SelectedItem is Episode selectedEpisode)
        {
            ViewModel.PlayEpisode(selectedEpisode);
        }
        await Task.CompletedTask;
        return;
    }
}
