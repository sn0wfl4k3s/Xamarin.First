using FirstApp.Models;
using System.Collections.ObjectModel;

namespace FirstApp.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Note> Notes { get; } = new ObservableCollection<Note>
        {
            new Note { Title = "titulo 1", Description = "Description número um." },
            new Note { Title = "titulo 2", Description = "Description número dois." },
        };
    }
}
