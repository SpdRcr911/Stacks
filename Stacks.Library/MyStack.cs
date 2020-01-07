using System;
namespace Stacks.Library
{
    public class MyStack<T>
    {
        private T [] _items;
        private int _currentIndex;
        public MyStack(int capacity)
        {
            _items = new T[capacity];
            _currentIndex = 0;
        }
        public void Push(T value)
        {
            if (_currentIndex == _items.Length)
                throw new Exception();
            if (value == null)
                throw new ArgumentNullException();

            _items[_currentIndex++] = value;
        }
        public T Pop()
        {
            if (_currentIndex == 0)
                return default(T);
            return _items[--_currentIndex];
        }
    }
}