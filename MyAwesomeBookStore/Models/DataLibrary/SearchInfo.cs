using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class SearchInfo
    {
        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string textSnippet { get; set; }

        public virtual Item Item { get; set; }
    }
}