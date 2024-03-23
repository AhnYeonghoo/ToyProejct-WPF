using ClassCommands.Services;
using ClassCommands.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCommands.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public BuyViewModel BuyViewModel { get; set; }
        public SellViewModel SellViewModel { get; }

        public MainViewModel()
        {
            OwnedItemsStore ownedItemStore = new OwnedItemsStore();
            PriceService priceService = new PriceService();

            BuyViewModel = new BuyViewModel(ownedItemStore, priceService);
            SellViewModel = new SellViewModel(ownedItemStore, priceService);
        }
    }
}
