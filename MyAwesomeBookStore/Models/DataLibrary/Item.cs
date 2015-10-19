using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        public int RootObjectId { get; set; }
        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }

        public virtual VolumeInfo volumeInfo { get; set; }
        public virtual SaleInfo saleInfo { get; set; }
        public virtual AccessInfo accessInfo { get; set; }
        public virtual SearchInfo searchInfo { get; set; }        

        [ForeignKey("RootObjectId")]
        public virtual RootObject RootObject { get; set; }
    }
}