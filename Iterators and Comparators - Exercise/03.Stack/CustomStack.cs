﻿using System;
using System.Collections;

namespace _03.Stack
{
	public class CustomStack<T> : IEnumerable<T>
	{
        private const int InitialCapacity = 4;
        private T[] items;

        public CustomStack()
        {
            items = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;

            Count++;
        }
        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            T removeTitle = items[Count - 1];
            items[Count - 1] = default;
            Count--;
            //
            return removeTitle;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            return items[Count - 1];
        }
        private void Resize()
        {
            T[] copy = new T[items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        public void ForEach(Action<T> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                T currItem = items[i];

                action(currItem);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

