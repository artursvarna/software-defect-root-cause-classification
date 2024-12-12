using Newtonsoft.Json;

namespace BugzillaBugCategorization.Data.JSON
{
    public class ReportJSON
    {
        [JsonProperty("opening")]
        public string Opening { get; set; }

        [JsonProperty("reporter")]
        public string Reporter { get; set; }

        [JsonProperty("current_status")]
        public string Status { get; set; }

        [JsonProperty("current_resolution")]
        public string Resolution { get; set; }
    }
}
