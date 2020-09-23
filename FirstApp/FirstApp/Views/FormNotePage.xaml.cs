using FirstApp.Models;
using FirstApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormNotePage : ContentPage
    {
        public FormNotePage()
        {
            InitializeComponent();
            BindingContext = new FormNoteViewModel();
        }

        public FormNotePage(Note note)
        {
            InitializeComponent();
            BindingContext = new FormNoteViewModel(note);
        }
    }
}