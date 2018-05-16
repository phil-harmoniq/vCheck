using Newtonsoft.Json;

namespace vCheck.Lib.Responses
{
    public class Dependency
    {
        [JsonProperty("@id")]
        public string ApiID { get; internal set; }

        [JsonProperty("@type")]
        public string DependencyType { get; internal set; }

        [JsonProperty("id")]
        public string PackageID { get; internal set; }

        [JsonProperty("range")]
        public string VersionRange { get; internal set; }
    }
}