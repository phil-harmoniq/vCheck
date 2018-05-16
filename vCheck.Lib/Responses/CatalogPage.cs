using Newtonsoft.Json;

namespace vCheck.Lib.Responses
{
    public class CatalogPage
    {
        [JsonProperty("@id")]
        public string ApiID { get; internal set; }
        
        [JsonProperty("@type")]
        public string ApiEndpointType { get; internal set; }

        [JsonProperty("commitId")]
        public string CommitID { get; internal set; }

        [JsonProperty("commitTimeStamp")]
        public string CommitTimeStamp { get; internal set; }

        [JsonProperty("count")]
        public int Count { get; internal set; }
        
        [JsonProperty("lower")]
        public string LowestVersion { get; internal set; }
        
        [JsonProperty("upper")]
        public string UpperVersion { get; internal set; }
        
        [JsonProperty("items")]
        public Package[] Items { get; internal set; }
    }
}