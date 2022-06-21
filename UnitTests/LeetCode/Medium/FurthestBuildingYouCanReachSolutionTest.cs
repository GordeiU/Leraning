using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Medium {
    [TestClass]
    public class FurthestBuildingYouCanReachSolutionTest {
        private FurthestBuildingYouCanReachSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new FurthestBuildingYouCanReachSolution();
        }

        [TestMethod]
        public void FurthestBuilding_ShortOne() {
            int[] buildingHeights = new int[] {4, 2, 7, 6, 9, 14, 12 };
            int bricks = 5;
            int ladders = 1;

            int actual = TestingClass.FurthestBuilding(buildingHeights, bricks, ladders);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FurthestBuilding_ShortTwo() {
            int[] buildingHeights = new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 };
            int bricks = 10;
            int ladders = 2;

            int actual = TestingClass.FurthestBuilding(buildingHeights, bricks, ladders);
            int expected = 7;
            Assert.AreEqual(expected, actual);
        }
    }
}