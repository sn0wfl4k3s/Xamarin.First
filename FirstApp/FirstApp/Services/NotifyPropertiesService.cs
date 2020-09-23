using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FirstApp.Services
{
    public abstract class NotifyPropertiesService : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
