using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    [TestClass]
    public class PasswordTest
    {
        [TestMethod]
        public void MD5Test()
        {
           string password = "test";
             string sb= string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password)).Select(s => s.ToString("x2")));

            Assert.AreEqual("098f6bcd4621d373cade4e832627b4f6", sb);
        }

        [TestMethod]
        public void SHA1Test()
        {
            string password = "test";
            string sb = string.Join("", SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(password)).Select(s => s.ToString("x2")));

            Assert.AreEqual("a94a8fe5ccb19ba61c4c0873d391e987982fbbd3", sb);
        }
    }
}
