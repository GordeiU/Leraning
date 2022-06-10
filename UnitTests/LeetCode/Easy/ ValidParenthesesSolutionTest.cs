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
    }
}