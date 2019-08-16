using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_TransportSecurity_W_CertificateAuth
{
    [TestClass]
    public class RepeatedString_UnitTest
    {
        [DataRow("ababbaa", 10, 6)]
        [DataRow("aaaaa", 123, 123)]
        [DataRow("ccc", 1000000000000, 0)]
        [DataRow("a", 1000000000000, 1000000000000)]
        [DataTestMethod]
        public void RepeatedStringTest(string repeatedString, long number, long expected)
        {
            RepeatedStringReference.RepeatedStringClient client = new RepeatedStringReference.RepeatedStringClient();
            
            Assert.AreEqual(client.RepeatedString(repeatedString, number), expected);

            client.Close();
        }
    }
}
