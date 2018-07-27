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
        public void ValidateName_IsItEmpty_True()
        {
            frm.SetTxtNomeVal(" ");
            Assert.AreEqual("O campo está em vazio, por favor insira o seu 1º nome",
                "O campo está em vazio, por favor insira o seu 1º nome");
        }
        [TestMethod]
        public void ValidateName_AreSymbolsValid_False()
        {
            frm.SetTxtNomeVal("℅");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), 
                "Digitou um(ns) valor(es) inválidos, foi pedido apenas um nome");
        }
        [TestMethod]
        public void ValidateName_AreDigitsValid_False()
        {
            frm.SetTxtNomeVal("03847948372951");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), 
                "Digitou um(ns) valor(es) inválidos, foi pedido apenas um nome");
        }
        [TestMethod]
        public void ValidateName_IsPunctuationValid_False()
        {
            frm.SetTxtNomeVal("!?.,");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), 
                "Digitou um(ns) valor(es) inválidos, foi pedido apenas um nome");
        }
        [TestMethod]
        public void ValidateName_AreLettersValid_True()
        {
            frm.SetTxtNomeVal("Jooooo Looooool");
            string txtNome = frm.GetTxtNomeVal();
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), "Jooooo Looooool");
        }
        [TestMethod]
        public void ValidateName_IsNotBiggerThan50Chars()
        {
            Assert.AreEqual(frm.ValidateName(frm.GetTxtNomeVal()), "jfsdljfsdlf" +
                "jlsdjflsdjflsdjflsdjflsdjflsdjfljjjjjjjffffffffffffffffffffffffff" +
                "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff" +
                "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff");
        }
    }
}
