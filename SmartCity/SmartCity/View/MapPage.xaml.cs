using SmartCity.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace SmartCity.View
{

    public sealed partial class MapPage : Page
    {
        MapPageViewModel mapPage;
        public MapPage()
        {
            this.InitializeComponent();
            map.Loaded += MyMap_Loaded;

        }
        private void MyMap_Loaded(object sender, RoutedEventArgs e)
        {
            map.Center = new Geopoint(new BasicGeoposition()
            {
                //Geopoint for Seattle 
                Latitude = 50.4669,
                Longitude = 4.867460
            });
            map.ZoomLevel = 16;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
        private void FriendButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { }
        //    if (LoisirItem.IsSelected)
        //    {
        //        AffichageMenuPrincipale(false);
        //        AffichageMenuLoisir(true);
        //    }
        //    else if (RestaurationItem.IsSelected)
        //    {
        //        AffichageMenuPrincipale(false);
        //        AffichageMenuRestauration(true);
        //    }
        //    else if (CommerceItem.IsSelected)
        //    {
        //        AffichageMenuPrincipale(false);
        //        AffichageMenuCommerces(true);
        //    }
        //    else if (MonumentsItem.IsSelected)
        //    {
        //        AffichageMenuPrincipale(false);
        //        AffichageMenuMonument(true);
        //    }
        //    else if (RetourItem.IsSelected)
        //    {
        //        AffichageMenuPrincipale(true);
        //        AffichageMenuMonument(false);
        //        AffichageMenuCommerces(false);
        //        AffichageMenuRestauration(false);
        //        AffichageMenuLoisir(false);
        //    }
        //    else if (BiblioItem.IsSelected) { }
        //    else if (AgoraItem.IsSelected) { }
        //    else if (SalleSportItem.IsSelected) { }
        //    else if (ItalienItem.IsSelected) { }
        //    else if (ChinoisItem.IsSelected) { }
        //    else if (JaponaisItem.IsSelected) { }
        //    else if (GrecItem.IsSelected) { }
        //    else if (MexicainItem.IsSelected) { }
        //    else if (ThaiItem.IsSelected) { }
        //    else if (SnackItem.IsSelected) { }
        //    else if (AlimentationItem.IsSelected) { }
        //    else if (TextileItem.IsSelected) { }
        //    else if (BricolageItem.IsSelected) { }
        //    else if (JeuxVideoItem.IsSelected) { }
        //    else if (BijouxItem.IsSelected) { }
        //    else if (BoulangerieItem.IsSelected) { }
        //    else if (HistoriqueItem.IsSelected) { }
        //    else if (CulturelItem.IsSelected) { }



    }
}
