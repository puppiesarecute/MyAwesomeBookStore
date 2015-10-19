using System.Collections.Generic;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class RootObject
    {
        public int RootObjectId { get; set; }
        public string kind { get; set; }
        public int totalItems { get; set; }

        public virtual ICollection<Item> items { get; set; }
    }
}