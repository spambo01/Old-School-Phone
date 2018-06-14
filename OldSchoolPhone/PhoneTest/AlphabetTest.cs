using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldSchoolPhone;

namespace PhoneTest
{
    [TestClass]
    public class AlphabetTest
    {
        [TestMethod]
        public void TestAllLetters()
        {
            Form1 mainForm = new Form1();
            Conversion convertToNumberSequence = new Conversion();
            Assert.AreEqual("2", convertToNumberSequence.ConvertToPhoneKeys("a", mainForm));
            Assert.AreEqual("22", convertToNumberSequence.ConvertToPhoneKeys("b", mainForm));
            Assert.AreEqual("222", convertToNumberSequence.ConvertToPhoneKeys("c", mainForm));
            Assert.AreEqual("3", convertToNumberSequence.ConvertToPhoneKeys("d", mainForm));
            Assert.AreEqual("33", convertToNumberSequence.ConvertToPhoneKeys("e", mainForm));
            Assert.AreEqual("333", convertToNumberSequence.ConvertToPhoneKeys("f", mainForm));
            Assert.AreEqual("4", convertToNumberSequence.ConvertToPhoneKeys("g", mainForm));
            Assert.AreEqual("44", convertToNumberSequence.ConvertToPhoneKeys("h", mainForm));
            Assert.AreEqual("444", convertToNumberSequence.ConvertToPhoneKeys("i", mainForm));
            Assert.AreEqual("5", convertToNumberSequence.ConvertToPhoneKeys("j", mainForm));
            Assert.AreEqual("55", convertToNumberSequence.ConvertToPhoneKeys("k", mainForm));
            Assert.AreEqual("555", convertToNumberSequence.ConvertToPhoneKeys("l", mainForm));
            Assert.AreEqual("6", convertToNumberSequence.ConvertToPhoneKeys("m", mainForm));
            Assert.AreEqual("66", convertToNumberSequence.ConvertToPhoneKeys("n", mainForm));
            Assert.AreEqual("666", convertToNumberSequence.ConvertToPhoneKeys("o", mainForm));
            Assert.AreEqual("7", convertToNumberSequence.ConvertToPhoneKeys("p", mainForm));
            Assert.AreEqual("77", convertToNumberSequence.ConvertToPhoneKeys("q", mainForm));
            Assert.AreEqual("777", convertToNumberSequence.ConvertToPhoneKeys("r", mainForm));
            Assert.AreEqual("7777", convertToNumberSequence.ConvertToPhoneKeys("s", mainForm));
            Assert.AreEqual("8", convertToNumberSequence.ConvertToPhoneKeys("t", mainForm));
            Assert.AreEqual("88", convertToNumberSequence.ConvertToPhoneKeys("u", mainForm));
            Assert.AreEqual("888", convertToNumberSequence.ConvertToPhoneKeys("v", mainForm));
            Assert.AreEqual("9", convertToNumberSequence.ConvertToPhoneKeys("w", mainForm));
            Assert.AreEqual("99", convertToNumberSequence.ConvertToPhoneKeys("x", mainForm));
            Assert.AreEqual("999", convertToNumberSequence.ConvertToPhoneKeys("y", mainForm));
            Assert.AreEqual("9999", convertToNumberSequence.ConvertToPhoneKeys("z", mainForm));

        }
    }
}
