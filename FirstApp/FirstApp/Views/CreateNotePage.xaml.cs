using FirstApp.Models;
using FirstApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateNotePage : ContentPage
    {
        public CreateNotePage()
        {
            InitializeComponent();
            BindingContext = new CreateNoteViewModel();
        }

        public CreateNotePage(Note note)
        {
            InitializeComponent();
            BindingContext = new CreateNoteViewModel(note);
        }
    }
}