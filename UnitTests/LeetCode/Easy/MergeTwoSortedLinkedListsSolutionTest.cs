using Microsoft.VisualStudio.TestTools.UnitTesting;
using Learning.Shared.Classes.LeetCode.Classes;
using Learning.Shared.Classes.LeetCode.Easy;
using Learning.Shared.Helpers.LeetCode;

namespace Learning.UnitTests.LeetCode.Easy {
    [TestClass]
    public class MergeTwoSortedLinkedListsSolutionTest {
        private MergeTwoSortedLinkedListsSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new MergeTwoSortedLinkedListsSolution();
        }

        [TestMethod]
        public void MergeTwoLists_SameSizeNotEmpty() {
            int[] listOne = new int[3] { 1, 2, 3 };
            int[] listTwo = new int[3] { 1, 2, 3 };

            ListNode? firstListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listOne);
            ListNode? secondListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listTwo);

            ListNode? resultRootNode = TestingClass.MergeTwoLists(firstListRoot, secondListRoot);

            string actual = LinkedListGenerationUtility.GetStringValueOfLinkedList(resultRootNode);
            string expected = "1-1-2-2-3-3";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeTwoLists_SameSizeEmpty() {
            int[] listOne = new int[0] { };
            int[] listTwo = new int[0] { };

            ListNode? firstListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listOne);
            ListNode? secondListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listTwo);

            ListNode? resultRootNode = TestingClass.MergeTwoLists(firstListRoot, secondListRoot);

            string actual = LinkedListGenerationUtility.GetStringValueOfLinkedList(resultRootNode);
            string expected = string.Empty;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeTwoLists_FirstEmpty() {
            int[] listOne = new int[0] { };
            int[] listTwo = new int[4] { 1, 2, 3, 4 };

            ListNode? firstListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listOne);
            ListNode? secondListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listTwo);

            ListNode? resultRootNode = TestingClass.MergeTwoLists(firstListRoot, secondListRoot);

            string actual = LinkedListGenerationUtility.GetStringValueOfLinkedList(resultRootNode);
            string expected = "1-2-3-4";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeTwoLists_SecondEmpty() {
            int[] listOne = new int[4] { 1, 2, 3, 4 };
            int[] listTwo = new int[0] { };

            ListNode? firstListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listOne);
            ListNode? secondListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listTwo);

            ListNode? resultRootNode = TestingClass.MergeTwoLists(firstListRoot, secondListRoot);

            string actual = LinkedListGenerationUtility.GetStringValueOfLinkedList(resultRootNode);
            string expected = "1-2-3-4";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeTwoLists_NotEmptyDifferentSizes() {
            int[] listOne = new int[4] { 1, 4, 5, 7 };
            int[] listTwo = new int[2] { 2, 6 };

            ListNode? firstListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listOne);
            ListNode? secondListRoot = LinkedListGenerationUtility.GenerateIntLinkedListFromArray(listTwo);

            ListNode? resultRootNode = TestingClass.MergeTwoLists(firstListRoot, secondListRoot);

            string actual = LinkedListGenerationUtility.GetStringValueOfLinkedList(resultRootNode);
            string expected = "1-2-4-5-6-7";
            Assert.AreEqual(expected, actual);
        }
    }
}