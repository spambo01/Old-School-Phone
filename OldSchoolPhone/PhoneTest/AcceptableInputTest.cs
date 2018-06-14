using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldSchoolPhone;

namespace PhoneTest
{
    [TestClass]
    public class AcceptableInputTest
    {
        [TestMethod]
        public void TestValidationClass()
        {
            Assert.AreEqual(false, Validation.IsLetterValid('1'));
            Assert.AreEqual(true, Validation.IsLetterValid('a'));
            Assert.AreEqual(true, Validation.IsLetterValid('.'));
            Assert.AreEqual(true, Validation.IsLetterValid('#'));
            Assert.AreEqual(true, Validation.IsLetterValid('*'));
            Assert.AreEqual(false, Validation.IsLetterValid('%'));
        }
    }
}
