using GalaSoft.MvvmLight;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;
using Windows.UI.ViewManagement;

namespace FirstApp.ViewModels
{
    public class MapViewModel : ViewModelBase
    {
        List<string> overlayPoi = new List<string>();
        public MapViewModel()
        {
            //Go in FullScreen Mode
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
           
        }

        public void InitPoi(MapControl mapControl)
        {

            //SetUp Initial Position

            mapControl.ZoomLevel = 1;
            mapControl.LandmarksVisible = true;

            //Adding a  POI (for example a store)
            BasicGeoposition snPosition = new BasicGeoposition() { Latitude = 43.044944, Longitude = 12.493706 };
            Geopoint snPoint = new Geopoint(snPosition);
            MapIcon mapIconStore = new MapIcon
            {
                Location = snPoint,
                NormalizedAnchorPoint = new Point(0.5, 1.0),
                Title = "Store",
                ZIndex = 0,

            };

            // Add the POI to the map.
            mapControl.MapElements.Add(mapIconStore);

            //Adding Other Point Of Interest (for example a stock)
            BasicGeoposition snPositionStock = new BasicGeoposition() { Latitude = 45.170090, Longitude = -110.132821 };
            Geopoint snPointStock = new Geopoint(snPositionStock);
            MapIcon mapIconStock = new MapIcon
            {
                Location = snPointStock,
                NormalizedAnchorPoint = new Point(0.5, 1.0),
                Title = "Stock",
                ZIndex = 0,

            };
            mapControl.MapElements.Add(mapIconStock);

            snPosition = new BasicGeoposition() { Latitude = 34.835967, Longitude = 96.585928 };
            snPoint = new Geopoint(snPosition);
            MapIcon mapIconAnotherStore = new MapIcon
            {
                Location = snPoint,
                NormalizedAnchorPoint = new Point(0.5, 1.0),
                Title = "Another Store",
                ZIndex = 0,

            };
            mapControl.MapElements.Add(mapIconAnotherStore);

        }
    }
}

