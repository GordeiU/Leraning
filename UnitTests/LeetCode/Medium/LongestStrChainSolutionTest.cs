using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Medium {
    [TestClass]
    public class LongestStrChainSolutionTest {
        private LongestStrChainSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new LongestStrChainSolution();
        }

        [TestMethod]
        public void LongestStrChain_ShortOne() {
            string[] words = new string[] { "a", "b", "ba", "bca", "bda", "bdca" };
            int actual = TestingClass.LongestStrChain(words);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestStrChain_ShortTwo() {
            string[] words = new string[] { "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" };
            int actual = TestingClass.LongestStrChain(words);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestStrChain_ShortThree() {
            string[] words = new string[] { "abcd", "dbqca" };
            int actual = TestingClass.LongestStrChain(words);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestStrChain_ShortFour() {
            string[] words = new string[] { "a", "b", "ab", "bac" };
            int actual = TestingClass.LongestStrChain(words);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}