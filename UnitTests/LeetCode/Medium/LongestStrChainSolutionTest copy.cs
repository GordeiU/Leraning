using System.Collections.Generic;
using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Medium {
    [TestClass]
    public class LongestPalindromicSubstringSolutionTest {
        private LongestPalindromicSubstringSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new LongestPalindromicSubstringSolution();
        }

        [TestMethod]
        public void LongestPalindrome_ShortOne() {
            string word = "babad";

            string actual = TestingClass.LongestPalindrome(word);
            HashSet<string> expectedPossibleAnswers = new HashSet<string>() { "aba", "bab" };

            Assert.IsTrue(expectedPossibleAnswers.Contains(actual));
        }

        [TestMethod]
        public void LongestPalindrome_ShortOnePossible() {
            string word = "cbbd";

            string actual = TestingClass.LongestPalindrome(word);
            string  expectedPossibleAnswers = "bb";

            Assert.AreEqual(expectedPossibleAnswers, actual);
        }
    }
}