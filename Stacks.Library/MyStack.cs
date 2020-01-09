using System.Collections.Generic;

namespace Stack.Library {
    public class MyStack<T>
    {
        private IList<T> _items;
        public MyStack()
        {
            _items = new List<T>();
        }
        private MyStack(IList<T> items)
        {
            _items = items;
        }
        public int Count { get => _items.Count; }

        public MyStack<T> Push(T value)
        {
            var newItems = new List<T>(_items);
            newItems.Add(value);
            return new MyStack<T>(newItems);
        }

        public MyStack<T> Pop()
        {
            var newItems = new List<T>(_items);
            newItems.RemoveAt(_items.Count-1);
            return new MyStack<T>(newItems);
        }

        public T Peek()
        {
            return _items[_items.Count - 1];
        }
    }
}