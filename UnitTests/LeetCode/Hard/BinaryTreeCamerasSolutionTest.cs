using Learning.Shared.Classes.LeetCode.Classes;
using Learning.Shared.Classes.LeetCode.Hard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Hard {
    [TestClass]
    public class BinaryTreeCamerasSolutionTest {
        private BinaryTreeCamerasSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new BinaryTreeCamerasSolution();
        }

        [TestMethod]
        public void MinCameraCover_OneNode() {
            TreeNode root = new TreeNode();

            int actual = TestingClass.MinCameraCover(root);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinCameraCover_RootTwoChildren() {
            TreeNode root = new TreeNode();
            TreeNode left = new TreeNode();
            TreeNode leftLeft = new TreeNode();
            TreeNode leftRight = new TreeNode();

            root.left = left;
            left.right = leftRight;
            left.left = leftLeft;

            int actual = TestingClass.MinCameraCover(root);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinCameraCover_RootFiveLeftDeep() {
            TreeNode root = new TreeNode();
            TreeNode cur = root;

            for (int i = 0; i < 4; i++) {
                TreeNode newNode = new TreeNode();
                cur.left = newNode;
                cur = newNode;
            }

            int actual = TestingClass.MinCameraCover(root);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}