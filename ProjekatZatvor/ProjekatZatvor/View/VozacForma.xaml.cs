using ProjekatZatvor.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VozacForma : Page, INotifyPropertyChanged
    {
        private UltraMegaGigaViewModel UltraMegaGiga;
        public VozacForma()
        {
            this.InitializeComponent();
            mapaVoz.Loaded += mapaVoz_Loaded;
        }

        private async void mapaVoz_Loaded(object sender, RoutedEventArgs e)
        {
            var center = new Geopoint(new BasicGeoposition()
            {
                Latitude = 48.8530,
                Longitude = 2.3498
            });

            //await mapaVoz.TrySetSceneAsync(MapScene.CreateFromLocationAndRadius(center, 3000));
            if (mapaVoz.IsStreetsideSupported)
            {
                //check that map is available for lat and long
                var panorama = await StreetsidePanorama.FindNearbyAsync(mapaVoz.Center);

                if (panorama != null)
                {
                    //create custom view
                    mapaVoz.CustomExperience = new StreetsideExperience(panorama);
                }
            }

            mapaVoz.ZoomLevel = 10;
            mapaVoz.Style = MapStyle.AerialWithRoads;
            if (mapaVoz.Is3DSupported)
            {
                //set style to 3D
                mapaVoz.Style = MapStyle.Aerial3D;

                //create a mapscene for lat and long
                //facing East (90 deg) and pitched 45 deg
                var locator = new Geolocator();
                locator.DesiredAccuracyInMeters = 10;

                var accessStatus = await Geolocator.RequestAccessAsync();
                switch (accessStatus)
                {
                    case GeolocationAccessStatus.Allowed:

                        // Get the current location.
                        Geolocator geolocator = new Geolocator();
                        Geoposition position = await geolocator.GetGeopositionAsync();
                        Geopoint myLocation = position.Coordinate.Point;

                        // Set the map location.
                        var mapScene = MapScene.CreateFromLocationAndRadius(position.Coordinate.Point, 18D);
                        await mapaVoz.TrySetSceneAsync(mapScene);
                        break;

                    case GeolocationAccessStatus.Denied:
                        // Handle the case  if access to location is denied.
                        break;

                    case GeolocationAccessStatus.Unspecified:
                        // Handle the case if  an unspecified error occurs.
                        break;
                }

                //var position = await locator.GetGeopositionAsync();

            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(LoginPage), this.DataContext);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
            this.DataContext = UltraMegaGiga;
            base.OnNavigatedTo(e);
        }

        private void listica1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int x=listica1.SelectedIndex;
            UltraMegaGiga.SelektovanaVoznja();
        }
    }
}
