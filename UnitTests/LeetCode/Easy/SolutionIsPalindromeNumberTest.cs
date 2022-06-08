using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class SolutionIsPalindromeNumberTest {
        private SolutionIsPalindromeNumber TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new SolutionIsPalindromeNumber();
        }

        [TestMethod]
        public void IsPalindrome_NegativeNumber_False() {
            bool actual = TestingClass.IsPalindrome(-123);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsPalindrome_PositiveOddNumberCount_False() {
            bool actual = TestingClass.IsPalindrome(123);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsPalindrome_PositiveOddNumberCount_True() {
            bool actual = TestingClass.IsPalindrome(121);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPalindrome_Zero_True() {
            bool actual = TestingClass.IsPalindrome(0);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPalindrome_PositiveEvenNumberCount_True() {
            bool actual = TestingClass.IsPalindrome(1221);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPalindrome_PositiveEvenNumberCount_False() {
            bool actual = TestingClass.IsPalindrome(123421);
            Assert.IsFalse(actual);
        }
    }
}