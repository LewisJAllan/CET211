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
    public partial class ClassesTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ClassesTest))]
public void ToStringTest298()
{
    YogaClass yogaClass;
    string s;
    yogaClass = new YogaClass((string)null);
    ((Classes)yogaClass).Count = 0;
    s = this.ToStringTest((Classes)yogaClass);
    Assert.AreEqual<string>
        ("The gym for this class is located at:  and it has a monthly cost of: £7.00.  The session booked is for Yoga.", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ClassesTest))]
public void ToStringTest29801()
{
    YogaClass yogaClass;
    string s;
    yogaClass = new YogaClass("");
    ((Classes)yogaClass).Count = 0;
    s = this.ToStringTest((Classes)yogaClass);
    Assert.AreEqual<string>
        ("The gym for this class is located at:  and it has a monthly cost of: £7.00.  The session booked is for Yoga.", 
         s);
}
    }
}
