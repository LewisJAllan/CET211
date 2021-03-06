using System;
using AssignmentLewis_John_AllanCET211;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentLewis_John_AllanCET211.Tests
{
    /// <summary>This class contains parameterized unit tests for PersonalTrainer</summary>
    [TestClass]
    [PexClass(typeof(PersonalTrainer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PersonalTrainerTest
    {

        /// <summary>Test stub for .ctor(String, String, Int32)</summary>
        [PexMethod]
        internal PersonalTrainer ConstructorTest(
            string name,
            string location,
            int totalNum
        )
        {
            PersonalTrainer target = new PersonalTrainer(name, location, totalNum);
            return target;
            // TODO: add assertions to method PersonalTrainerTest.ConstructorTest(String, String, Int32)
        }

        /// <summary>Test stub for BookSession()</summary>
        [PexMethod]
        internal bool BookSessionTest([PexAssumeUnderTest]PersonalTrainer target)
        {
            bool result = target.BookSession();
            return result;
            // TODO: add assertions to method PersonalTrainerTest.BookSessionTest(PersonalTrainer)
        }

        /// <summary>Test stub for CompareTo(PersonalTrainer)</summary>
        [PexMethod]
        internal int CompareToTest([PexAssumeUnderTest]PersonalTrainer target, PersonalTrainer p)
        {
            int result = target.CompareTo(p);
            return result;
            // TODO: add assertions to method PersonalTrainerTest.CompareToTest(PersonalTrainer, PersonalTrainer)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]PersonalTrainer target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method PersonalTrainerTest.ToStringTest(PersonalTrainer)
        }

        /// <summary>Test stub for get_Count()</summary>
        [PexMethod]
        internal int CountGetTest([PexAssumeUnderTest]PersonalTrainer target)
        {
            int result = target.Count;
            return result;
            // TODO: add assertions to method PersonalTrainerTest.CountGetTest(PersonalTrainer)
        }

        /// <summary>Test stub for get_Location()</summary>
        [PexMethod]
        internal string LocationGetTest([PexAssumeUnderTest]PersonalTrainer target)
        {
            string result = target.Location;
            return result;
            // TODO: add assertions to method PersonalTrainerTest.LocationGetTest(PersonalTrainer)
        }

        /// <summary>Test stub for get_Name()</summary>
        [PexMethod]
        internal string NameGetTest([PexAssumeUnderTest]PersonalTrainer target)
        {
            string result = target.Name;
            return result;
            // TODO: add assertions to method PersonalTrainerTest.NameGetTest(PersonalTrainer)
        }

        /// <summary>Test stub for get_Price()</summary>
        [PexMethod]
        internal double PriceGetTest([PexAssumeUnderTest]PersonalTrainer target)
        {
            double result = target.Price;
            return result;
            // TODO: add assertions to method PersonalTrainerTest.PriceGetTest(PersonalTrainer)
        }

        /// <summary>Test stub for get_TotalNum()</summary>
        [PexMethod]
        internal int TotalNumGetTest([PexAssumeUnderTest]PersonalTrainer target)
        {
            int result = target.TotalNum;
            return result;
            // TODO: add assertions to method PersonalTrainerTest.TotalNumGetTest(PersonalTrainer)
        }

        /// <summary>Test stub for set_Count(Int32)</summary>
        [PexMethod]
        internal void CountSetTest([PexAssumeUnderTest]PersonalTrainer target, int value)
        {
            target.Count = value;
            // TODO: add assertions to method PersonalTrainerTest.CountSetTest(PersonalTrainer, Int32)
        }

        /// <summary>Test stub for set_Location(String)</summary>
        [PexMethod]
        internal void LocationSetTest([PexAssumeUnderTest]PersonalTrainer target, string value)
        {
            target.Location = value;
            // TODO: add assertions to method PersonalTrainerTest.LocationSetTest(PersonalTrainer, String)
        }

        /// <summary>Test stub for set_Name(String)</summary>
        [PexMethod]
        internal void NameSetTest([PexAssumeUnderTest]PersonalTrainer target, string value)
        {
            target.Name = value;
            // TODO: add assertions to method PersonalTrainerTest.NameSetTest(PersonalTrainer, String)
        }

        /// <summary>Test stub for set_Price(Double)</summary>
        [PexMethod]
        internal void PriceSetTest([PexAssumeUnderTest]PersonalTrainer target, double value)
        {
            target.Price = value;
            // TODO: add assertions to method PersonalTrainerTest.PriceSetTest(PersonalTrainer, Double)
        }

        /// <summary>Test stub for set_TotalNum(Int32)</summary>
        [PexMethod]
        internal void TotalNumSetTest([PexAssumeUnderTest]PersonalTrainer target, int value)
        {
            target.TotalNum = value;
            // TODO: add assertions to method PersonalTrainerTest.TotalNumSetTest(PersonalTrainer, Int32)
        }
    }
}
