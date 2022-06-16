using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>LongestPalindromicSubstringSolution</c> Solution to the: https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public class LongestPalindromicSubstringSolution {
        private HashSet<string> memory;

        private string LongestPalindromicSubstring { get; set; }

        private int Count => LongestPalindromicSubstring.Length;

        public LongestPalindromicSubstringSolution() {
            LongestPalindromicSubstring = string.Empty;
            memory = new HashSet<string>();

            memory.Add(string.Empty);
        }

        public string LongestPalindrome(string word) {
            for (int wordLength = 1; wordLength <= word.Length; wordLength++) {
                for (int startIdx = 0; startIdx <= word.Length - wordLength; startIdx++) {
                    HasPalindrome(word.Substring(startIdx, wordLength));
                }
            }

            return LongestPalindromicSubstring;
        }

        public bool HasPalindrome(string word) {
            if (memory.Contains(word)) {
                return true;
            }

            if (word.Length == 1) {
                if (word.Length > Count) {
                    LongestPalindromicSubstring = word;
                }

                memory.Add(word);
                return true;
            }

            char prefix = word[0];
            char postfix = word[word.Length - 1];

            if (HasPalindrome(word.Substring(1, word.Length - 2)) && prefix == postfix) {
                if (word.Length > Count) {
                    LongestPalindromicSubstring = word;
                }

                memory.Add(word);
                return true;
            }

            return false;
        }
    }
}