using FirstApp.Models;
using FirstApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Note> Notes { get; set; }

        public ICommand OpenCreateNotePageCommand => new Command(OpenCreateNotePageCmd);
        public ICommand DeleteNoteCommand => new Command<Note>(DeleteNoteCmd);


        public MainViewModel()
        {
            Notes = _dataStore.GetAllEntities();
        }

        private void DeleteNoteCmd(Note note)
        {
            _dataStore.DeleteEntity(note);
        }

        private async void OpenCreateNotePageCmd()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CreateNotePage());
        }
    }
}
