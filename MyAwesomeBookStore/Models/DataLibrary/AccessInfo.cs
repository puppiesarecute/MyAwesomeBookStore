using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class AccessInfo
    {
        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string country { get; set; }
        public string viewability { get; set; }
        public bool embeddable { get; set; }
        public bool publicDomain { get; set; }
        public string textToSpeechPermission { get; set; }        
        public Uri webReaderLink { get; set; }
        public string accessViewStatus { get; set; }
        public bool quoteSharingAllowed { get; set; }

        public virtual Epub epub { get; set; }
        public virtual Pdf pdf { get; set; }
        public virtual Item Item { get; set; }
    }
}