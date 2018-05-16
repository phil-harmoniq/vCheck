using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace vCheck.Lib
{
    internal class HttpClient : WebClient
    {
        public string Get(string url, Dictionary<string, string> headers = null)
        {
            using (var wc = new WebClient())
            {
                AddHeaders(wc, headers);
                try
                {
                    return wc.DownloadString(url);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"HttpClient error: {e.Message}");
                    return null;
                }
            }
        }

        private static void AddHeaders(WebClient webClient, Dictionary<string, string> headers)
        {
            if (headers == null || headers.Keys.Count == 0)
                return;

            foreach (var key in headers.Keys)
            {
                webClient.Headers.Add(key, headers[key]);
            }
        }
    }
}
