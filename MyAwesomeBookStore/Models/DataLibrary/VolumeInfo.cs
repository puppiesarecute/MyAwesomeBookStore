using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class VolumeInfo
    {
        public VolumeInfo(JToken jToken)
        {
            this.Title = (string)jToken["title"];
            this.Subtitle = (string)jToken["subtitle"];
            this.Publisher = (string)jToken["publisher"];
            this.PublishedDate = (string)jToken["publishedDate"];
            this.Description = (string)jToken["description"];
            this.PageCount = (int)jToken["pageCount"];
            this.PrintType = (string)jToken["printType"];
            this.AverageRating = (double)jToken["averageRating"];
            this.RatingsCount = (int)jToken["ratingsCount"];
            this.MaturityRating = (string)jToken["maturityRating"];
            this.AllowAnonLogging = (bool)jToken["allowAnonLogging"];
            this.ContentVersion = (string)jToken["contentVersion"];
            this.Language = (string)jToken["language"];
            this.PreviewLink = (string)jToken["previewLink"];
            this.InfoLink = (string)jToken["infoLink"];
            this.CanonicalVolumeLink = (string)jToken["canonicalVolumeLink"];

            this.ImageLinks = new ImageLinks(jToken["imageLinks"]);
            this.ReadingModes = new ReadingModes(jToken["ReadingModes"]);

            JToken[] industryIdentifiers = jToken["industryIdentifiers"].ToArray();
            this.IndustryIdentifiers = new List<IndustryIdentifier>();
            for (int i = 0; i < industryIdentifiers.Length; i++)
            {
                this.IndustryIdentifiers.Add(new IndustryIdentifier(industryIdentifiers[i]));
            }

            JToken[] authors = jToken["authors"].ToArray();
            this.Authors = new List<Author>();
            for (int i = 0; i < authors.Length; i++)
            {
                this.Authors.Add(new Author(authors[i]));
            }

            JToken[] categories = jToken["categories"].ToArray();
            this.Categories = new List<Category>();
            for (int i = 0; i < categories.Length; i++)
            {
                this.Categories.Add(new Category(categories[i]));
            }
        }

        [Key, ForeignKey("Item")]
        public int ItemId { get; set; }

        public string Title { get; set; }
        public string Subtitle { get; set; }        
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }      
        public int PageCount { get; set; }
        public string PrintType { get; set; }
        public double AverageRating { get; set; }
        public int RatingsCount { get; set; }
        public string MaturityRating { get; set; }
        public bool AllowAnonLogging { get; set; }
        public string ContentVersion { get; set; }
        public string Language { get; set; }
        [DataType(DataType.Url)]
        public string PreviewLink { get; set; }
        [DataType(DataType.Url)]
        public string InfoLink { get; set; }
        [DataType(DataType.Url)]
        public string CanonicalVolumeLink { get; set; }

        public virtual ImageLinks ImageLinks { get; set; }
        public virtual ReadingModes ReadingModes { get; set; }
        public virtual Item Item { get; set; }
        public virtual ICollection<IndustryIdentifier> IndustryIdentifiers { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}