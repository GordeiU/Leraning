using System;

namespace Learning.Shared.Classes.LeetCode.Easy {
    /// <summary>
    /// Class <c>ImplementFindStrSolution</c> Solution to the: https://leetcode.com/problems/implement-strstr/
    /// </summary>
    public class ImplementFindStrSolution {
        public int StrStr(string searchString, string subString) {
            if (subString == string.Empty) {
                return 0;
            }

            int intermediateIdx = 0;
            int intermediateSubstringIdx = 0;

            for (int idx = 0; idx < searchString.Length; idx++) {
                if (searchString[idx] == subString[intermediateSubstringIdx]) {
                    intermediateIdx = idx;

                    while (searchString[intermediateIdx] == subString[intermediateSubstringIdx]) {
                        if (intermediateIdx == searchString.Length) {
                            return -1;
                        }

                        if (intermediateSubstringIdx +  1 == subString.Length) {
                            return idx;
                        }

                        intermediateIdx++;
                        intermediateSubstringIdx++;
                    }

                    idx = intermediateIdx;
                    intermediateSubstringIdx = 0;
                }
            }

            return -1;
        }
    }
}