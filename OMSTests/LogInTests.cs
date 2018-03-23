using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FYP___OrderManagementSystem;
namespace OMSTests
{
    [TestClass]
    public class LogInTests
    {
        [TestMethod]
        public void LogIn_WithValidAccount_AllowAccess()
        {
            // arrange  
            var userName = "ainePUR1";
            var passWord = "pass123";
            Login login = new Login();

            // act  
            login.CheckLogInAuthenticity(userName, passWord);

            // assert  
            /*double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");*/
        }
    }
}
