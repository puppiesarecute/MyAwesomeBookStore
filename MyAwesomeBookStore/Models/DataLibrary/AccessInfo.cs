using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class AccessInfo
    {
        public AccessInfo(JToken jToken)
        {
            this.Country = (string)jToken["country"];
            this.Viewability = (string)jToken["viewability"];
            this.Embeddable = (bool)jToken["embeddable"];
            this.PublicDomain = (bool)jToken["publicDomain"];
            this.TextToSpeechPermission = (string)jToken["textToSpeechPermission"];
            this.WebReaderLink = (string)jToken["webReaderLink"];
            this.AccessViewStatus = (string)jToken["accessViewStatus"];
            this.QuoteSharingAllowed = (bool)jToken["quoteSharingAllowed"];
            this.Epub = new Epub(jToken["epub"]);
            this.Pdf = new Pdf(jToken["pdf"]);
        }

        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string Country { get; set; }
        public string Viewability { get; set; }
        public bool Embeddable { get; set; }
        public bool PublicDomain { get; set; }
        public string TextToSpeechPermission { get; set; }
        [DataType(DataType.Url)]
        public string WebReaderLink { get; set; }
        public string AccessViewStatus { get; set; }
        public bool QuoteSharingAllowed { get; set; }

        public virtual Epub Epub { get; set; }
        public virtual Pdf Pdf { get; set; }
        public virtual Item Item { get; set; }
    }
}