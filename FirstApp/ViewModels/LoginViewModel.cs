using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        private string userName;
        
        private INavigationService navService;
        private bool userIsValid = true;

        public ICommand AuthCommand { get; private set; }

        public LoginViewModel(INavigationService navigationService)
        {
            navService = navigationService;
            AuthCommand = new RelayCommand(Auth);

        }
        public string UserName
        {
            get { return this.userName; }
            set
            {
                this.userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public bool UserIsValid
        {
            get { return this.userIsValid; }
            set
            {
                this.userIsValid = value;
                RaisePropertyChanged("UserIsValid");
            }
        }

        public void Auth()
        {
            if (this.userName == "username")
            {
                navService.NavigateTo("MapPage");

            }
            UserIsValid = false;
        }



    }
}
