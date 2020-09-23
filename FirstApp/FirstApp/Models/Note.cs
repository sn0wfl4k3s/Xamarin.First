using FirstApp.Services;

namespace FirstApp.Models
{
    public class Note : NotifyPropertiesService
    {
        public int Id { get; set; }

        private string _title = string.Empty;
        public string Title 
        {
            get { return _title; }
            set
            {
                _title = value;
                NotifyPropertyChanged();
            }
        }

        private string _description = string.Empty;
        public string Description 
        { 
            get { return _description; }
            set
            {
                _description = value;
                NotifyPropertyChanged();
            }
        }
    }
}
