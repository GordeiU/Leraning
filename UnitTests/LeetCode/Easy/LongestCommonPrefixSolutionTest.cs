using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class LongestCommonPrefixSolutionTest {
        [TestMethod]
        public void FindLongestCommonPrefix_SingleWord() {
            string[] words = new string[1] { "word" };

            string actual = LongestCommonPrefixSolution.FindLongestCommonPrefix(words);
            string expected = "word";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLongestCommonPrefix_TwoSameWords() {
            string[] words = new string[2] { "word", "word" };

            string actual = LongestCommonPrefixSolution.FindLongestCommonPrefix(words);
            string expected = "word";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLongestCommonPrefix_TwoWordsFirstShorter() {
            string[] words = new string[2] { "wo", "word" };

            string actual = LongestCommonPrefixSolution.FindLongestCommonPrefix(words);
            string expected = "wo";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLongestCommonPrefix_TwoWordsSecondShorter() {
            string[] words = new string[2] { "word", "wo" };

            string actual = LongestCommonPrefixSolution.FindLongestCommonPrefix(words);
            string expected = "wo";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindLongestCommonPrefix_NoCommon() {
            string[] words = new string[3] { "dog", "racecar", "car" };

            string actual = LongestCommonPrefixSolution.FindLongestCommonPrefix(words);
            string expected = string.Empty;
            Assert.AreEqual(expected, actual);
        }
    }
}