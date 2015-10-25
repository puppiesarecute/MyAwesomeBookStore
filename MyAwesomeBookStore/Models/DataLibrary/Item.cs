using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Item
    {
        public Item(JToken jToken)
        {
            this.Kind = (string)jToken["kind"];
            this.Id = (string)jToken["id"];
            this.Etag = (string)jToken["etag"];
            this.SelfLink = (string)jToken["selfLink"];
            this.VolumeInfo = new VolumeInfo(jToken["volumeInfo"]);
            this.SaleInfo = new SaleInfo(jToken["saleInfo"]);
            this.AccessInfo = new AccessInfo(jToken["accessInfo"]);
            this.SearchInfo = new SearchInfo(jToken["searchInfo"]);

        }

        [Key]
        public int ItemId { get; set; }

        public int RootObjectId { get; set; }
        public string Kind { get; set; }
        public string Id { get; set; }
        public string Etag { get; set; }
        [DataType(DataType.Url)]
        public string SelfLink { get; set; }

        public virtual VolumeInfo VolumeInfo { get; set; }
        public virtual SaleInfo SaleInfo { get; set; }
        public virtual AccessInfo AccessInfo { get; set; }
        public virtual SearchInfo SearchInfo { get; set; }        

        [ForeignKey("RootObjectId")]
        public virtual RootObject RootObject { get; set; }
    }
}