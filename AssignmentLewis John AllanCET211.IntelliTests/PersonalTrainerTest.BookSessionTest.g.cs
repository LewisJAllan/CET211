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
    public partial class PersonalTrainerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(PersonalTrainerTest))]
public void BookSessionTest861()
{
    PersonalTrainer personalTrainer;
    bool b;
    personalTrainer = new PersonalTrainer((string)null, (string)null, 0);
    personalTrainer.Price = 0;
    personalTrainer.Count = 0;
    b = this.BookSessionTest(personalTrainer);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)personalTrainer);
}

[TestMethod]
[PexGeneratedBy(typeof(PersonalTrainerTest))]
public void BookSessionTest515()
{
    PersonalTrainer personalTrainer;
    bool b;
    personalTrainer = new PersonalTrainer((string)null, (string)null, 128);
    personalTrainer.Price = 0;
    personalTrainer.Count = 0;
    b = this.BookSessionTest(personalTrainer);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)personalTrainer);
}
    }
}
