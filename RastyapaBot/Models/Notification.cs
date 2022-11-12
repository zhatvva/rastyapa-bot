using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace RastyapaBot.Models
{
    public class Notification
    {
        [JsonPropertyName("type")]
        [Required(AllowEmptyStrings = false)]
        public string Type { get; set; }

        [JsonPropertyName("object")]
        [Required]
        public JsonObject Object { get; set; }

        [Required]
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }
    }
}
