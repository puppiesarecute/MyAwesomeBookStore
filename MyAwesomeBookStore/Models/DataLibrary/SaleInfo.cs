using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class SaleInfo
    {
        public SaleInfo(JToken jToken)
        {
            this.Country = (string)jToken["country"];
            this.Saleability = (string)jToken["saleability"];
            this.IsEbook = (bool)jToken["isEbook"];
        }

        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string Country { get; set; }
        public string Saleability { get; set; }
        public bool IsEbook { get; set; }

        public virtual Item Item { get; set; }
    }
}