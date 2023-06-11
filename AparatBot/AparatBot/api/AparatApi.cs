using AparatBot.DTOs;
using AparatBot.Services.Authentication;
using AparatBot.Services.Common;
using AparatBot.Services.Media;
using AparatBot.Services.User;
using Newtonsoft.Json;
using System.Net.Http;


namespace AparatBot.api
{
    public class ApiAparat : IAparatApi
    {
        private readonly HttpClient _client;
        public ApiAparat()
        {
            _client = new HttpClient();
        }
        public ApiAparat(HttpClient client)
        {
            _client = client;
        }

        public IAutentication SignIn
        {
            get
            {
                if (_SignIn == null) _SignIn = new Autentication(_client);
                return _SignIn;
            }
        }
        public IUserProcessor UserProcessor
        {
            get
            {
                if (_UserProcessor == null) _UserProcessor = new UserProcessor(_client);
                return _UserProcessor;
            }
        }
        public bool isAutentication
        { 
            get 
            {
               return _SignIn.isAutentication;
            }
        }
        public IMediaProcessor MediaProcessor 
        {
            get 
            {
                if (_MediaProcessor == null) _MediaProcessor = new MediaProcessor(_client);
                return _MediaProcessor;
            } 
        }




        private UserProcessor _UserProcessor { get; set; }
        private Autentication _SignIn { get; set; }
        private MediaProcessor _MediaProcessor { get; set; }


    }

}
