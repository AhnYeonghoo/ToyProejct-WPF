using System;
using ClassCommands.Exceptions;
using ClassCommands.Stores;
using ClassCommands.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClassCommands.Commands
{
    public class CalculatePriceCommand : BaseCommand, ICommand
    {
        private readonly ICalculatePriceViewModel _viewModel;
        private readonly IPriceService _priceService;

        public CalcualtePriceCommand(ICalculatePriceViewModel viewModel, IPriceService priceService)
        {
            _viewModel = viewModel;
            _priceService = _priceService;
            _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return _viewModel.CanCalculatePrice;
        }

        public override void Execute(object parameter)
        {
            _viewModel.StatusMessage = string.Empty;
            _viewModel.ErrorMessage = string.Empty;

            try
            {
                double itemPrice = _priceService.GetPrice(_viewModel.ItemName);
                double totalPrice = itemPrice * _viewModel.Quantity;

                _viewModel.StatusMessage = $"The total price of {_viewModel.Quantity} {_viewModel.ItemName} is {totalPrice:C}.";
            }
            catch (ItemPriceNotFoundException)
            {
                _viewModel.ErrorMessage = $"Unable to find price of {_viewModel.ItemName}. ";
            }
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecuteChanged();
        }


    }
}
