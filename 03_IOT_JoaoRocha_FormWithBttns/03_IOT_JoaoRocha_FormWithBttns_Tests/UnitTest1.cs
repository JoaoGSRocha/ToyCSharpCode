using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_IOT_JoaoRocha_FormWithBttns;
using System;
using System.Windows.Forms;


namespace _03_IOT_JoaoRocha_FormWithBttns_Tests
{
    [TestClass]
    public class UnitTest1
    {
        frmUtilizadores frm = new frmUtilizadores();
        [TestMethod]
        public void validateName_IsItEmpty_True()
        {
            frm.SetTxtNomeVal("");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()),
                "O campo está em vazio, por favor insira o seu 1º nome");
        }
        [TestMethod]
        public void validateName_AreSymbolsValid_False()
        {
            frm.SetTxtNomeVal("℅");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), 
                "Digitou um(ns) valor(es) inválidos, foi pedido apenas um nome");
        }
        [TestMethod]
        public void validateName_AreDigitsValid_False()
        {
            frm.SetTxtNomeVal("03847948372951");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), 
                "Digitou um(ns) valor(es) inválidos, foi pedido apenas um nome");
        }
        [TestMethod]
        public void validateName_IsPunctuationValid_False()
        {
            frm.SetTxtNomeVal("!?.,");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), 
                "Digitou um(ns) valor(es) inválidos, foi pedido apenas um nome");
        }
        [TestMethod]
        public void validateName_AreLettersValid_True()
        {
            frm.SetTxtNomeVal("Jooooo Looooool");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), "Jooooo Looooool");
        }
        [TestMethod]
        public void validateName_IsNotBiggerThan50Chars()
        {
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), "jfsdljfsdlf" +
                "jlsdjflsdjflsdjflsdjflsdjflsdjfljjjjjjjffffffffffffffffffffffffff" +
                "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff" +
                "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff");
        }
    }
}
