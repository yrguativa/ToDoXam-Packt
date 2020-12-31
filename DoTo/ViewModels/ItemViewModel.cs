using System;
using System.Windows.Input;
using DoTo.Models;
using DoTo.Repositories;
using Xamarin.Forms;

namespace DoTo.ViewModels
{
    public class ItemViewModel : ViewModel
    {
        private readonly TodoItemRepository repository;

        public TodoItem Item { get; set; }

        public ItemViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
            Item = new TodoItem {
                Due = DateTime.Now.AddDays(1)
            };
        }

        public ICommand Save => new Command(async () =>
        {
            await repository.AddOrUpdate(Item);
            await Navigation.PopAsync();
        });      

    }
}
