using FirstApp.Models;
using FirstApp.Views;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FirstApp.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Note> Notes { get; set; } = new();
        public bool IsEmptyList { get; set; }

        public ICommand CreateNoteCommand => new Command(CreateNotePageCmd);
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


        async void CreateNotePageCmd()
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

            _dataStore
                .GetAllEntities()
                .ForEach(n => Notes.Add(n));

            IsEmptyList = Notes.Count is 0;
        }
    }
}
