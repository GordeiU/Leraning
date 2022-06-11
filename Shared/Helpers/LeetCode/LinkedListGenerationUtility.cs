using Learning.LeetCode.Classes;

namespace Learning.Shared.Classes.Helpers.LeetCode {
    public static class LinkedListGenerationUtility {
        public static ListNode GenerateIntLinkedListFromArray(int[] dataArray) {
            ListNode root = new ListNode();

            if (dataArray.Length == 0) {
                return root;
            }

            root.val = dataArray[0];

            ListNode cur = root;

            for (int idx = 1; idx < dataArray.Length; idx++) {
                ListNode newNode = new ListNode(val: dataArray[idx]);
                cur.next = newNode;
                cur = cur.next;
            }

            return root;
        }
    }
}