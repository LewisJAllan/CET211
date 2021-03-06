using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for User</summary>
    [TestClass]
    [PexClass(typeof(User))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UserTest
    {

        /// <summary>Test stub for .ctor(String, String, String)</summary>
        [PexMethod]
        public User ConstructorTest(
            string Name,
            string Username,
            string Password
        )
        {
            User target = new User(Name, Username, Password);
            return target;
            // TODO: add assertions to method UserTest.ConstructorTest(String, String, String)
        }

        /// <summary>Test stub for BookItem(IBookable)</summary>
        [PexMethod]
        public string BookItemTest([PexAssumeUnderTest]User target, IBookable bookable)
        {
            string result = target.BookItem(bookable);
            return result;
            // TODO: add assertions to method UserTest.BookItemTest(User, IBookable)
        }

        /// <summary>Test stub for CheckLogin(String, String)</summary>
        [PexMethod]
        public bool CheckLoginTest(
            [PexAssumeUnderTest]User target,
            string USERNAME,
            string PASSWORD
        )
        {
            bool result = target.CheckLogin(USERNAME, PASSWORD);
            return result;
            // TODO: add assertions to method UserTest.CheckLoginTest(User, String, String)
        }

        /// <summary>Test stub for Pay()</summary>
        [PexMethod]
        public string PayTest([PexAssumeUnderTest]User target)
        {
            string result = target.Pay();
            return result;
            // TODO: add assertions to method UserTest.PayTest(User)
        }

        /// <summary>Test stub for SessionType(IBookable)</summary>
        [PexMethod]
        public string SessionTypeTest([PexAssumeUnderTest]User target, IBookable bookable)
        {
            string result = target.SessionType(bookable);
            return result;
            // TODO: add assertions to method UserTest.SessionTypeTest(User, IBookable)
        }

        /// <summary>Test stub for ShowTotal()</summary>
        [PexMethod]
        public string ShowTotalTest([PexAssumeUnderTest]User target)
        {
            string result = target.ShowTotal();
            return result;
            // TODO: add assertions to method UserTest.ShowTotalTest(User)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        public string ToStringTest([PexAssumeUnderTest]User target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method UserTest.ToStringTest(User)
        }

        /// <summary>Test stub for get_AccountNumber()</summary>
        [PexMethod]
        public int AccountNumberGetTest([PexAssumeUnderTest]User target)
        {
            int result = target.AccountNumber;
            return result;
            // TODO: add assertions to method UserTest.AccountNumberGetTest(User)
        }

        /// <summary>Test stub for get_Name()</summary>
        [PexMethod]
        public string NameGetTest([PexAssumeUnderTest]User target)
        {
            string result = target.Name;
            return result;
            // TODO: add assertions to method UserTest.NameGetTest(User)
        }

        /// <summary>Test stub for get_Password()</summary>
        [PexMethod]
        public string PasswordGetTest([PexAssumeUnderTest]User target)
        {
            string result = target.Password;
            return result;
            // TODO: add assertions to method UserTest.PasswordGetTest(User)
        }

        /// <summary>Test stub for get_RunningCost()</summary>
        [PexMethod]
        public double RunningCostGetTest([PexAssumeUnderTest]User target)
        {
            double result = target.RunningCost;
            return result;
            // TODO: add assertions to method UserTest.RunningCostGetTest(User)
        }

        /// <summary>Test stub for get_UserName()</summary>
        [PexMethod]
        public string UserNameGetTest([PexAssumeUnderTest]User target)
        {
            string result = target.UserName;
            return result;
            // TODO: add assertions to method UserTest.UserNameGetTest(User)
        }

        /// <summary>Test stub for set_AccountNumber(Int32)</summary>
        [PexMethod]
        public void AccountNumberSetTest([PexAssumeUnderTest]User target, int value)
        {
            target.AccountNumber = value;
            // TODO: add assertions to method UserTest.AccountNumberSetTest(User, Int32)
        }

        /// <summary>Test stub for set_Name(String)</summary>
        [PexMethod]
        public void NameSetTest([PexAssumeUnderTest]User target, string value)
        {
            target.Name = value;
            // TODO: add assertions to method UserTest.NameSetTest(User, String)
        }

        /// <summary>Test stub for set_Password(String)</summary>
        [PexMethod]
        public void PasswordSetTest([PexAssumeUnderTest]User target, string value)
        {
            target.Password = value;
            // TODO: add assertions to method UserTest.PasswordSetTest(User, String)
        }

        /// <summary>Test stub for set_RunningCost(Double)</summary>
        [PexMethod]
        public void RunningCostSetTest([PexAssumeUnderTest]User target, double value)
        {
            target.RunningCost = value;
            // TODO: add assertions to method UserTest.RunningCostSetTest(User, Double)
        }

        /// <summary>Test stub for set_UserName(String)</summary>
        [PexMethod]
        public void UserNameSetTest([PexAssumeUnderTest]User target, string value)
        {
            target.UserName = value;
            // TODO: add assertions to method UserTest.UserNameSetTest(User, String)
        }
    }
}
