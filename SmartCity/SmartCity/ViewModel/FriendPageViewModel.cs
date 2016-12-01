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
    public class FriendPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        private ICommand _goToMapPageCommand;
        public FriendPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
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
