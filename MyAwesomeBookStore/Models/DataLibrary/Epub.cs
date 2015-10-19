using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Epub
    {
        [Key, ForeignKey("AccessInfo")]
        public int AccessInfoId { get; set; }

        public bool isAvailable { get; set; }

        public virtual AccessInfo AccessInfo { get; set; }
        
    }
}