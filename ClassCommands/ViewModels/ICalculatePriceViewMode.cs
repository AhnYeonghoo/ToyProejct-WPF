using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCommands.ViewModels
{
    public interface ICalculatePriceViewMode : INotifyPropertyChanged
    {
        string ItemName { get; }
        int Quantity { get; }
        bool CanCalculatePrice { get; }
        string StatusMessage { set; }
        string ErrorMessage { set; }
    }
}
