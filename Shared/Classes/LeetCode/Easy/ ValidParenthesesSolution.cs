using System.Collections.Generic;
using Learning.Shared.Classes.Helpers;

namespace Learning.Shared.Classes.LeetCode.Easy {
    public class ValidParenthesesSolution {
        private static readonly IReadOnlyDictionary<char, char> MatchingParenthesis = new Dictionary<char, char> {
                {'{', '}'},
                {'[', ']'},
                {'(', ')'},
            };
        private Stack stack;

        public ValidParenthesesSolution() {
            stack = new Stack();
        }

        public static IReadOnlyDictionary<char, char> MatchingParenthesis1 => MatchingParenthesis;

        public bool IsValid(string s) {
            return true;
        }
    }
}