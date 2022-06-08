using Learning.Shared.Classes.Helpers;

namespace Learning.Shared.Classes.LeetCode.Easy {
    public class SolutionIsPalindromeNumber {
        private Stack stack;
        private Queue queue;
        private int count;

        public SolutionIsPalindromeNumber() {
            stack= new Stack();
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
                int last = (int)stack.Pop();
                int first = (int)queue.Dequeue();

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