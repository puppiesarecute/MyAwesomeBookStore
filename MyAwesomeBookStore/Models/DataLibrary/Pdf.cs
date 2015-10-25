using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Pdf
    {
        public Pdf(JToken jToken)
        {
            this.IsAvailable = (bool)jToken["isAvailable"];
        }

        [Key, ForeignKey("AccessInfo")]
        public int AccessInfoId { get; set; }

        public bool IsAvailable { get; set; }

        public virtual AccessInfo AccessInfo { get; set; }        
    }
}