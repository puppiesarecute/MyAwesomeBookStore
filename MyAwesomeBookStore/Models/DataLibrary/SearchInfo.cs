using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class SearchInfo
    {
        public SearchInfo(JToken jToken)
        {
            this.TextSnippet = (string)jToken["textSnippet"];
        }

        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string TextSnippet { get; set; }

        public virtual Item Item { get; set; }
    }
}