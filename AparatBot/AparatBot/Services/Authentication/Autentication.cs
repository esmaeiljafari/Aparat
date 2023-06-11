using AparatBot.DTOs;
using AparatBot.Services.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace AparatBot.Services.Authentication
{
    internal class Autentication: IAutentication
    {
        private HttpClient _client;
        private readonly SendRequestConvertJson _requestConvertJson;


        public Autentication(HttpClient client)
        {
            _client = client;
            _requestConvertJson = new SendRequestConvertJson(_client);
        }

        public async Task<ResultAparatModel<login>> LoginAsync(string username,string password)
        {
            HashPassword hash = new HashPassword();
            string md = hash.CreateMD5(password);
            string sha1 = hash.CreateSHA5(md);

            string url = $"https://www.aparat.com/etc/api/login/luser/{username}/lpass/{sha1}";
           var rootjson=await _requestConvertJson.Invoke(url);
           var model = new ResultAparatModel<login>();

            if (rootjson.login.username!=null)
            {
                model.Success = true;
                model.Error = "No Error";
                model.Value = rootjson.login;
                isAutentication = true;
            }
            else
            {
                model.Success = false;
                model.Error = "your username is not valid";
                isAutentication = false;
            }
            return model;        
        }


        internal bool isAutentication { get; set; } = false;
        internal string token { get; set; }

    }

    class HashPassword
    {
        public string CreateMD5(string input)
        {
            string sb = string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input)).Select(s => s.ToString("x2")));

            return sb.ToString();
        }
        public string CreateSHA5(string input)
        {
            string sb = string.Join("", SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(input)).Select(s => s.ToString("x2")));

            return sb.ToString();
        }

    }

}
