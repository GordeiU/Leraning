using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class ImplementFindStrSolutionTest {
        private ImplementFindStrSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new ImplementFindStrSolution();
        }

        [TestMethod]
        public void StrStr_EmptySubstring() {
            int actual = TestingClass.StrStr("test", string.Empty);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_SubStringExists() {
            int actual = TestingClass.StrStr("hello", "ll");
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_SubStringDoesntExist() {
            int actual = TestingClass.StrStr("hello", "dc");
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
    }
}