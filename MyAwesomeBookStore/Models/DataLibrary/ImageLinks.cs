using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class ImageLinks
    {
        [Key, ForeignKey("VolumeInfo")]
        public int VolumeInfoId { get; set; }
        public virtual VolumeInfo VolumeInfo { get; set; }

        public Uri smallThumbnail { get; set; }
        public Uri thumbnail { get; set; }
    }
}