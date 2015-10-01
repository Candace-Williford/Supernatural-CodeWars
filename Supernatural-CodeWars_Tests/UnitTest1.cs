using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Supernatural_CodeWars.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Behead it with a machete, idjits!", Kata.Bob("vampire"));
            Assert.AreEqual("It depends on which one it is, idjits!", Kata.Bob("pagan god"));
            Assert.AreEqual("I have friggin no idea yet, idjits!", Kata.Bob("werepuppy"));
        }
    }
}