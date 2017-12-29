using FirstApp.ViewModels;
using Windows.UI.Xaml.Controls;

namespace FirstApp.Views
{
    public sealed partial class MapPage : Page
    {
        public MapPage()
        {
            this.InitializeComponent();
            MapViewModel mapVm = new MapViewModel();
            mapVm.InitPoi(mapControl);
        }
    }
}
