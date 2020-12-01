using DoTo.ViewModels;
using Xamarin.Forms;

namespace DoTo.Views
{
    public partial class MainView : ContentPage
    {
       

        public MainView(MainViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Navigation = Navigation;
            BindingContext = viewModel;
        } 
    }
}
