using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentLewis_John_AllanCET211;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    public partial class UserTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UserTest))]
public void PasswordGetTest495()
{
    User user;
    string s;
    user = new User((string)null, (string)null, (string)null);
    s = this.PasswordGetTest(user);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)user);
    Assert.AreEqual<string>((string)null, user.Name);
    Assert.AreEqual<string>((string)null, user.UserName);
    Assert.AreEqual<string>((string)null, user.Password);
    Assert.AreEqual<int>(0, user.AccountNumber);
    Assert.AreEqual<double>(0, user.RunningCost);
}
    }
}
