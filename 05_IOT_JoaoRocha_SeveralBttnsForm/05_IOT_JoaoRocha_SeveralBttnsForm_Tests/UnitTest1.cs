using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05_IOT_JoaoRocha_SeveralBttnsForm;

namespace _05_IOT_JoaoRocha_SeveralBttnsForm_Tests
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form1 = new Form1();
        [TestMethod]
        public void IsRespostaOK_OKOption_True()
        {
            Assert.AreEqual<bool>(form1.IsRespostaOK(new DialogResult().OK), true); 
        }
    }
}
