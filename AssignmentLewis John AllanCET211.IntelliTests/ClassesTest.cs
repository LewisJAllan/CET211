using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for Classes</summary>
    [TestClass]
    [PexClass(typeof(Classes))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ClassesTest
    {

        /// <summary>Test stub for BookSession()</summary>
        [PexMethod]
        internal bool BookSessionTest([PexAssumeNotNull]Classes target)
        {
            bool result = target.BookSession();
            return result;
            // TODO: add assertions to method ClassesTest.BookSessionTest(Classes)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeNotNull]Classes target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method ClassesTest.ToStringTest(Classes)
        }

        /// <summary>Test stub for get_Count()</summary>
        [PexMethod]
        internal int CountGetTest([PexAssumeNotNull]Classes target)
        {
            int result = target.Count;
            return result;
            // TODO: add assertions to method ClassesTest.CountGetTest(Classes)
        }

        /// <summary>Test stub for get_Location()</summary>
        [PexMethod]
        internal string LocationGetTest([PexAssumeNotNull]Classes target)
        {
            string result = target.Location;
            return result;
            // TODO: add assertions to method ClassesTest.LocationGetTest(Classes)
        }

        /// <summary>Test stub for get_Price()</summary>
        [PexMethod]
        internal double PriceGetTest([PexAssumeNotNull]Classes target)
        {
            double result = target.Price;
            return result;
            // TODO: add assertions to method ClassesTest.PriceGetTest(Classes)
        }

        /// <summary>Test stub for get_TotalNum()</summary>
        [PexMethod]
        internal int TotalNumGetTest([PexAssumeNotNull]Classes target)
        {
            int result = target.TotalNum;
            return result;
            // TODO: add assertions to method ClassesTest.TotalNumGetTest(Classes)
        }

        /// <summary>Test stub for set_Count(Int32)</summary>
        [PexMethod]
        internal void CountSetTest([PexAssumeNotNull]Classes target, int value)
        {
            target.Count = value;
            // TODO: add assertions to method ClassesTest.CountSetTest(Classes, Int32)
        }

        /// <summary>Test stub for set_Location(String)</summary>
        [PexMethod]
        internal void LocationSetTest([PexAssumeNotNull]Classes target, string value)
        {
            target.Location = value;
            // TODO: add assertions to method ClassesTest.LocationSetTest(Classes, String)
        }

        /// <summary>Test stub for set_Price(Double)</summary>
        [PexMethod]
        internal void PriceSetTest([PexAssumeNotNull]Classes target, double value)
        {
            target.Price = value;
            // TODO: add assertions to method ClassesTest.PriceSetTest(Classes, Double)
        }

        /// <summary>Test stub for set_TotalNum(Int32)</summary>
        [PexMethod]
        internal void TotalNumSetTest([PexAssumeNotNull]Classes target, int value)
        {
            target.TotalNum = value;
            // TODO: add assertions to method ClassesTest.TotalNumSetTest(Classes, Int32)
        }
    }
}
