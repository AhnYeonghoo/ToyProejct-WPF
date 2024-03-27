using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomObservableCollections.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        public int Id { get; }
        public string Item { get; }
        public DateTime DateCreated { get; }
        public OrderViewModel(int id, string item, DateTime dateCreated)
        {
            Id = id;
            Item = item;
            DateCreated = dateCreated;
        }
    }
}
