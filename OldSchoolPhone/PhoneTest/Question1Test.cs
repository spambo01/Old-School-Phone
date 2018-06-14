using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldSchoolPhone;

namespace PhoneTest
{
    [TestClass]
    public class Question1Test
    {
        [TestMethod]
        public void Testglobalaerospace()
        {
            Form1 mainForm = new Form1();
            Conversion convertToNumberSequence = new Conversion();
            Assert.AreEqual("4555666222555023377766677777222233", convertToNumberSequence.ConvertToPhoneKeys("global aerospace", mainForm));
        }
    }
}
