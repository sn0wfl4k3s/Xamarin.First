using FirstApp.Models;
using FirstApp.Services;
using FirstApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand OpenCreateNotePageCommand { get; private set; }
        
        public ObservableCollection<Note> Notes { get; set; }

        public MainViewModel()
        {
            Notes = _dataStore.GetAllEntities();

            OpenCreateNotePageCommand = new Command(OpenCreateNotePageCmd);
        }

        
        private async void OpenCreateNotePageCmd()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CreateNotePage());
        }
    }
}
