using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class ValidParenthesesSolutionTest {
        private ValidParenthesesSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new ValidParenthesesSolution();
        }

        [TestMethod]
        public void IsValid_Valid() {
            bool actual = TestingClass.IsValid("()[]{}");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsValid_NotValidMissingOpeningEnd() {
            bool actual = TestingClass.IsValid("()[]{}}");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsValid_NotValidMissingOpeningStart() {
            bool actual = TestingClass.IsValid("]()[]{}}");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsValid_NotValidMismatch() {
            bool actual = TestingClass.IsValid("[}]");
            Assert.IsFalse(actual);
        }
    }
}