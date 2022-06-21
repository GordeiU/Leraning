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

                if (ladders == 0 && bricks < gap) {
                    return idx;
                }

                if (gap <= bricks) {
                    bricks -= gap;
                    queue.Enqueue(gap, gap);
                    continue;
                }

                if (queue.Count > 0) {
                    int biggestGapInsideQueue = queue.Dequeue();

                    if (biggestGapInsideQueue > gap) {
                        idx--;
                        bricks += biggestGapInsideQueue;
                    }
                }
            }

            return heights.Length - 1;
        }
    }
}