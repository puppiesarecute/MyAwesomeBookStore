using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class ImageLinks
    {
        public ImageLinks(JToken jToken)
        {
            this.SmallThumbnail = (string)jToken["smallThumbnail"];
            this.Thumbnail = (string)jToken["thumbnail"];
        }

        [Key, ForeignKey("VolumeInfo")]
        public int VolumeInfoId { get; set; }
        public virtual VolumeInfo VolumeInfo { get; set; }

        [DataType(DataType.Url)]
        public string SmallThumbnail { get; set; }
        [DataType(DataType.Url)]
        public string Thumbnail { get; set; }
    }
}