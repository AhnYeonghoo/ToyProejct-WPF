using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomObservableCollections.Commands
{
    public class GiveOrderCommand : CommandBase
    {
        private readonly DriveThruViewModel _viewModel;

        public GiveOrderCommand(DriveThruViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            _viewModel.GiveOrderToCustomer();
        }
    }
}
