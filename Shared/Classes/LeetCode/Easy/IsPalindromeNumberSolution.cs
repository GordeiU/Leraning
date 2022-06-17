using Learning.Shared.Classes.Helpers;

namespace Learning.Shared.Classes.LeetCode.Easy {
    /// <summary>
    /// Class <c>IsPalindromeNumberSolution</c> Solution to the: https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class IsPalindromeNumberSolution {
        private Stack<int> stack;
        private Queue queue;
        private int count;

        public IsPalindromeNumberSolution() {
            stack= new Stack<int>();
            queue = new Queue();
            count = 0;
        }

        public bool IsPalindrome(int x) {
            if (x < 0) {
                return false;
            }

            DecomposeNumber(x);

            return IsPalindromeCore();
        }

        private bool IsPalindromeCore() {
            int checkCount = count / 2;

            while (checkCount > 0) {
                int last = (int)stack.Pop()!;
                int first = (int)queue.Dequeue()!;

                if (last != first) {
                    return false;
                }

                checkCount--;
            }

            return true;
        }

        private void DecomposeNumber(int number) {
            while (number > 0) {
                int last = number % 10;

                stack.Push(last);
                queue.Enqueue(last);

                number /= 10;
                count++;
            }
        }
    }
}