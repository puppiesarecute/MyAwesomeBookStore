using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace MyAwesomeBookStore.Models.DataLibrary
{
    public class IndustryIdentifier
    {
        public IndustryIdentifier(JToken jToken)
        {
            this.Type = (string)jToken["type"];
            this.Identifier = (string)jToken["identifier"];
        }

        [Key]
        public int IndustryIdentifierId { get; set; }

        public int VolumeInfoId { get; set; }

        public string Type { get; set; }
        public string Identifier { get; set; }        

        [ForeignKey("VolumeInfoId")]
        public virtual VolumeInfo VolumeInfo { get; set; }

    }
}