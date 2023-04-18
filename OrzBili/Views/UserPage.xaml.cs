using System.Numerics;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Hosting;
using OrzBili.ApiModels.BangumiListModell;
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

    private void StackPanel_PointerEntered(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {
        var visual = ElementCompositionPreview.GetElementVisual(sender as UIElement);
        var compositor = visual.Compositor;

        // Create an animation to move the element up
        var offsetAnimation = compositor.CreateVector3KeyFrameAnimation();
        offsetAnimation.Target = "Offset";
        offsetAnimation.InsertKeyFrame(1.0f, new Vector3(0, -10, 0));
        offsetAnimation.Duration = TimeSpan.FromMilliseconds(300);

        visual.StartAnimation("Offset", offsetAnimation);
    }

    private void StackPanel_PointerExited(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {
        var visual = ElementCompositionPreview.GetElementVisual(sender as UIElement);
        var compositor = visual.Compositor;

        // Create an animation to move the element back to its original position
        var offsetAnimation = compositor.CreateVector3KeyFrameAnimation();
        offsetAnimation.Target = "Offset";
        offsetAnimation.InsertKeyFrame(1.0f, new Vector3(0, 0, 0));
        offsetAnimation.Duration = TimeSpan.FromMilliseconds(300);

        visual.StartAnimation("Offset", offsetAnimation);
    }

    private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (BangumiListGridview.SelectedItem is BangumiListItem item)
        {
            if (item.season_id!=null&&item.media_id!=null)
            {
                ViewModel.JumptoPlay((int)item.season_id, (int)item.media_id);
            }
        }
    }
}
