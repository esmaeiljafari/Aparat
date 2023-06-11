using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services.api
{
    [TestClass]
    public class UserTests
    {
        AparatBot.api.IAparatApi _api;
        private string username = "test123";
        private string password = "123123";


        [TestMethod]
        public void LoginTest()
        {
            _api = new AparatBot.api.ApiAparat();

            var r = _api.SignIn.LoginAsync(username, password).Result;
            Assert.IsFalse(r.Success);
        }

        [TestMethod]
        public void isAutenticationTest()
        {
            _api = new AparatBot.api.ApiAparat();
            var r = _api.SignIn.LoginAsync(username, password);
            r.Wait();
            Assert.IsFalse(_api.isAutentication);
        }


    }
}
