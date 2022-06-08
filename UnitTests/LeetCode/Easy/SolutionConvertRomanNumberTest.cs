using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class SolutionConvertRomanNumberTest {
        [TestMethod]
        public void ConvertRomanNumber_Single() {
            int actual = SolutionConvertRomanNumber.ConvertRomanNumber("M");
            int expected = 1000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_EvenWithSubtraction() {
            int actual = SolutionConvertRomanNumber.ConvertRomanNumber("IX");
            int expected = 9;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_EvenMedium() {
            int actual = SolutionConvertRomanNumber.ConvertRomanNumber("MMXXII");
            int expected = 2022;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_OddMedium() {
            int actual = SolutionConvertRomanNumber.ConvertRomanNumber("MMXXIII");
            int expected = 2023;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_OddEdge() {
            int actual = SolutionConvertRomanNumber.ConvertRomanNumber("MMIX");
            int expected = 2009;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_EvenBig() {
            int actual = SolutionConvertRomanNumber.ConvertRomanNumber("MMMDCCXXIV");
            int expected = 3724;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRomanNumber_OddBig() {
            int actual = SolutionConvertRomanNumber.ConvertRomanNumber("MMMDCCXXXIV");
            int expected = 3734;
            Assert.AreEqual(expected, actual);
        }
    }
}