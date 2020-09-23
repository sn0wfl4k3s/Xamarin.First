using FirstApp.Models;
using FirstApp.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FirstApp.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected readonly IDataStore<Note> _dataStore = DependencyService.Get<IDataStore<Note>>();

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
