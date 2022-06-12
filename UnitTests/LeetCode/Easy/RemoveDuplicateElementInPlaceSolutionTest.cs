using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class RemoveDuplicateElementInPlaceSolutionTest {
        private RemoveDuplicateElementInPlaceSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new RemoveDuplicateElementInPlaceSolution();
        }

        [TestMethod]
        public void RemoveElement_ShortTestOne() {
            int[] numbers = new int[] { 3, 2, 2, 3 };
            int actual = TestingClass.RemoveElement(numbers, 3);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveElement_ShortTestTwo() {
            int[] numbers = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int actual = TestingClass.RemoveElement(numbers, 2);
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}