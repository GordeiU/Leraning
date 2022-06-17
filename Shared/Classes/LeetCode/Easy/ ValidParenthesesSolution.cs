using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Easy {
    /// <summary>
    /// Class <c>ValidParenthesesSolution</c> Solution to the: https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class ValidParenthesesSolution {
        private static readonly IReadOnlyDictionary<char, char> MatchingParenthesis = new Dictionary<char, char> {
                {'}','{'},
                { ']', '['},
                {')', '('},
            };
        private static readonly HashSet<char> OpeningParentheses = new HashSet<char> { '{', '[', '(' };
        private Stack<char> stack;

        public ValidParenthesesSolution() {
            stack = new Stack<char>();
        }

        public bool IsValid(string brackets) {
            foreach (char bracket in brackets) {
                if (OpeningParentheses.Contains(bracket)) {
                    stack.Push(bracket);
                } else {
                    if (stack.Count == 0) {
                        return false;
                    }

                    if ((char)stack.Pop()! != MatchingParenthesis[bracket]) {
                        return false;
                    }
                }
            }

            if (stack.Count > 0) {
                return false;
            }

            return true;
        }
    }
}