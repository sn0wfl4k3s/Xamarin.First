using FirstApp.Models;
using FirstApp.Services;
using FirstApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class MainPageViewModel
    {
        private readonly IDataStore<Note> _dataStore;

        public ObservableCollection<Note> Notes { get; set; }
        public ICommand OpenCreateNotePageCommand { get; private set; }

        public MainPageViewModel()
        {
            _dataStore = DependencyService.Get<IDataStore<Note>>();

            Notes = _dataStore.GetAllEntities();

            OpenCreateNotePageCommand = new Command(OpenCreateNotePageCmd);
        }

        private async void OpenCreateNotePageCmd()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CreateNotePage());
        }
    }
}
