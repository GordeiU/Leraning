using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class ConvertRomanNumberSolutionTest {
        [TestMethod]
        public void ConvertRomanNumber_Single() {
            int actual = ConvertRomanNumberSolution.ConvertRomanNumber("M");
            int expected = 1000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_EvenWithSubtraction() {
            int actual = ConvertRomanNumberSolution.ConvertRomanNumber("IX");
            int expected = 9;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_EvenMedium() {
            int actual = ConvertRomanNumberSolution.ConvertRomanNumber("MMXXII");
            int expected = 2022;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_OddMedium() {
            int actual = ConvertRomanNumberSolution.ConvertRomanNumber("MMXXIII");
            int expected = 2023;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_OddEdge() {
            int actual = ConvertRomanNumberSolution.ConvertRomanNumber("MMIX");
            int expected = 2009;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_EvenBig() {
            int actual = ConvertRomanNumberSolution.ConvertRomanNumber("MMMDCCXXIV");
            int expected = 3724;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_OddBig() {
            int actual = ConvertRomanNumberSolution.ConvertRomanNumber("MMMDCCXXXIV");
            int expected = 3734;
            Assert.AreEqual(expected, actual);
        }
    }
}