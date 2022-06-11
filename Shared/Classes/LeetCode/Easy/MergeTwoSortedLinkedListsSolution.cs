using Learning.Shared.Classes.LeetCode.Classes;

namespace Learning.Shared.Classes.LeetCode.Easy {
    public class MergeTwoSortedLinkedListsSolution {
        public ListNode? MergeTwoLists(ListNode? firstListCurrent, ListNode? secondListCurrent) {
            ListNode? root;

            if (firstListCurrent == null && secondListCurrent == null) {
                root = null;
            } else if (firstListCurrent == null) {
                root = secondListCurrent;
                secondListCurrent = secondListCurrent!.next;
            } else if (secondListCurrent == null) {
                root = firstListCurrent;
                firstListCurrent = firstListCurrent!.next;
            } else if (firstListCurrent!.val <= secondListCurrent!.val) {
                root = firstListCurrent;
                firstListCurrent = firstListCurrent.next;
            } else {
                root = secondListCurrent;
                secondListCurrent = secondListCurrent!.next;
            }

            ListNode? cur = root;

            while (firstListCurrent != null || secondListCurrent != null) {
                if (firstListCurrent == null) {
                    cur!.next = secondListCurrent;
                    secondListCurrent = secondListCurrent!.next;
                } else if (secondListCurrent == null) {
                    cur!.next = firstListCurrent;
                    firstListCurrent = firstListCurrent!.next;
                } else if (firstListCurrent.val <= secondListCurrent.val) {
                    cur!.next = firstListCurrent;
                    firstListCurrent = firstListCurrent.next;
                } else {
                    cur!.next = secondListCurrent;
                    secondListCurrent = secondListCurrent.next;
                }

                cur = cur.next;
            }

            return root;
        }
    }
}