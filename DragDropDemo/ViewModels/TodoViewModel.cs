
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDropDemo.ViewModels
{
    public class TodoViewModel : ViewModelBase
    {
        public TodoItemListingViewModel InProgressTodoItemListingViewModel { get; }
        public TodoItemListingViewModel CompletedTodoItemListingViewModel { get; }

        public TodoViewModel(TodoItemListingViewModel inProgressTodoItemListingViewModel, TodoItemListingViewModel 
            completedTodoItem
            )

    }
}
