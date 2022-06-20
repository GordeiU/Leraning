using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>ShortEncodingWordsSolution</c> Solution to the: https://leetcode.com/problems/short-encoding-of-words/
    /// </summary>
    public class ShortEncodingWordsSolution {
        private TrieTree trie;
        public ShortEncodingWordsSolution() {
            trie = new TrieTree();
        }

        public int MinimumLengthEncoding(string[] words) {
            foreach (string word in words) {
                trie.InsertWord(word);
            }

            return trie.GetEncodingLength();
        }

        private class TrieTree {
            public TrieNode Root { get; private set; }

            public TrieTree() {
                Root = new TrieNode();
            }

            public int GetEncodingLength() => Root.DepthFirstSearch();

            public void InsertWord(string word) {
                TrieNode? cur = Root;

                for (int idx = word.Length - 1; idx >= 0; idx--) {
                    if (!cur!.Children.ContainsKey(word[idx])) {
                        cur.Children[word[idx]] = new TrieNode();
                    }

                    cur = cur.Children[word[idx]];
                }
            }
        }

        private class TrieNode {
            public Dictionary<char, TrieNode> Children { get; set; }

            public TrieNode() {
                Children = new Dictionary<char, TrieNode>();
            }

            public int DepthFirstSearch() {
                if (Children.Count == 0) {
                    return 1;
                }

                int result = 0;

                foreach (KeyValuePair<char, TrieNode> pair in Children) {
                    result += pair.Value.DepthFirstSearch() + 1;
                }

                return result;
            }
        }
    }
}