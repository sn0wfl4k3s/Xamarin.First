using FirstApp.Models;
using PropertyChanged;
using System.Windows.Input;

using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class FormNoteViewModel : BaseViewModel
    {
        public bool IsEdit { get; private set; }
        public Note Note { get; private set; }

        public ICommand SaveNoteCommand => new Command(SaveNoteCmd);
        public ICommand CancelCommand => new Command(BackToMainPage);

        public FormNoteViewModel()
        {
            Note = new();
            IsEdit = false;
        }

        public FormNoteViewModel(Note note)
        {
            Note = note;
            IsEdit = true;
        }

        void SaveNoteCmd()
        {
            if (IsEdit)
            {
                _dataStore.UpdateEntity(Note.Id, Note);
            }
            else
            {
                _dataStore.AddEntity(Note);
            }

            BackToMainPage();
        }

        async void BackToMainPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync(true);
        }
    }
}
