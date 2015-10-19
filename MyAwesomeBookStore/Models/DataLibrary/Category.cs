using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int VolumeInfoId { get; set; }

        [ForeignKey("VolumeInfoId")]
        public virtual VolumeInfo VolumeInfo { get; set; }
    }
}