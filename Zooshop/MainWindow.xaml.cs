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

namespace Zooshop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void butAdmin_Click(object sender, RoutedEventArgs e)
        {
            View.Win_PriceList win_PriceList = new View.Win_PriceList();
            this.Hide();
            win_PriceList.ShowDialog();
            this.ShowDialog();
        }

        private void toOrder_Click(object sender, RoutedEventArgs e)
        {
            View.Wind_CreateOrder wind_CreateOrder = new View.Wind_CreateOrder();
            this.Hide();
            wind_CreateOrder.ShowDialog();
            this.ShowDialog();
        }

        private void updateCatalog_Click(object sender, RoutedEventArgs e)
        {
            View.Autorization autorization = new View.Autorization();
            this.Hide();
            autorization.ShowDialog();
            this.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void exit_MouseEnter(object sender, MouseEventArgs e)
        {
            catExitSit.Visibility = Visibility.Hidden;
            catExitStand.Visibility = Visibility.Visible;
        }

        private void exit_MouseLeave(object sender, MouseEventArgs e)
        {
            catExitSit.Visibility = Visibility.Visible;
            catExitStand.Visibility = Visibility.Hidden;
        }

        private void catExitSit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
