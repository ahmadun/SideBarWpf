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

namespace MenuWithSubMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            col_side.Width = new GridLength(200);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pn_sidebar.Visibility == Visibility.Visible)
            {

                col_side.Width = new GridLength(0);
                pn_sidebar.Visibility = Visibility.Collapsed;
            }
            else
            {
                col_side.Width = new GridLength(200);
                pn_sidebar.Visibility = Visibility.Visible;
            }
              
        }
    }
}
