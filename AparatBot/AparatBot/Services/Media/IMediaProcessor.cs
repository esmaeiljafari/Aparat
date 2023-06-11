using AparatBot.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AparatBot.Services.Media
{
    public interface IMediaProcessor
    {
        Task<ResultAparatModel<List<DTOs.Media>>> GetMediaByUserName(string username, int count = 0);
        Task<ResultAparatModel<MediaExact>> GetMediaByVideohash(string videohash);

    }
}
