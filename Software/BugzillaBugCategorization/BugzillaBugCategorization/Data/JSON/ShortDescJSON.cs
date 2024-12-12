using Newtonsoft.Json;
namespace BugzillaBugCategorization.Data.JSON
{
    public class ShortDescJSON
    {
        [JsonProperty("when")]
        public int When { get; set; }

        [JsonProperty("what")]
        public string Description { get; set; }

        [JsonProperty("who")]
        public int Who { get; set; }
    }
}
