using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01_IOT_JoaoRocha_Console;

namespace _01_IOT_JoaoRocha_Console_Tests
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();

        [TestMethod]
        public void ConcatFullNameNoDisplay_Correct_True()
        {
            Assert.AreEqual("Joao Rocha", program.ConcatFullNameNoDisplay("Joao", "Rocha"));
        }
    }
}
