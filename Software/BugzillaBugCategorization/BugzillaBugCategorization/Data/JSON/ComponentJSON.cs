using Newtonsoft.Json;

namespace BugzillaBugCategorization.Data.JSON
{
    public class ComponentJSON
    {
        [JsonProperty("when")]
        public int When { get; set; }

        [JsonProperty("what")]
        public string Module { get; set; }

        [JsonProperty("who")]
        public int Status { get; set; }

        public int Id { get; set; }
    }
}
