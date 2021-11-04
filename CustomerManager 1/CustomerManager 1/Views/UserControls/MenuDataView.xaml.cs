using CustomerManager_1.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerManager_1.Views.UserControls
{
    /// <summary>
    /// Interaction logic for FoodsView.xaml
    /// </summary>
    public partial class MenuDataView : UserControl
    {
        public MenuDataView()
        {
            InitializeComponent();
        }

        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var displayName = Extensions.GetPropertyExtension.GetPropertyDisplayName(e.PropertyDescriptor);

            if (!string.IsNullOrEmpty(displayName))
            {
                e.Column.Header = displayName;
            }

        }

        


        private void Sample1_DialogHost_OnDialogClosing(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {
            if (Equals(eventArgs.Parameter, true))
                (App.Current.Resources["Locator"] as ViewModelLocator).Menu.DeleteMenuCommand.Execute(eventArgs.Parameter);

        }

        private void _window_Loaded(object sender, RoutedEventArgs e)
        {
            var move = new DoubleAnimation(-2000, 0, new TimeSpan(0, 0, 2));

            Save_btn.RenderTransform = new TranslateTransform();
            Save_btn.RenderTransform.BeginAnimation(TranslateTransform.YProperty, move);
            Save_btn.RenderTransform.BeginAnimation(TranslateTransform.XProperty, move);
        }
    }
}
