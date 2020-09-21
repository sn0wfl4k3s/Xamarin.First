using FirstApp.Models;
using FirstApp.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public class MainPageViewModel
    {
        private readonly IDataStore<Note> _dataStore;

        public ObservableCollection<Note> Notes { get; set; }

        public MainPageViewModel()
        {
            _dataStore = DependencyService.Get<IDataStore<Note>>();
            Notes = _dataStore.GetAllEntities();
        }
    }
}
