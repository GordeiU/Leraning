using System;

namespace Learning.Shared.Classes.Helpers {
    public class Stack {
        private const int DefaultCapacity = 10;
        private Object[] array;
        private int size;

        public Stack() {
            array = new Object[DefaultCapacity];
            size = 0;
        }

        public int Count => size;

        public virtual Object Peek() {
            if (size == 0) {
                throw new InvalidOperationException("InvalidOperation_EmptyStack");
            }

            return array[size - 1];
        }

        public virtual Object Pop() {
            if (size == 0) {
                throw new InvalidOperationException("InvalidOperation_EmptyStack");
            }

            Object obj = array[--size];
            array[size] = null; // Free memory quicker.
            return obj;
        }

        public virtual void Push(Object obj) {
            if (size == array.Length) {
                Object[] newArray = new Object[2 * array.Length];
                Array.Copy(array, 0, newArray, 0, size);
                array = newArray;
            }

            array[size++] = obj;
        }
    }
}