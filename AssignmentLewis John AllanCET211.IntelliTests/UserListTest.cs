using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for UserList</summary>
    [TestClass]
    [PexClass(typeof(UserList))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UserListTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal UserList ConstructorTest()
        {
            UserList target = new UserList();
            return target;
            // TODO: add assertions to method UserListTest.ConstructorTest()
        }

        /// <summary>Test stub for AddUser(User)</summary>
        [PexMethod]
        internal bool AddUserTest([PexAssumeUnderTest]UserList target, User user)
        {
            bool result = target.AddUser(user);
            return result;
            // TODO: add assertions to method UserListTest.AddUserTest(UserList, User)
        }

        /// <summary>Test stub for FindItem(String)</summary>
        [PexMethod]
        internal User FindItemTest([PexAssumeUnderTest]UserList target, string UserName)
        {
            User result = target.FindItem(UserName);
            return result;
            // TODO: add assertions to method UserListTest.FindItemTest(UserList, String)
        }
    }
}
