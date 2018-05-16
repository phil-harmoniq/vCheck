using Newtonsoft.Json;
using vCheck.Lib.Responses;

namespace vCheck.Lib
{
    public static class Client
    {
        private readonly static HttpClient _client = new HttpClient();

        public static CatalogPage GetPackageInfoByID(string id)
        {
            var url = ApiUrlBuilder.PackageByID(id);
            var response = _client.Get(url);
            var json = JsonConvert.DeserializeObject<Response<CatalogPage>>(response);
            return json?.Items?[0];
        }
    }
}