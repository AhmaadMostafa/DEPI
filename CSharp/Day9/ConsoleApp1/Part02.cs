using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class Part02
        {
            #region Problem 1
            public static T[] ReverseArray<T>(T[] array)
            {
                T[] reversedArray = new T[array.Length];
                int j = 0;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    reversedArray[j] = array[i];
                    j++;
                }
                return reversedArray;
            }
            #endregion

            #region Problem 2
            public class Stack<T>
            {
                private T[] elements;
                private int count;
                private const int initialCapacity = 4;

                public Stack()
                {
                    elements = new T[initialCapacity];
                    count = 0;
                }

                public void Push(T item)
                {
                    if (count == elements.Length)
                    {
                        Array.Resize(ref elements, elements.Length * 2);
                    }
                    elements[count++] = item;
                }

                public T Pop()
                {
                    if (count == 0)
                        throw new InvalidOperationException("Stack is empty.");
                    T item = elements[--count];
                    elements[count] = default;
                    return item;
                }

                public T Peek()
                {
                    if (count == 0)
                        throw new InvalidOperationException("Stack is empty.");
                    return elements[count - 1];
                }

                public bool IsEmpty()
                {
                    return count == 0;
                }
            }
            #endregion

            #region Problem 3
            public static void Swap<T>(T[] array, int index1, int index2)
            {
                if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
                    throw new ArgumentOutOfRangeException("Indices are out of range.");

                T temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
            #endregion

            #region Problem 4
            public static T FindMax<T>(T[] array) where T : IComparable<T>
            {
                if (array == null || array.Length == 0)
                    throw new ArgumentException("Array is empty.");

                T max = array[0];
                foreach (T item in array)
                {
                    if (item.CompareTo(max) > 0)
                    {
                        max = item;
                    }
                }
                return max;
            }
            #endregion
        }
}
