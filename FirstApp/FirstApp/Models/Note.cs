using PropertyChanged;

namespace FirstApp.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
