using DayTraderWPF.Models;
using DayTraderWPF.Views;
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
using System.Windows.Shapes;

namespace DayTraderWPF
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var balance = BankAccount.Instance.Balance;
            InitializeComponent();
            FrameForPageContent.Content = new DashboardPage();

        }

        private void FrameForPageContent_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            
        }

        private void BtnClickDashboard(object sender, RoutedEventArgs e)
        {       
                // below does not load xml
                // FrameForPageContent.Navigate(typeof(DashboardPage));

                FrameForPageContent.Content = new DashboardPage();
        }


        private void BtnClickDiscover(object sender, RoutedEventArgs e)
        {
            FrameForPageContent.Content = new DiscoverPage();
        }


        private void BtnClickPortfolio(object sender, RoutedEventArgs e)
        {
            FrameForPageContent.Content = new PortfolioPage();
        }



    }
}
