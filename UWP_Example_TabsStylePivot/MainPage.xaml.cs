using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UWP_Example_TabsStylePivot
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // The event handler below is optional if you want to change the accent color of the custom pivot
        // You can leave this out and the accent color will stay the same color as defined in page resources
        private void rootPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (rootPivot.SelectedItem == fileTab)
            {
                SolidColorBrush brush = (SolidColorBrush)Resources["pivotAccentColor"];
                brush.Color = Color.FromArgb(255, 0, 122, 204);
            }

            if (rootPivot.SelectedItem == editTab)
            {
                SolidColorBrush brush = (SolidColorBrush)Resources["pivotAccentColor"];
                brush.Color = Colors.Crimson;
            }

            if (rootPivot.SelectedItem == overlayTab)
            {
                SolidColorBrush brush = (SolidColorBrush)Resources["pivotAccentColor"];
                brush.Color = Colors.ForestGreen;
            }

            if (rootPivot.SelectedItem == drawTab)
            {
                SolidColorBrush brush = (SolidColorBrush)Resources["pivotAccentColor"];
                brush.Color = Colors.Gold;
            }
        }
    }
}
