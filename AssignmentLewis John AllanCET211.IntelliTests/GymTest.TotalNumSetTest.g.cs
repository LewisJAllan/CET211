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
    public partial class GymTest
    {

[TestMethod]
[PexGeneratedBy(typeof(GymTest))]
public void TotalNumSetTest148()
{
    Gym gym;
    gym = new Gym((string)null);
    gym.TotalNum = 0;
    gym.Price = 0;
    gym.Count = 0;
    this.TotalNumSetTest(gym, 0);
    Assert.IsNotNull((object)gym);
}
    }
}
