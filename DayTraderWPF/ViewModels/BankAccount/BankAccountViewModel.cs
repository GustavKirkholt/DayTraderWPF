using DayTraderWPF.Stores;
using DayTraderWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;

namespace DayTraderWPF.ViewModels.BankAccount
{
    public class BankAccountViewModel : ViewModelBase
    {
            private readonly BankAccountStore _selectedBankAccountStore;

            public decimal Balance { get; set; }
          

            public BankAccountViewModel(BankAccountStore selectedBankAccountStore) 
            {
                Balance = 10000;
                _selectedBankAccountStore = selectedBankAccountStore;
                _selectedBankAccountStore.SelectedBankAccountChanged += SelectedBankAccountStore_SelectedBankAccountChanged;
            }

            

            private void SelectedBankAccountStore_SelectedBankAccountChanged()
            {
                OnPropertyChanged(nameof(Balance));
 
            }

        }

    }

