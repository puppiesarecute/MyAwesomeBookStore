using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class IndustryIdentifier
    {
        [Key]
        public int IndustryIdentifierId { get; set; }

        public int VolumeInfoId { get; set; }

        public string type { get; set; }
        public string identifier { get; set; }        

        [ForeignKey("VolumeInfoId")]
        public virtual VolumeInfo VolumeInfo { get; set; }

    }
}