using System;
using System.Collections.Generic;
using ClassCommands.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCommands.Stores
{
    public class OwnedItemsStore : IOwnedItemsStore
    {
        private readonly List<OwnedItem> _ownedItems;
        public IEnumerable<OwnedItem> OwnedItems => _ownedItems.Where(i => i.Quantity > 0);
        public event Action OwneItemsChanged;

        public OwnedItemsStore()
        {
            _ownedItems = new List<OwnedItem>();
        }

        public void Buy(string itemName, int quantity)
        {
            OwnedItem existingOwnedItem = _ownedItems.FirstOrDefault(i => i.Name == itemName);

            if (existingOwnedItem == null)
            {
                _ownedItems.Add(new OwnedItem()
                {
                    Name = itemName,
                    Quantity = quantity
                });
                
            }
            else
            {
                existingOwnedItem.Quantity += quantity;
            }
            OnOwnedItemsChanged();
        }

        public void Sell(string itemName, int quantity)
        {
            OwnedItem existingOwnedItem = _ownedItems.FirstOrDefault(i => i.Name == itemName);
            if (existingOwnedItem != null)
            {
                existingOwnedItem.Quantity -= quantity;
            }
            OnOwnedItemsChanged();
        }

        private void OnOwnedItemsChanged()
        {
            OwnedItemsChanged?.Invoke();
        }

    }
}
