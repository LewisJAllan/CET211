using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Add reference
using AssignmentLewis_John_AllanCET211;
//add alias
using TestedClass = AssignmentLewis_John_AllanCET211.User;

namespace UserTest
{
    [TestClass]
    public class TestFixture_User
    {
        // declare reference to the class being tested
        private TestedClass User;        [TestInitialize]
        public void TestInitialize()
        {
            // A new instance of the class is created for every test case.
            // This is therefore part of each test cases "Arrange" section.
            User = new TestedClass("test", "test", "test");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            // Ensure that the object reference is set to null so any actual instance
            // can be garbage collected.
            User = null;
        }
        [TestMethod]
        public void ShowTotal_Test30_Outputis30()
        {
            int runningTotal = 30;
            User.RunningCost = 30;
            string expected = "The current running total for " + User.UserName + " is: " + runningTotal;
            string actual = User.ShowTotal();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckLogin_TestTrue_OutputisTrue()
        {
            string user = User.UserName;
            string password = User.Password;
            Boolean expected = true;
            Boolean actual;
            actual = User.CheckLogin(user, password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckLogin_TestFalse_OutputisFalse()
        {
            string user = "false";
            string password = "false";
            Boolean expected = false;
            Boolean actual;
            actual = User.CheckLogin(user, password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pay_TestPay_ReturnsStringSuccessful()
        {
            string msg = User.ShowTotal() + ".  Thank you for paying for your bill.";
            string expected = msg;
            string actual;
            actual = User.Pay();
            Assert.AreEqual(expected, actual);
        }
    }
}
