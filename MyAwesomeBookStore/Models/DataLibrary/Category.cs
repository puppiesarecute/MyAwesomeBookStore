using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Category
    {
        public Category(JToken jToken)
        {
            this.CategoryName = (string)jToken;
        }

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int VolumeInfoId { get; set; }

        [ForeignKey("VolumeInfoId")]
        public virtual VolumeInfo VolumeInfo { get; set; }
    }
}