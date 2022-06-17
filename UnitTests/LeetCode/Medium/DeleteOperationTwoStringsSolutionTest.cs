using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Medium {
    [TestClass]
    public class DeleteOperationTwoStringsSolutionTest {
        private DeleteOperationTwoStringsSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new DeleteOperationTwoStringsSolution();
        }

        [TestMethod]
        public void MinDistance_ShortOne() {
            string firstString = "sea";
            string secondString = "eat";

            int actual = TestingClass.MinDistance(firstString, secondString);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinDistance_ShortTwo() {
            string firstString = "leetcode";
            string secondString = "etco";

            int actual = TestingClass.MinDistance(firstString, secondString);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}