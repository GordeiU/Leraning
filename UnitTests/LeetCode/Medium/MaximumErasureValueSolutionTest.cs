using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class MaximumErasureValueSolutionTest {
        private MaximumErasureValueSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new MaximumErasureValueSolution();
        }

        [TestMethod]
        public void MaximumUniqueSubArray_ShortOne() {
            int[] numbers = new int[] { 4, 2, 4, 5, 6 };

            int actual = TestingClass.MaximumUniqueSubArray(numbers);
            int expected = 17;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumUniqueSubArray_ShortTwo() {
            int[] numbers = new int[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 };

            int actual = TestingClass.MaximumUniqueSubArray(numbers);
            int expected = 8;
            Assert.AreEqual(expected, actual);
        }
    }
}