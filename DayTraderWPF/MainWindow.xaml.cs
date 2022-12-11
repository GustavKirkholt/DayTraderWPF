using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using DayTraderWPF.ViewModels;
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
       

        }

    }
}
