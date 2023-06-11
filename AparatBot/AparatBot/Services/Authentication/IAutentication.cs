using AparatBot.DTOs;
using System.Threading.Tasks;

namespace AparatBot.Services.Authentication
{
    public interface IAutentication
    {
         Task<ResultAparatModel<login>> LoginAsync(string username, string password);
    }
}
