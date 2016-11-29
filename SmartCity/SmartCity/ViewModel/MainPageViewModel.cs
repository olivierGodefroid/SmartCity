using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartCity.ViewModel
{
    public class MainPageViewModel : ViewModelBase,INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        private ICommand _goToConnectionPageCommand;
        private ICommand _goToMapPageCommand;


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        public ICommand GoToConnectionPageCommand
        {
            get
            {
                if (this._goToConnectionPageCommand == null)
                {
                    this._goToConnectionPageCommand = new RelayCommand(() => GoToConnectionPage());
                }
                return this._goToConnectionPageCommand;
            }
        }
        private void GoToConnectionPage()
        {
            _navigationService.NavigateTo("ConnectionPage");

        }
        public ICommand GoToMapPageCommand
        {
            get
            {
                if (this._goToMapPageCommand == null)
                {
                    this._goToMapPageCommand = new RelayCommand(() => GoToMapPage());
                }
                return this._goToMapPageCommand;
            }
        }
        private void GoToMapPage()
        {
            _navigationService.NavigateTo("MapPage");

        }
    }
}
