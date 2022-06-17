using System.Collections.Generic;
using Learning.Shared.Classes.LeetCode.Classes;

namespace Learning.Shared.Classes.LeetCode.Hard {
    /// <summary>
    /// Class <c>BinaryTreeCamerasSolution</c> Solution to the: https://leetcode.com/problems/binary-tree-cameras/
    /// </summary>
    public class BinaryTreeCamerasSolution {
        private HashSet<TreeNode?> covered;
        private int cameraCount;

        public BinaryTreeCamerasSolution() {
            covered = new HashSet<TreeNode?>();
            covered.Add(null);
        }

        public int MinCameraCover(TreeNode root) {
            cameraCount = 0;

            DepthFirstSearch(root, null);

            return cameraCount;
        }

        private void DepthFirstSearch(TreeNode? node, TreeNode? parent) {
            if (node != null) {
                DepthFirstSearch(node.left, node);
                DepthFirstSearch(node.right, node);

                if (parent == null && !covered.Contains(node) ||
                    !covered.Contains(node.left) ||
                    !covered.Contains(node.right)) {
                        cameraCount++;
                        covered.Add(parent);
                        covered.Add(node);
                        covered.Add(node.left);
                        covered.Add(node.right);
                }
            }
        }
    }
}