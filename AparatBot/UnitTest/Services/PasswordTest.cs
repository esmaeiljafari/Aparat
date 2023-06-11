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
           string password = "esmaeil152487639";
             string sb= string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password)).Select(s => s.ToString("x2")));

            Assert.AreEqual("dcbbc0c1c6bc8e009a8c6c6687da75e8", sb);
        }

        [TestMethod]
        public void SHA1Test()
        {
            string password = "dcbbc0c1c6bc8e009a8c6c6687da75e8";
            string sb = string.Join("", SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(password)).Select(s => s.ToString("x2")));

            Assert.AreEqual("1b3597d830edbfdf5562b3054ab7dd1a27477b83", sb);
        }
    }
}
