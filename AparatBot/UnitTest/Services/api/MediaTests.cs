using AparatBot.api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services.api
{
    [TestClass]
    public class MediaTests
    {
        [TestMethod]
        public void GetMediaByTags_NotNull__TEST()
        {
            IAparatApi api = new ApiAparat();

            var model = api.MediaProcessor.GetMediaByTags("جشواره").Result;

            Assert.IsNotNull(model);
        }
    }
}
