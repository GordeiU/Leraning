using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Classes {
    public class TrieNode {
        public char Value { get; private set; }
        public TrieNode[] children;
        public bool IsEndOfWord { get; set; }

        public TrieNode(bool isEndOfWord = false) {
            children = new TrieNode[26];
            IsEndOfWord = isEndOfWord;
        }
    }
}