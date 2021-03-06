// <copyright file="BoxingClassTest.cs">Copyright ©  2015</copyright>
using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for BoxingClass</summary>
    [PexClass(typeof(BoxingClass))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BoxingClassTest
    {
        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal BoxingClass ConstructorTest(string location)
        {
            BoxingClass target = new BoxingClass(location);
            return target;
            // TODO: add assertions to method BoxingClassTest.ConstructorTest(String)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]BoxingClass target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method BoxingClassTest.ToStringTest(BoxingClass)
        }
    }
}
