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

        public static string GetStringValueOfLinkedList(ListNode? cur) {
            string result = string.Empty;

            while (cur != null) {
                if (cur.next != null) {
                    result += $"{cur.val}-";
                } else {
                    result += cur.val.ToString();
                }

                cur = cur.next;
            }

            return result;
        }
    }
}