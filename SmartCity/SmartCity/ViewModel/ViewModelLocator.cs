
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using SmartCity.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<ConnectionPageViewModel>();
            SimpleIoc.Default.Register<MapPageViewModel>();
            SimpleIoc.Default.Register<InscriptionPageViewModel>();
            SimpleIoc.Default.Register<FriendPageViewModel>();
            NavigationService navigationPages = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationPages);

            navigationPages.Configure("MainPage", typeof(MainPage));
            navigationPages.Configure("ConnectionPage", typeof(ConnectionPage));
            navigationPages.Configure("MapPage", typeof(MapPage));
            navigationPages.Configure("InscriptionPage", typeof(InscriptionPage));
            navigationPages.Configure("FriendPage", typeof(FriendPage));

        }
        public MainPageViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            }
        }
        public ConnectionPageViewModel Connection
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ConnectionPageViewModel>();
            }
        }
        public MapPageViewModel Map
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MapPageViewModel>();

            }
        }
        public InscriptionPageViewModel Inscription
        {
            get
            {
                return ServiceLocator.Current.GetInstance<InscriptionPageViewModel>();
            }
        }
        public FriendPageViewModel Friend
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FriendPageViewModel>();
            }
        }
    }
   
}
