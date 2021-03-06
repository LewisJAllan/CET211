using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for EnterFieldsException</summary>
    [TestClass]
    [PexClass(typeof(EnterFieldsException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EnterFieldsExceptionTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal EnterFieldsException ConstructorTest()
        {
            EnterFieldsException target = new EnterFieldsException();
            return target;
            // TODO: add assertions to method EnterFieldsExceptionTest.ConstructorTest()
        }
    }
}
