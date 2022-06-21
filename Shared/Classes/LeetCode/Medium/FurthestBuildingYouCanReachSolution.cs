using System;
using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>FurthestBuildingYouCanReachSolution</c> Solution to the: https://leetcode.com/problems/furthest-building-you-can-reach/
    /// </summary>
    public class FurthestBuildingYouCanReachSolution {
        public int FurthestBuilding(int[] heights, int bricks, int ladders) {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            int gap;

            for (int idx = 0; idx < heights.Length - 1; idx++) {
                if (heights[idx] >= heights[idx + 1]) {
                    continue;
                }

                gap = heights[idx + 1] - heights[idx];
                bricks -= gap;
                queue.Enqueue(gap, -1 * gap);

                if (bricks < 0) {
                    bricks += queue.Dequeue();

                    if (ladders > 0) {
                        ladders--;
                    } else {
                        return idx;
                    }
                }
            }

            return heights.Length - 1;
        }
    }
}