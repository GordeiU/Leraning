using System;
using Learning.Shared.Classes.LeetCode.Classes;

namespace Learning.Shared.Classes.LeetCode.Hard {
    /// <summary>
    /// Class <c>PrefixSuffixSearchSolution</c> Solution to the: https://leetcode.com/problems/prefix-and-suffix-search/
    /// </summary>
    public class PrefixSuffixSearchSolution {
        private CharTrieNode Root { get; set; }
        public PrefixSuffixSearchSolution(string[] words) {
            Root = new CharTrieNode(null);
            BuildTrieTree(words);
        }

        private void BuildTrieTree(string[] words) {
            CharTrieNode current;

            foreach (string word in words) {
                current = Root;

                foreach (char character in word) {
                    if (current.children.ContainsKey(character)) {
                        current = current.children[character];
                    } else {
                        CharTrieNode newNode = new CharTrieNode(character);
                        current.children.Add(character, newNode);
                        current = newNode;
                    }
                }
            }

            return;
        }

        public int F(string prefix, string suffix) {
            throw new NotFiniteNumberException();
        }
    }
}