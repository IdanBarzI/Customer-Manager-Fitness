using System;
using CommonServiceLocator;
using CustomerManager_1.Services.IService;
using CustomerManager_1.Services.Service;
using GalaSoft.MvvmLight.Ioc;

namespace CustomerManager_1.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<NavigationViewModel>();
            SimpleIoc.Default.Register<DashBoardViewModel>();
            SimpleIoc.Default.Register<CustomersViewModel>();
            SimpleIoc.Default.Register<CustomerFormViewModel>();
            SimpleIoc.Default.Register<FoodViewModel>();
            SimpleIoc.Default.Register<MenuViewModel>();

            SimpleIoc.Default.Register<IDashBoardService, DashBoardService>();
            SimpleIoc.Default.Register<ICustomersService, CustomersService>();
            SimpleIoc.Default.Register<IFoodDataService, FoodDataService>();
            SimpleIoc.Default.Register<IMenuService, MenuService>();

            SetupNavigation();
        }

        private static void SetupNavigation()
        {
            FrameNavigationService navigationService = new FrameNavigationService();

            navigationService.Configure("DashBordView", new Uri("../Views/DashBordView.xaml", UriKind.Relative));
            navigationService.Configure("CustomersView", new Uri("../Views/CustomersView.xaml", UriKind.Relative));
            navigationService.Configure("MenuView", new Uri("../Views/MenuView.xaml", UriKind.Relative));
            navigationService.Configure("CustomerView", new Uri("../Views/CustomerView.xaml", UriKind.Relative));

            SimpleIoc.Default.Register<IFrameNavigationService>(() => navigationService);
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public NavigationViewModel Navigation => ServiceLocator.Current.GetInstance<NavigationViewModel>();
        public DashBoardViewModel DashBoard => ServiceLocator.Current.GetInstance<DashBoardViewModel>();
        public CustomersViewModel Customers => ServiceLocator.Current.GetInstance<CustomersViewModel>();
        public CustomerFormViewModel CustomerForm => ServiceLocator.Current.GetInstance<CustomerFormViewModel>();
        public FoodViewModel Foods => ServiceLocator.Current.GetInstance<FoodViewModel>();
        public MenuViewModel Menu => ServiceLocator.Current.GetInstance<MenuViewModel>();
    }
}