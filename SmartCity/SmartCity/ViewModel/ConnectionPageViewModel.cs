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
    public class ConnectionPageViewModel: ViewModelBase, INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        private ICommand _goToInscriptionPageCommand;


        public ConnectionPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand GoToInscriptionPageCommand
        {
            get
            {
                if (this._goToInscriptionPageCommand == null)
                {
                    this._goToInscriptionPageCommand = new RelayCommand(() => GoToInscriptionPage());
                }
                return this._goToInscriptionPageCommand;
            }
        }
        private void GoToInscriptionPage()
        {
            _navigationService.NavigateTo("InscriptionPage");

        }

    }
}




   
