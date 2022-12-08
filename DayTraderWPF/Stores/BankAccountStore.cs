using DayTraderWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Stores
{
    internal class BankAccountStore
    {
        
            private BankAccount _selectedBankAccount;

            public BankAccount BankAccount
            {
                get
                {
                    return _selectedBankAccount;
                }

                set
                {
                     _selectedBankAccount = value;
                    SelectedBankAccountChanged?.Invoke();
                }

            }

            public event Action SelectedBankAccountChanged;

        }
   
}
