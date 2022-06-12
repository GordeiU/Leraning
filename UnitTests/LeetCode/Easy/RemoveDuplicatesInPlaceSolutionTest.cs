using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class RemoveDuplicatesInPlaceSolutionTest {
        private RemoveDuplicatesInPlaceSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new RemoveDuplicatesInPlaceSolution();
        }

        [TestMethod]
        public void RemoveDuplicates_ShortTestOne() {
            int[] numbers = new int[] { 1, 1, 2 };
            int actual = TestingClass.RemoveDuplicates(numbers);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveDuplicates_ShortTestTwo() {
            int[] numbers = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int actual = TestingClass.RemoveDuplicates(numbers);
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}