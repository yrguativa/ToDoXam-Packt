using System;
using System.Windows.Input;
using DoTo.Models;
using Xamarin.Forms;

namespace DoTo.ViewModels
{
    public class TodoItemViewModel : ViewModel
    {
        public TodoItemViewModel(TodoItem item) => Item = item;

        public event EventHandler ItemStatusChanged;
        public TodoItem Item { get; private set; }

        public string StatusText => Item.Completed ? "Reactivate" : "Completed";

        public ICommand ToggleCompleted => new Command((arg) =>
        {
             Item.Completed = !Item.Completed;
             ItemStatusChanged?.Invoke(this, new EventArgs());
        });
    }
}
