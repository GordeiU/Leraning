using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Classes {
    class CharTrieNode {
        public char? Value { get; private set; }

        public Dictionary<char, CharTrieNode> children;

        public CharTrieNode(char? val) {
            Value = val;
            children = new Dictionary<char, CharTrieNode>();
        }
    }
}