using System;
using DoTo.Models;

namespace DoTo.ViewModels
{
    public class TodoItemViewModel : ViewModel
    {
        public TodoItemViewModel(TodoItem item) => Item = item;

        public event EventHandler ItemStatusChanged;
        public TodoItem Item { get; private set; }

        public string StatusText => Item.Completed ? "Reactivate" : "Completed";
    }
}
