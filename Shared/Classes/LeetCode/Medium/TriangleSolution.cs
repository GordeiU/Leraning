using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>TriangleSolution</c> Solution to the: https://leetcode.com/problems/triangle/
    /// </summary>
    public class TriangleSolution {
        public int MinimumTotal(List<List<int>> triangle) {
            for (int layerIdx = triangle.Count - 1; layerIdx > 0; layerIdx--) {
                for (int bottomIdx = 0; bottomIdx < triangle[layerIdx].Count - 1; bottomIdx++) {
                    if (triangle[layerIdx][bottomIdx] <= triangle[layerIdx][bottomIdx + 1]) {
                        triangle[layerIdx - 1][bottomIdx] += triangle[layerIdx][bottomIdx];
                    } else {
                        triangle[layerIdx - 1][bottomIdx] += triangle[layerIdx][bottomIdx + 1];
                    }
                }
            }

            return triangle[0][0];
        }
    }
}