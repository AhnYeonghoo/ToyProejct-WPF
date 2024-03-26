using CommunicationMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationMVVM.Stores
{
    public class ProductStore
    {
        public event Action<Product> ProductCreated;

        public void CreateProduct(Product product)
        {
            ProductCreated?.Invoke(product);
        }
    }
}
