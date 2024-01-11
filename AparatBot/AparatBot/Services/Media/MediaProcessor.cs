using System.Net.Http;
using System.Threading.Tasks;
using AparatBot.Services.Common;
using AparatBot.DTOs;
using Newtonsoft.Json;
using AparatBot.Services.Media;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Drawing;

namespace AparatBot.Services.Media
{
    internal class MediaProcessor : IMediaProcessor
    {
        private HttpClient _client;
        private readonly SendRequestConvertJson _sendRequest;
        public MediaProcessor(HttpClient client)
        {
            _client = client;
            _sendRequest = new SendRequestConvertJson(_client);
        }

        public async Task<ResultAparatModel<List<DTOs.Media>>> GetMediaByUserName(string username, int count = 0)
        {
            string url = $"https://www.aparat.com/etc/api/videoByUser/username/{username}/perpage/{count}";
            var rootjson = await _sendRequest.Invoke(url);
            var model = new ResultAparatModel<List<DTOs.Media>>();


            if (rootjson.videobyuser != null)
            {
                model.Success = true;
                model.Error = "No Error";
                model.Value = rootjson.videobyuser;
            }
            else
            {
                model.Success = false;
                model.Error = "Your username is not valid";
            }
            return model;
        }
        public async Task<ResultAparatModel<MediaExact>> GetMediaByVideohash(string videohash)
        {
            var r = await _sendRequest.Invoke($"https://www.aparat.com/etc/api/video/videohash/{videohash}");
            var model = new ResultAparatModel<MediaExact>();
            if (r.video != null)
              {
                model.Success = true;
                model.Error = "No Error";
                model.Value = r.video;
            }
            else
            {
                model.Success = false;
                model.Error = "You videohash is not valid";
            }
            return model;
        }

        public async Task<ResultAparatModel<List<VideoByTag>>> GetMediaByTags(string tag)
        {
            string url = $"https://www.aparat.com/etc/api/videobytag/text/{tag}";
            var rootjson = await _sendRequest.Invoke(url);
            var model = new ResultAparatModel<List<DTOs.VideoByTag>>();


            if (rootjson.videobytag != null)
            {
                model.Success = true;
                model.Error = "No Error";
                model.Value = rootjson.videobytag;
            }
            else
            {
                model.Success = false;
                model.Error = "Your username is not valid";
            }
            return model;
        }
    }
}
