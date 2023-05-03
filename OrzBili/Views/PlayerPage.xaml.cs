using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using OrzBili.Models.BangumiDetailModel;
using OrzBili.ViewModels;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Core;

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

        AnimePlayerElement.SetMediaPlayer(ViewModel.AnimePlayer);
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
