using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AparatBot.Services.Common
{
    internal class SendRequestConvertJson
    {
        private HttpClient _client;
        public SendRequestConvertJson(HttpClient client)
        {
            _client = client;
        }
        public async Task<RootJson> Invoke(string url)
        {
            var resp = await _client.GetAsync(url);
            var content = await resp.Content.ReadAsStringAsync();

            RootJson Rjson = JsonConvert.DeserializeObject<RootJson>(content);
            return Rjson;

        }
    }
}
