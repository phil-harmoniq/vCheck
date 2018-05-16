using Newtonsoft.Json;

namespace vCheck.Lib.Responses
{
    public class DependencyGroup
    {
        [JsonProperty("@id")]
        public string ApiID { get; internal set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; internal set; }

        [JsonProperty("dependencies")]
        public Dependency[] Dependencies { get; internal set; }
    }
}