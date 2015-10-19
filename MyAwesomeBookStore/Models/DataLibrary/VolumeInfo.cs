using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class VolumeInfo
    {
        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string title { get; set; }
        public string subtitle { get; set; }        
        public string publisher { get; set; }
        public DateTime publishedDate { get; set; }
        public string description { get; set; }      
        public int pageCount { get; set; }
        public string printType { get; set; }
        public double averageRating { get; set; }
        public int ratingsCount { get; set; }
        public string maturityRating { get; set; }
        public bool allowAnonLogging { get; set; }
        public string contentVersion { get; set; }
        public string language { get; set; }
        public string previewLink { get; set; }
        public string infoLink { get; set; }
        public string canonicalVolumeLink { get; set; }

        public virtual ImageLinks imageLinks { get; set; }
        public virtual ReadingModes readingModes { get; set; }
        public virtual Item Item { get; set; }
        public virtual ICollection<IndustryIdentifier> industryIdentifiers { get; set; }
        public virtual ICollection<Author> authors { get; set; }
        public virtual ICollection<Category> categories { get; set; }
    }
}