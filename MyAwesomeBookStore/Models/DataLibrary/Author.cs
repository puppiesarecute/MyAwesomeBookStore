using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public int VolumeInfoId { get; set; }

        [ForeignKey("VolumeInfoId")]
        public virtual VolumeInfo VolumeInfo { get; set; }
    }
}