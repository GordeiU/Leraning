using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Medium {
    [TestClass]
    public class KthLargestElementArraySolutionTest {
        private KthLargestElementArraySolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new KthLargestElementArraySolution();
        }

        [TestMethod]
        public void FindKthLargest_ShortTwo() {
            int[] numbers = new int[] { 3, 2, 1, 5, 6, 4 };
            int maxElNumber = 2;

            int actual = TestingClass.FindKthLargest(numbers, maxElNumber);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}