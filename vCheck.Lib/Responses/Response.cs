using Newtonsoft.Json;

namespace vCheck.Lib.Responses
{
    public class Response<TItem> where TItem : class
    {
        [JsonProperty("@id")]
        public string ApiID { get; internal set; }

        [JsonProperty("commitId")]
        public string CommitID { get; internal set; }

        [JsonProperty("commitTimeStamp")]
        public string CommitTimeStamp { get; internal set; }

        [JsonProperty("count")]
        public int Count { get; internal set; }
        
        [JsonProperty("items")]
        public TItem[] Items { get; internal set; }
    }
}