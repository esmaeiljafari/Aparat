using AparatBot.Services.Authentication;
using AparatBot.Services.Media;
using AparatBot.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AparatBot.api
{
    public interface IAparatApi
    {
        IAutentication SignIn { get; }
        IUserProcessor UserProcessor { get; }
        IMediaProcessor MediaProcessor { get; }

         bool isAutentication { get; }



    }

}
