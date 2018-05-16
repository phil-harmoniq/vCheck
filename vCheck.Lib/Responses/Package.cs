using Newtonsoft.Json;

namespace vCheck.Lib.Responses
{
    public class Package
    {
        [JsonProperty("commitId")]
        public string CommitID { get; internal set; }

        [JsonProperty("commitTimeStamp")]
        public string CommitTimeStamp { get; internal set; }
        
        [JsonProperty("catalogEntry")]
        public PackageDetails CatalogEntry { get; internal set; }
    }
}