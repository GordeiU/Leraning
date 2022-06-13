using System.Collections.Generic;
using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class TriangleSolutionTest {
        private TriangleSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new TriangleSolution();
        }

        [TestMethod]
        public void MinimumTotal_SingleElement() {
            List<List<int>> numbers = new List<List<int>>() {
                new List<int>() { -10 },
            };

            int actual = TestingClass.MinimumTotal(numbers);
            int expected = -10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinimumTotal_ShortTest() {
            List<List<int>> numbers = new List<List<int>>() {
                new List<int>() { 2 },
                new List<int>() { 3, 4 },
                new List<int>() { 6, 5, 7 },
                new List<int>() { 4, 1, 8, 3 },
            };

            int actual = TestingClass.MinimumTotal(numbers);
            int expected = 11;
            Assert.AreEqual(expected, actual);
        }
    }
}