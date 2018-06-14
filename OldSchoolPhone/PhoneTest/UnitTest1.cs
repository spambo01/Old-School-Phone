using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldSchoolPhone;

namespace PhoneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 mainForm = new Form1();
            BusinessLogic businessLogic = new BusinessLogic();
            Assert.AreEqual("4555666222555023377766677777222233", businessLogic.ConvertToPhoneKeys("global aerospace", mainForm));
            
        }
    }
}
