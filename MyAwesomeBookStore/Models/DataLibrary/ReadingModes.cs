using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class ReadingModes
    {
        [Key, ForeignKey("VolumeInfo")]
        public int VolumeInfoId { get; set; }
        public virtual VolumeInfo VolumeInfo { get; set; }

        public bool text { get; set; }
        public bool image { get; set; }
    }
}