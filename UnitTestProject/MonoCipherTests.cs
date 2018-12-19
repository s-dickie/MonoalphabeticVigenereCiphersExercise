using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonoalphabeticVigenereCiphersExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoalphabeticVigenereCiphersExercise.Tests
{
    [TestClass()]
    public class MonoCipherTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            var MC = new MonoCipher();
            MC.Encrypt();
            MC.Decrypt();
            Assert.AreEqual(1,2);
        }
    }
}