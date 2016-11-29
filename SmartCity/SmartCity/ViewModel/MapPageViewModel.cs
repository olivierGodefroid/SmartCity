using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SmartCity.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Maps;

namespace SmartCity.ViewModel
{
    public class MapPageViewModel : ViewModelBase
    {

        private CategoryInfrastructure _categoryInfrastructure;
        private INavigationService _navigationService;
        private ICommand _goToFriendPageCommand;

        public MapPageViewModel(INavigationService navigationService)
        {
            GetCategoryInfrastructureService();
            _navigationService = navigationService;
        }

        public ICommand GoToFriendPageCommand
        {
            get
            {
                if (this._goToFriendPageCommand == null)
                {
                    this._goToFriendPageCommand = new RelayCommand(() => GoToMapPage());
                }
                return this._goToFriendPageCommand;
            }
        }
        private void GoToMapPage()
        {
            _navigationService.NavigateTo("FriendPage");

        }

        public CategoryInfrastructure CategoryInfrastructure
        {
            get { return _categoryInfrastructure; }
            set
            {
                _categoryInfrastructure = value;
                GetTypeInfrastructureService(_categoryInfrastructure.IdCategoryInfrastructure);
                RaisePropertyChanged("CategoryInfrastructure");
            }
        }

        private ObservableCollection<CategoryInfrastructure> _categoryInfrastructures;
        public ObservableCollection<CategoryInfrastructure> CategoryInfrastructures
        {
            get { return _categoryInfrastructures; }
            set
            {
                _categoryInfrastructures = value;
                RaisePropertyChanged("CategoryInfrastructures");
            }
        }
        private ObservableCollection<TypeInfrastructure> _typeInfrastructures;
        public ObservableCollection<TypeInfrastructure> TypeInfrastructures
        {
            get { return _typeInfrastructures; }
            set
            {
                _typeInfrastructures = value;
                RaisePropertyChanged("TypeInfrastructures");
            }
        }

        private MapControl _mapCenter;
        public MapControl MapCenter{ get { return _mapCenter; }set { _mapCenter = value; } }       

        public async Task GetCategoryInfrastructureService()
        {
            CategoryInfrastructureService categoryInfrastructureService = new CategoryInfrastructureService();
            var tmp = await categoryInfrastructureService.GetCategoryInfrastructure();
            CategoryInfrastructures = new ObservableCollection<CategoryInfrastructure>(tmp);
        }



        public async Task GetTypeInfrastructureService(long idCategoryInfrastructure)
        {
            TypeInfrastructureService typeInfrastructureService = new TypeInfrastructureService();
            var tmp = await typeInfrastructureService.GetTypeInfrastructure(idCategoryInfrastructure);
           TypeInfrastructures = new ObservableCollection<TypeInfrastructure>(tmp);
        }









        /* private async void MyMap_Loaded(object sender, RoutedEventArgs e)
         {
             Geolocator gl = new Geolocator
             {
                 DesiredAccuracy = PositionAccuracy.High
             };
             Geoposition gp = await gl.GetGeopositionAsync(maximumAge: TimeSpan.FromMinutes(1), timeout: TimeSpan.FromSeconds(20));
             _mapCenter.Center = new Geopoint(new BasicGeoposition()
             { 

                 Latitude = gp.Coordinate.Point.Position.Latitude,
                 Longitude = gp.Coordinate.Point.Position.Longitude,
             });

             _mapCenter.ZoomLevel = 16;
         }*/

    }
}
