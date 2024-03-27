using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardMVVM.ViewModels
{
    public class RecentSalesViewModel : ViewModelBase
    {
        private readonly ObservableCollection<SaleViewModel> _recentSales;
        public IEnumerable<SaleViewModel> RecentSales => _recentSales;

        public RecentSalesViewModel()
        {
            _recentSales = new ObservableCollection<SaleViewModel>()
            {
                new SaleViewModel("Hat", new decimal(19.00)),
                new SaleViewModel("Shoes", new decimal(119.99)),
                new SaleViewModel("T-SHirt", new decimal(34.99)),
            };
        }
    }
}
