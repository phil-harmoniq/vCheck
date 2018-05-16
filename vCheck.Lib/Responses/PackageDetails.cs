using Newtonsoft.Json;

namespace vCheck.Lib.Responses
{
    public class PackageDetails
    {
        [JsonProperty("@id")]
        public string ApiID { get; internal set; }

        [JsonProperty("id")]
        public string PackageID { get; internal set; }

        [JsonProperty("authors")]
        public string Authors { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("licenseUrl")]
        public string LicenseUrl { get; internal set; }

        [JsonProperty("tags")]
        public string[] Tags { get; internal set; }

        [JsonProperty("version")]
        public string Version { get; internal set; }

        [JsonProperty("projectUrl")]
        public string ProjectUrl { get; internal set; }

        [JsonProperty("listed")]
        public bool Listed { get; internal set; }

        [JsonProperty("dependencyGroups")]
        public DependencyGroup[] DependencyGroups { get; internal set; }
    }
}