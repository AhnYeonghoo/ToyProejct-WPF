using ClassCommands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCommands.Stores
{
    public interface IOwnedItemsStore
    {
        IEnumerable<OwnedItem> OwnedItems { get; }
        event Action OwnedItemsChanged;

        void Buy(string itemName, int quantity);
        void Sell(string itemName, int quantity);
    }
}
