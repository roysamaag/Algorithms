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
            strings.RemoveDuplicatesFromString("AABBBCCDDE");
        }
    }
}
