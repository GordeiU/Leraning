using System;

namespace Learning.Shared.Classes.Helpers {
    public class Queue {
        private const int DefaultCapacity = 10;
        private const int MinimumGrow = 4;
        private const int ShrinkThreshold = 32;
        private const int GrowFactor = 100;
        private Object[] array;
        private int size;
        private int head;
        private int tail;

        public Queue() {
            array = new Object[DefaultCapacity];
            size = 0;
            head = 0;
            tail = 0;
        }

        public int Count => size;

        public virtual Object Peek() {
            if (size == 0) {
                throw new InvalidOperationException("InvalidOperation_EmptyStack");
            }

            return array[head];
        }

        public virtual Object Dequeue() {
            if (Count == 0)
                throw new InvalidOperationException("InvalidOperation_EmptyQueue");

            Object removed = array[head];
            array[head] = null;
            head = (head + 1) % array.Length;
            size--;
            return removed;
        }

        public virtual void Enqueue(Object obj) {
            if (size == array.Length) {
                int newCapacity = (int)((long)array.Length * (long)GrowFactor / 100);
                if (newCapacity < array.Length + MinimumGrow) {
                    newCapacity = array.Length + MinimumGrow;
                }

                SetCapacity(newCapacity);
            }

            array[tail] = obj;
            tail = (tail + 1) % array.Length;
            size++;
        }

        // PRIVATE Grows or shrinks the buffer to hold capacity objects. Capacity
        // must be >= size.
        private void SetCapacity(int capacity) {
            Object[] newArray = new Object[capacity];
            if (size > 0) {
                if (head < tail) {
                    Array.Copy(array, head, newArray, 0, size);
                } else {
                    Array.Copy(array, head, newArray, 0, array.Length - head);
                    Array.Copy(array, 0, newArray, array.Length - head, tail);
                }
            }

            array = newArray;
            head = 0;
            tail = (size == capacity) ? 0 : size;
        }
    }
}