using FirstApp.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class CreateNoteViewModel : BaseViewModel
    {
        public Note NewNote { get; set; }
        public ICommand SaveNewNoteCommand { get; set; }

        public CreateNoteViewModel ()
        {
            NewNote = new Note
            {
                Title = string.Empty,
                Description = string.Empty
            };

            SaveNewNoteCommand = new Command(SaveNewNoteCmd);
        }

        async void SaveNewNoteCmd ()
        {
            _dataStore.AddEntity(NewNote);
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
