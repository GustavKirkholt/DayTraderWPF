﻿using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using DayTraderWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DayTraderWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly StocksStore _selectedStocksStore;

        public App() 
        {
            _selectedStocksStore = new StocksStore();
            
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            
            BankAccount bankAccount = BankAccount.Instance;

            MainWindow = new MainWindow()
            {
                DataContext = new DashboardViewModel(_selectedStocksStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
