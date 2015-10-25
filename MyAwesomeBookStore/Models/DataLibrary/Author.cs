using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class Author
    {
        public Author(JToken jToken)
        {
            this.AuthorName = (string)jToken;
        }

        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public int VolumeInfoId { get; set; }

        [ForeignKey("VolumeInfoId")]
        public virtual VolumeInfo VolumeInfo { get; set; }
    }
}