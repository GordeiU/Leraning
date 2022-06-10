using System.Linq;
using Learning.Shared.Classes.LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class TwoSumSolutionTest {
        private readonly int[] Numbers = new int[4] { 1, 2, 3, 4 };
        private TwoSumSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new TwoSumSolution();
        }

        [TestMethod]
        public void FindIfTwoComplementsExist_ComplementsExist() {
            int[] actual = TestingClass.FindIfTwoComplementsExist(Numbers, 7);
            int[] expected = new int[] { 2, 3 };

            Assert.IsTrue(Enumerable.SequenceEqual(actual, expected));
        }

        [TestMethod]
        public void FindIfTwoComplementsExist_ComplementsDontExist() {
            int[] actual = TestingClass.FindIfTwoComplementsExist(Numbers, 8);
            int[] expected = new int[] { -1, -1 };

            Assert.IsTrue(Enumerable.SequenceEqual(actual, expected));
        }
    }
}