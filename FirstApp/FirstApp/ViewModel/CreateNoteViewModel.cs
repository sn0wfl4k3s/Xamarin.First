using FirstApp.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class CreateNoteViewModel : BaseViewModel
    {
        public Note NewNote { get; set; } = new();
        public ICommand SaveNewNoteCommand  => new Command(SaveNewNoteCmd);


        private async void SaveNewNoteCmd()
        {
            _dataStore.AddEntity(NewNote);

            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
