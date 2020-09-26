using PropertyChanged;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
