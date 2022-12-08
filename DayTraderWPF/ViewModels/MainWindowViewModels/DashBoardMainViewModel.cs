using DayTraderWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTraderWPF.ViewModels
{
    internal class DashBoardMainViewModel : ViewModelBase
    {
        //HERE GOES VIEW  MODEL FOR  THE  NEWS SCREEN
        private StocksStore selectedStocksStore;

        public DashBoardMainViewModel(StocksStore selectedStocksStore)
        {
            this.selectedStocksStore = selectedStocksStore;
        }
    }
}
