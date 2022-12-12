using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DayTraderWPF.Commands
{
    internal class BuyStockCommand : CommandBase
    {

        private readonly StocksStore _selectedStockStore;
        private Stocks SelectedStock => _selectedStockStore.SelectedStock;

        private readonly BankAccountStore _selectedBankAccountStore;
        private BankAccountModel SelectedBankAccount => _selectedBankAccountStore.SelectedBankAccount;

        public BuyStockCommand(StocksStore selectedStockStore, BankAccountStore selectedBankAccountStore)
        {
            _selectedStockStore = selectedStockStore;
            _selectedBankAccountStore = selectedBankAccountStore;
        }

        public override void Execute(object parameter)
        {
            if (SelectedStock.IsOwned == false && SelectedBankAccount.Balance > SelectedStock.Price)
            {
                SelectedStock.IsOwned = true;
                decimal cost = SelectedStock.Price;
                SelectedBankAccount.Withdraw(cost);
            }
            else return;
            
        }
    }
}
