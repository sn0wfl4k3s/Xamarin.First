using FirstApp.Models;
using FirstApp.Services;
using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public abstract class BaseViewModel
    {
        protected readonly IDataStore<Note> _dataStore = DependencyService.Get<IDataStore<Note>>();
    }
}
