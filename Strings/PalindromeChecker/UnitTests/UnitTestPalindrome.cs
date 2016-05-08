using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;

namespace UnitTests
{
    [TestClass]
    public class UnitTestPalindrome
    {
        [TestMethod]
        public void PositiveEqualCharacters()
        {
            Assert.IsTrue(Program.IsPalindrome("asddsa"));
        }

        [TestMethod]
        public void PositiveNonEqualCharacter()
        {
            Assert.IsTrue(Program.IsPalindrome("asdsa"));
        }
        
        [TestMethod]
        public void Negative()
        {
            Assert.IsFalse(Program.IsPalindrome("asdsasdfhtlg"));
        }

        [TestMethod]
        public void PositiveUpperCaseToLowerCase()
        {
            Assert.IsTrue(Program.IsPalindrome("Romor"));
        }

        [TestMethod]
        public void EmptyString()
        {
            Assert.IsTrue(Program.IsPalindrome(""));
        }

        [TestMethod]
        public void Positive_DifferentLanguage()
        {
            Assert.IsTrue(Program.IsPalindrome("шалаш"));
        }

        [TestMethod]
        public void Negative_DifferentLanguage()
        {
            Assert.IsFalse(Program.IsPalindrome("шалашик"));
        }

    }
}
