namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>LongestPalindromicSubstringSolution</c> Solution to the: https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public class LongestPalindromicSubstringSolution {
        private string LongestPalindromicSubstring { get; set; }

        private int Count => LongestPalindromicSubstring.Length;

        public LongestPalindromicSubstringSolution() {
            LongestPalindromicSubstring = string.Empty;
        }

        public string LongestPalindrome(string word) {
            int left;
            int right;

            for (int idx = 0; idx < word.Length; idx++) {
                left = idx;
                right = idx;

                while (left >= 0 && right < word.Length && word[left] == word[right]) {
                    if (right - left + 1 > Count) {
                        LongestPalindromicSubstring = word.Substring(left, right - left + 1);
                    }

                    left--;
                    right++;
                }

                left = idx;
                right = idx + 1;

                while (left >= 0 && right < word.Length && word[left] == word[right]) {
                    if (right - left + 1 > Count) {
                        LongestPalindromicSubstring = word.Substring(left, right - left + 1);
                    }

                    left--;
                    right++;
                }
            }

            return LongestPalindromicSubstring;
        }
    }
}