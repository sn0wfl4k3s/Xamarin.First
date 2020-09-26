using FirstApp.Contracts;
using FirstApp.Models;

using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public abstract class BaseViewModel
    {
        protected readonly IDataStore<Note> _dataStore = DependencyService.Get<IDataStore<Note>>();
    }
}
