using DayTraderWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.Stores
{
    public class BankAccountStore
    {
        
            private BankAccountModel _selectedBankAccount;

            public BankAccountModel SelectedBankAccount
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
