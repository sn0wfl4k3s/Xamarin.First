using FirstApp.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class FormNoteViewModel : BaseViewModel
    {
        public bool IsEdit { get; private set; }
        public Note NewNote { get; set; }
        public ICommand SaveNewNoteCommand => new Command(SaveNewNoteCmd);

        public FormNoteViewModel()
        {
            NewNote = new();
            IsEdit = false;
        }

        public FormNoteViewModel(Note newNote)
        {
            NewNote = newNote;
            IsEdit = true;
        }

        private async void SaveNewNoteCmd()
        {
            if (IsEdit)
            {
                _dataStore.AddEntity(NewNote);
            }
            else
            {
                _dataStore.AddEntity(NewNote);
            }

            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
