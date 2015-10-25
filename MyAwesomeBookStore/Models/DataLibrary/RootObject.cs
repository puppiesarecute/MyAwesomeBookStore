using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class RootObject
    {
        public RootObject(string json)
        {
            JObject jObject = JObject.Parse(json);
            this.Kind = (string)jObject["kind"];
            this.TotalItems = (int)jObject["titalItems"];
            JToken[] itemsList = jObject["items"].ToArray();

            Items = new List<Item>();
            for (int i = 0; i < itemsList.Length; i++)
            {
                Items.Add(new Item(itemsList[i]));
            }

        }
        public int RootObjectId { get; set; }
        public string Kind { get; set; }
        public int TotalItems { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}