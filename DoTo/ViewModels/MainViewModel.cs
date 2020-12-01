using System;
using System.Threading.Tasks;
using DoTo.Repositories;

namespace DoTo.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly TodoItemRepository repository;

        public MainViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
            Task.Run(() => LoadData());
        }

        private void LoadData()
        {
        }
    }
}
