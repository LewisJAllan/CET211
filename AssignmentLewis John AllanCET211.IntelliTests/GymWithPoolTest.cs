using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for GymWithPool</summary>
    [TestClass]
    [PexClass(typeof(GymWithPool))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GymWithPoolTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal GymWithPool ConstructorTest(string location)
        {
            GymWithPool target = new GymWithPool(location);
            return target;
            // TODO: add assertions to method GymWithPoolTest.ConstructorTest(String)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]GymWithPool target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method GymWithPoolTest.ToStringTest(GymWithPool)
        }
    }
}
