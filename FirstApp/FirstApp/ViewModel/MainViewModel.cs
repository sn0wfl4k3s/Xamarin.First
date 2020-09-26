using FirstApp.Models;
using FirstApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public ICommand OpenCreateNotePageCommand => new Command(OpenCreateNotePageCmd);
        public ICommand DeleteNoteCommand => new Command<Note>(DeleteNoteCmd);
        public ICommand EditNoteCommand => new Command<Note>(EditNoteCmd);

        public MainViewModel()
        {
            Syncronize();
        }

        void DeleteNoteCmd(Note note)
        {
            _dataStore.DeleteEntity(note);

            Syncronize();
        }


        async void OpenCreateNotePageCmd()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FormNotePage(), true);
        }

        async void EditNoteCmd(Note note)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FormNotePage(note), true);
        }

        void Syncronize()
        {
            Notes.Clear();

            foreach (var item in new ObservableCollection<Note>(_dataStore.GetAllEntities()))
            {
                Notes.Add(item);
            }
        }
    }
}
