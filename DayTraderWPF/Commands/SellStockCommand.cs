using DayTraderWPF.Models;
using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Commands
{
    internal class SellStockCommand : CommandBase
    {
        private readonly StocksStore _selectedStockStore;
        private Stocks SelectedStock => _selectedStockStore.SelectedStock;

        private readonly BankAccountStore _selectedBankAccountStore;

        private BankAccountModel SelectedBankAccount => _selectedBankAccountStore.SelectedBankAccount;

        public SellStockCommand(StocksStore selectedStockStore, BankAccountStore selectedBankAccountStore)
        {
            _selectedStockStore = selectedStockStore;
            _selectedBankAccountStore = selectedBankAccountStore;
        }

        public override void Execute(object parameter)
        {
            if (SelectedStock.IsOwned == true)
            {
                SelectedStock.IsOwned = false;
                decimal cost = SelectedStock.Price;
                SelectedBankAccount.Deposit(cost);
            }
            else return;

        }
    }
}
