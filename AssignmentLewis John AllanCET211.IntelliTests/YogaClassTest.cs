using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for YogaClass</summary>
    [TestClass]
    [PexClass(typeof(YogaClass))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class YogaClassTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal YogaClass ConstructorTest(string location)
        {
            YogaClass target = new YogaClass(location);
            return target;
            // TODO: add assertions to method YogaClassTest.ConstructorTest(String)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]YogaClass target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method YogaClassTest.ToStringTest(YogaClass)
        }
    }
}
