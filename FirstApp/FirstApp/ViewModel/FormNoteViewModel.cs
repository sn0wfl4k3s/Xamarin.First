using FirstApp.Models;
using System.Windows.Input;

using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class FormNoteViewModel : BaseViewModel
    {
        public bool IsEdit { get; private set; }
        public Note NewNote { get; set; }
        public ICommand SaveNoteCommand => new Command(SaveNoteCmd);

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

        async void SaveNoteCmd()
        {
            if (IsEdit)
            {
                _dataStore.UpdateEntity(NewNote.Id, NewNote);
            }
            else
            {
                _dataStore.AddEntity(NewNote);
            }

            await Application.Current.MainPage.Navigation.PopToRootAsync(true);
        }
    }
}
