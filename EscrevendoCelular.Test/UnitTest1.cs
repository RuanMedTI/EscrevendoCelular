using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EscrevendoCelular.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SempreAcessoODojoPuzzles()
        {
            string fraseSms = "SEMPRE ACESSO O DOJOPUZZLES";   
            Assert.AreEqual(fraseSms, "SEMPRE ACESSO O DOJOPUZZLES", "77773367_7773302_222337777_777766606660366656667889999_9999555337777");
        }

        [TestMethod]
        public void Ruan()
        {
            string fraseSms = "RUAN";
            Assert.AreEqual(fraseSms, "RUAN", "77788266");
        }

        [TestMethod]
        public void Brasil()
        {
            string fraseSms = "BRASIL";
            Assert.AreEqual(fraseSms, "BRASIL", "2277727777444555");
        }

        [TestMethod]
        public void Flamengo()
        {
            string fraseSms = "FLAMENGO";
            Assert.AreEqual(fraseSms, "FLAMENGO", "3335552633664666");
        }

        [TestMethod]
        public void Celular()
        {
            string fraseSms = "CELULAR";
            Assert.AreEqual(fraseSms, "CELULAR", "22233555885552777");
        }
    }
}
