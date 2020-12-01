using DoTo.ViewModels;
using Xamarin.Forms;

namespace DoTo.Views
{
    public partial class ItemView : ContentPage
    {
        public ItemView(ItemViewModel viewmodel)
        {
            InitializeComponent();
            viewmodel.Navigation = Navigation;
            BindingContext = viewmodel;
        }
    }
}
