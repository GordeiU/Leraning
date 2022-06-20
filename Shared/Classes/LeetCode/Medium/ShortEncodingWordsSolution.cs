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
            for (int idx = 0; idx < words.Length; idx++) {
                trie.InsertWord(words[idx], idx);
            }

            trie.ReWeightTrie();

            return trie.GetEncodingLength();
        }

        private class TrieTree {
            public TrieNode Root { get; private set; }

            public TrieTree() {
                Root = new TrieNode();
            }

            public int GetEncodingLength() => Root.DepthFirstSearch();

            public void ReWeightTrie() {
                Root.ReWeightNode();
            }

            public void InsertWord(string word, int wordIdx) {
                TrieNode? cur = Root;

                for (int idx = word.Length - 1; idx >= 0; idx--) {
                    if (cur!.Children[word[idx] - 'a'] == null) {
                        cur.Children[word[idx] - 'a'] = new TrieNode();
                        cur.IncrementChildrenCount();
                    }

                    cur = cur.Children[word[idx] - 'a'];
                }
            }
        }

        private class TrieNode {
            private int weight;
            private int ChildrenCount { get; set; }
            public TrieNode[] Children { get; set; }

            public TrieNode() {
                weight = 1;
                Children = new TrieNode[26];
                ChildrenCount = 0;
            }

            public void IncrementChildrenCount() {
                ChildrenCount++;
            }

            public int ReWeightNode() {
                if (ChildrenCount == 0) {
                    weight = 1;
                } else {
                    weight = 0;

                    foreach (TrieNode node in Children) {
                        if (node != null) {
                            weight += node.ReWeightNode();
                        }
                    }
                }

                return weight;
            }

            public int DepthFirstSearch() {
                if (ChildrenCount == 0) {
                    return weight;
                }

                int result = 0;

                foreach (TrieNode node in Children) {
                    if (node != null) {
                        result += node.DepthFirstSearch();
                    }
                }

                return result + weight;
            }
        }
    }
}