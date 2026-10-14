using System;

namespace CSharpAdvanced_Task.Generics
{
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; }
        public int Count => count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= Capacity)
            {
                throw new InvalidOperationException("Error: Cannot add more elements. The list has reached its maximum capacity.");
            }

            items[count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Error: Invalid index. The index is out of the valid range or no element exists at this position.");
            }

            return items[index];
        }

        public T this[int index]
        {
            get => Get(index);
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Error: Invalid index for setting value.");
                }
                items[index] = value;
            }
        }
    }
}