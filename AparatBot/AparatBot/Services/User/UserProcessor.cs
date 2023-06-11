using System.Net.Http;
using System.Threading.Tasks;
using AparatBot.Services.Common;
using AparatBot.DTOs;
using Newtonsoft.Json;

namespace AparatBot.Services.User
{
    internal class UserProcessor : IUserProcessor
    {
        private HttpClient _client;
        public UserProcessor(HttpClient client)
        {
            _client = client;
        }

        public async Task<ResultAparatModel<Profile>> GetProfile(string username)
        {
            var resp = await _client.GetAsync($"https://www.aparat.com/etc/api/profile/username/{username}");
            ResultAparatModel<Profile> model = new ResultAparatModel<Profile>();
            if (resp.IsSuccessStatusCode)
            {
                var content = await resp.Content.ReadAsStringAsync();

                RootJson Rjson = new RootJson();
                Rjson = JsonConvert.DeserializeObject<RootJson>(content);

                if (Rjson != null)
                {
                    model.Success = true;
                    model.Error = "No Error";
                    model.Value = Rjson.profile;
                }
                else
                {
                    model.Success = false;
                    model.Error = "your username is not valid";
                }
            }

            else
            {
                model.Success = false;
                model.Error = "Error 500 . please try again";
            }

            return model;
        }


    }
}
