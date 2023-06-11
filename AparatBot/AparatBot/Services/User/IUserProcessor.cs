using AparatBot.DTOs;
using System.Threading.Tasks;

namespace AparatBot.Services.User
{
    public interface IUserProcessor
    {
         Task<ResultAparatModel<Profile>> GetProfile(string username);
    }
}
