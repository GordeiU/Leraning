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
    }
}