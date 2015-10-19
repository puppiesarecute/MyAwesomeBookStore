using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class SaleInfo
    {
        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string country { get; set; }
        public string saleability { get; set; }
        public bool isEbook { get; set; }

        public virtual Item Item { get; set; }
    }
}