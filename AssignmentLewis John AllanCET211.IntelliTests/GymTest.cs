using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for Gym</summary>
    [TestClass]
    [PexClass(typeof(Gym))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GymTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal Gym ConstructorTest(string location)
        {
            Gym target = new Gym(location);
            return target;
            // TODO: add assertions to method GymTest.ConstructorTest(String)
        }

        /// <summary>Test stub for BookSession()</summary>
        [PexMethod]
        internal bool BookSessionTest([PexAssumeUnderTest]Gym target)
        {
            bool result = target.BookSession();
            return result;
            // TODO: add assertions to method GymTest.BookSessionTest(Gym)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]Gym target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method GymTest.ToStringTest(Gym)
        }

        /// <summary>Test stub for get_Count()</summary>
        [PexMethod]
        internal int CountGetTest([PexAssumeUnderTest]Gym target)
        {
            int result = target.Count;
            return result;
            // TODO: add assertions to method GymTest.CountGetTest(Gym)
        }

        /// <summary>Test stub for get_Location()</summary>
        [PexMethod]
        internal string LocationGetTest([PexAssumeUnderTest]Gym target)
        {
            string result = target.Location;
            return result;
            // TODO: add assertions to method GymTest.LocationGetTest(Gym)
        }

        /// <summary>Test stub for get_Price()</summary>
        [PexMethod]
        internal double PriceGetTest([PexAssumeUnderTest]Gym target)
        {
            double result = target.Price;
            return result;
            // TODO: add assertions to method GymTest.PriceGetTest(Gym)
        }

        /// <summary>Test stub for get_TotalNum()</summary>
        [PexMethod]
        internal int TotalNumGetTest([PexAssumeUnderTest]Gym target)
        {
            int result = target.TotalNum;
            return result;
            // TODO: add assertions to method GymTest.TotalNumGetTest(Gym)
        }

        /// <summary>Test stub for set_Count(Int32)</summary>
        [PexMethod]
        internal void CountSetTest([PexAssumeUnderTest]Gym target, int value)
        {
            target.Count = value;
            // TODO: add assertions to method GymTest.CountSetTest(Gym, Int32)
        }

        /// <summary>Test stub for set_Location(String)</summary>
        [PexMethod]
        internal void LocationSetTest([PexAssumeUnderTest]Gym target, string value)
        {
            target.Location = value;
            // TODO: add assertions to method GymTest.LocationSetTest(Gym, String)
        }

        /// <summary>Test stub for set_Price(Double)</summary>
        [PexMethod]
        internal void PriceSetTest([PexAssumeUnderTest]Gym target, double value)
        {
            target.Price = value;
            // TODO: add assertions to method GymTest.PriceSetTest(Gym, Double)
        }

        /// <summary>Test stub for set_TotalNum(Int32)</summary>
        [PexMethod]
        internal void TotalNumSetTest([PexAssumeUnderTest]Gym target, int value)
        {
            target.TotalNum = value;
            // TODO: add assertions to method GymTest.TotalNumSetTest(Gym, Int32)
        }
    }
}
