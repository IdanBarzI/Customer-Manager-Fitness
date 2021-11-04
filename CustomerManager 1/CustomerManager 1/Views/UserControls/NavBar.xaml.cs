using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerManager_1.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();


            MinimizeBtn.Click += (s, e) => App.Current.MainWindow.WindowState = WindowState.Minimized;

            MaximizeBtn.Click += (s, e) =>
            {
                if (WindowState.Maximized == App.Current.MainWindow.WindowState)
                {
                    App.Current.MainWindow.WindowState = WindowState.Normal;
                }
                else
                {
                    App.Current.MainWindow.WindowState = WindowState.Maximized;
                }
            };

            CloseBtn.Click += (s, e) => App.Current.MainWindow.Close();
        }
    }
}
