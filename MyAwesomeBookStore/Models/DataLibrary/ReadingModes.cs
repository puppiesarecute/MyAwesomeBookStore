using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class ReadingModes
    {
        public ReadingModes(JToken jToken)
        {
            this.Text = (bool)jToken["text"];
            this.Image = (bool)jToken["image"];
        }

        [Key, ForeignKey("VolumeInfo")]
        public int VolumeInfoId { get; set; }
        public virtual VolumeInfo VolumeInfo { get; set; }

        public bool Text { get; set; }
        public bool Image { get; set; }
    }
}