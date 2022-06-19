namespace Learning.Shared.Classes.LeetCode.Classes {
    public class TrieTree {
        public TrieNode Root { get; private set; }

        public TrieTree() {
            Root = new TrieNode();
        }

        public void InsertWord(string word) {
            TrieNode cur = Root;

            // foreach (var character in word) {
            //     if (!cur.children.ContainsKey(character)) {
            //         cur.children[character] = new TrieNode();
            //     }
 
            //     cur = cur.children[character];
            // }

            cur.IsEndOfWord = true;
        }
    }
}