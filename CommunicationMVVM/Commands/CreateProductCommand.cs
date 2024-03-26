using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationMVVM.Models;
using CommunicationMVVM.ViewModels;
using CommunicationMVVM.Stores;

namespace CommunicationMVVM.Commands
{
    public class CreateProductCommand : CommandBase
    {
        private readonly CreateProductViewModel _viewModel;
        private readonly ProductStore _productStore;

        public CreateProductCommand(CreateProductViewModel viewModel, ProductStore productStore)        {
            _viewModel = viewModel;
            _productStore = productStore;
        }

        public override void Execute(object parameter)
        {
            Product product = new Product()
            {
                Name = _viewModel.ProductName,
                Quantity = _viewModel.ProductQuantity,
                Price = _viewModel.ProductPrice
            };
            _productStore.CreateProduct(product);
        }
    }
}
