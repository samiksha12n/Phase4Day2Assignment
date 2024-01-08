using NUnit.Framework;
using NunitSignInLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSignInDay2Assignment
{
    [TestFixture]
    public class Program
    {
        SignIn sign;
        [SetUp]
        public void SetUp()
        {
            SignIn sign = new SignIn();
        }

        [Test]
        public void SignInTest()
        {
            string username = "sam", password = "sam@1256";
            string expectedResult = "Authentication Pass";
            Assert.Equals(expectedResult,sign.Authenticate(username,password));            
        }
        public void SignInFail()
        {
            string username = "raj", password = "raj@123";
            string expectedResult = "Authentication Fail";
          Assert.Equals(expectedResult ,sign.Authenticate(username,password));  
        }
        static void Main(string[] args)
        {
        }
    }
}
