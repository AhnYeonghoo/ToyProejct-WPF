using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCommands.Services
{
    public interface IPriceService
    {
        double GetPrice(string itemName);
    }
}
