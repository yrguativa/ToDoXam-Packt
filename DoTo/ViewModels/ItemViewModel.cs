using System;
using DoTo.Repositories;

namespace DoTo.ViewModels
{
    public class ItemViewModel : ViewModel
    {
        private readonly TodoItemRepository Repository;

        public ItemViewModel(TodoItemRepository repository) => Repository = repository;

    }
}
