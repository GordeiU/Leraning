using System;

namespace Learning.Shared.Classes.Helpers {
    public class Stack<T> {
        private const int DefaultCapacity = 10;
        private T?[] array;
        private int size;

        public Stack() {
            array = new T[DefaultCapacity];
            size = 0;
        }

        public int Count => size;

        public virtual Object? Peek() {
            if (size == 0) {
                return null;;
            }

            return array[size - 1];
        }

        public bool IsEmpty => size == 0;

        public virtual T? Pop() {
            if (size == 0) {
                throw new InvalidOperationException("InvalidOperation_EmptyStack");
            }

            T? obj = array[--size];
            array[size] = default(T); // Free memory quicker.
            return obj;
        }

        public virtual void Push(T obj) {
            if (size == array.Length) {
                T[] newArray = new T[2 * array.Length];
                Array.Copy(array, 0, newArray, 0, size);
                array = newArray;
            }

            array[size++] = obj;
        }
    }
}