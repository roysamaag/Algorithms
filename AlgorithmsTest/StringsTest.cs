using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace AlgorithmsTest
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void RemoveDuplicatesFromStringTest()
        {
            Strings strings = new Strings();
            string result = strings.RemoveDuplicatesFromString("AABBBCCDDEA",3);
            Assert.AreEqual(result, "AACCDDEA");

            result = strings.RemoveDuplicatesFromString("AABBBCCCDDEA",3);
            Assert.AreEqual(result, "AADDEA");

            result = strings.RemoveDuplicatesFromString("AABBBCCDDEAAA",3);
            Assert.AreEqual(result, "AACCDDE");

            result = strings.RemoveDuplicatesFromString("AAABBBCCDEA",3);
            Assert.AreEqual(result, "CCDEA");

            result = strings.RemoveDuplicatesFromString("AAAABBBBCCDEA",3);
            Assert.AreEqual(result, "AAAABBBBCCDEA");

            result = strings.RemoveDuplicatesFromString("AABBBBCCDDEA", 4);
            Assert.AreEqual(result, "AACCDDEA");

            result = strings.RemoveDuplicatesFromString("AABBBCCCDDEA", 2);
            Assert.AreEqual(result, "BBBCCCEA");

            result = strings.RemoveDuplicatesFromString("AABBBCCCDDEA", 1);
            Assert.AreEqual(result, "AABBBCCCDD");

            result = strings.RemoveDuplicatesFromString("AAABBBCCDEA", 5);
            Assert.AreEqual(result, "AAABBBCCDEA");

            result = strings.RemoveDuplicatesFromString("AAAABBBBBBCCCCCCCDBEAC", 6);
            Assert.AreEqual(result, "AAAACCCCCCCDBEAC");
        }
    }
}
