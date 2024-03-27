using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardMVVM.ViewModels
{
    public class SaleViewModel : ViewModelBase
    {
        public string Name { get; }
        public decimal Price { get; }
        public SaleViewModel(stgring name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
