using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayTraderWPF.Stores;
using System.Windows.Input;
using DayTraderWPF.ViewModels.BankAccount;
using DayTraderWPF.Commands;

namespace DayTraderWPF.ViewModels
{
    internal class DashboardViewModel : ViewModelBase
    {
        public ICommand SellStockCommand { get; }
        public ICommand BuyStockCommand { get; }

        public DashBoardListViewModel DashBoardListViewModel { get; }

        public DashboardMainDetailsViewModel DashboardMainDetailsViewModel { get; }

        public BankAccountViewModel BankAccountViewModel { get; }


        public DashboardViewModel(StocksStore _selectedStockStore, BankAccountStore _selectedBankAccountStore) 
        {
            DashBoardListViewModel = new DashBoardListViewModel(_selectedStockStore);
            DashboardMainDetailsViewModel = new DashboardMainDetailsViewModel(_selectedStockStore);
            BankAccountViewModel = new BankAccountViewModel(_selectedBankAccountStore);

            SellStockCommand = new SellStockCommand(_selectedStockStore, _selectedBankAccountStore);
            BuyStockCommand = new BuyStockCommand(_selectedStockStore, _selectedBankAccountStore);
        }
    }
}
