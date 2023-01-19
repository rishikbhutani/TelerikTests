using Newtonsoft.Json;

namespace CMS.Models.Tickets
{
    public class PmChecklistItem 
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fieldDefault")]
        public int FieldDefault { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonIgnore]
        public bool BoldStyle { get; set; } = false;
    }
}
