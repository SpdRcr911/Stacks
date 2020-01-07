
namespace Stacks.Library
{
    public class MyStack
    {
        private object [] _items;
        private int _currentIndex;
        public MyStack(int capacity)
        {
            _items = new object[capacity];
            _currentIndex = 0;
        }
        public void Push(object value)
        {
            _items[_currentIndex++] = value;
        }
        public object Pop()
        {
            if (_currentIndex == 0)
                return null;
            return _items[--_currentIndex];
        }
    }
}