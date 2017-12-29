using FirstApp.Views;
using FirstApp.ViewModels;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.ViewModels
{

    public class ViewModelLocator
    {

        public ViewModelLocator()
        {

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (ViewModelBase.IsInDesignModeStatic)
            {
            }
            else
            {
            }

           
            //With the code above we configure the navigation service, every entry must have a key/page pair to
            //correctly setup a navigation route
            SimpleIoc.Default.Register<INavigationService>(() =>
            {
                var navigationService = new NavigationService();
                navigationService.Configure("LoginPage", typeof(LoginPage));
                navigationService.Configure("MapPage", typeof(MapPage));
                return navigationService;
            });
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<MapViewModel>();
           
        }


        // <summary>
        //Here we get instances of every viewModel 
        // </summary>

        /// <summary>
        /// LogIn
        /// </summary>
        public LoginViewModel LoginPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }

        /// <summary>
        /// Map
        /// </summary>
        public MapViewModel MapPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MapViewModel>();
            }
        }


        //Cleaning ViewModels
        public static void Cleanup()
        {
           
        }
    }
}
