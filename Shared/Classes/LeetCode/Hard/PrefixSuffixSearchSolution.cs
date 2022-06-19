using System;
using System.Collections.Generic;
using Learning.Shared.Classes.LeetCode.Classes;

namespace Learning.Shared.Classes.LeetCode.Hard {
    // TODO: This has to be redone as it is incomplete and inaccurate
    /// <summary>
    /// Class <c>PrefixSuffixSearchSolution</c> Solution to the: https://leetcode.com/problems/prefix-and-suffix-search/
    /// </summary>
    public class PrefixSuffixSearchSolution {
        private Dictionary<string, int> WordDictionary { get; set; }
        private CharTrieNode Root { get; set; }
        private CharTrieNode EndOfWord { get; set; }
        public PrefixSuffixSearchSolution(string[] words) {
            WordDictionary = new Dictionary<string, int>();
            Root = new CharTrieNode(null);
            EndOfWord = new CharTrieNode('@');
            BuildTrieTree(words);
        }

        private void BuildTrieTree(string[] words) {
            CharTrieNode current;

            for (int wordIdx = 0; wordIdx < words.Length; wordIdx++) {
                WordDictionary[words[wordIdx]] = wordIdx;
                current = Root;

                for (int characterIdx = 0; characterIdx <= words[wordIdx].Length; characterIdx++) {
                    if (characterIdx == words[wordIdx].Length) {
                        current.children['@'] = EndOfWord;
                        continue;
                    }


                    if (current.children.ContainsKey(words[wordIdx][characterIdx])) {
                        current = current.children[words[wordIdx][characterIdx]];
                    } else {
                        CharTrieNode newNode = new CharTrieNode(words[wordIdx][characterIdx]);
                        current.children[words[wordIdx][characterIdx]] = newNode;
                        current = newNode;
                    }
                }
            }

            return;
        }

        public int F(string prefix, string suffix) {
            CharTrieNode? prefixEndNode = DfsPrefix(Root, prefix);

            if (prefixEndNode == null) {
                return -1;
            }

            string dfsResult = DfsSuffix(prefixEndNode, suffix, 0, string.Empty);

            return 0;
        }

        private string DfsSuffix(CharTrieNode cur, string suffix, int suffixIdx, string word) {
            if (suffix.Length == suffixIdx && cur == EndOfWord) {
                return word;
            }

            string longest = string.Empty;
            string intermediate = string.Empty;

            foreach (CharTrieNode node in cur.children.Values) {
                if (node != EndOfWord &&
                    suffixIdx < suffix.Length &&
                    cur.Value == suffix[suffixIdx]) {
                        intermediate = DfsSuffix(node, suffix, ++suffixIdx, word + cur.Value);
                } else {
                    intermediate = DfsSuffix(node, suffix, 0, word + cur.Value);
                }

                if (intermediate != string.Empty &&
                    intermediate[intermediate.Length - 1] == suffix[suffix.Length - 1] &&
                    intermediate.Length > longest.Length) {
                        longest = intermediate;
                }
            }

            return longest;
        }

        private CharTrieNode? DfsPrefix(CharTrieNode cur, string prefix) {
            if (prefix.Length == 1 && cur.children.ContainsKey(prefix[0])) {
                return cur.children[prefix[0]];
            }

            if (cur.children.ContainsKey(prefix[0])) {
                return DfsPrefix(cur.children[prefix[0]], prefix.Substring(1));
            }

            return null;
        }
    }
}