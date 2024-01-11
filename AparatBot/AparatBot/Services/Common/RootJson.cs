using AparatBot.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AparatBot.Services.Common
{
    internal class RootJson
    {
        public Profile profile { get; set; }
        public login login { get; set; }
        public List<DTOs.Media> videobyuser { get; set; }
        public DTOs.MediaExact video { get; set; }

        public List<VideoByTag> videobytag { get; set; }
    }
}
