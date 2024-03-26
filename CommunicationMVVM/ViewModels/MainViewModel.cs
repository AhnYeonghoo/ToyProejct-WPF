using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public CreateProductViewModel CreateProductViewModel { get; }
        public ProductListingViewModel ProductListingViewModel { get; }
        public MainViewModel(CreateProductViewModel createProductViewModel, ProductListingViewModel productListingViewModel)
        {
            CreateProductViewModel = createProductViewModel;
            ProductListingViewModel = productListingViewModel;
        }
    }
}
