using Microsoft.VisualStudio.TestTools.UnitTesting;
using Node = Learning.Shared.Classes.Nodes.SingleLinkedListNode;

namespace Learning.UnitTests.LinkedList {
    [TestClass]
    public class SingleLinkedListTest {
        private readonly int[] Elements = new int[4] { -1, 0, 1, 2 };
        private Node RootNode { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            RootNode = new Node(Elements[0]);
            Node cur = RootNode;

            for (int idx = 1; idx < Elements.Length; idx++) {
                cur.Next = new Node(Elements[idx]);
                cur = cur.Next;
            }
        }

        [TestMethod]
        public void GetTraverseString_CorrectnessTest() {
            string actual = RootNode.GetTraverseString();
            string expected = "-1 -> 0 -> 1 -> 2";
            Assert.AreEqual(expected, actual, ignoreCase: true);
        }

        [TestMethod]
        public void Find_ExistingElement() {
            Assert.IsTrue(RootNode.Find(2));
        }

        [TestMethod]
        public void Find_NonExistingElement() {
            Assert.IsFalse(RootNode.Find(3));
        }
    }
}