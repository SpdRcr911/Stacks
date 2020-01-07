
namespace Stacks.Library
{
    public class MyStack
    {
        private object _item;
        public MyStack(int capacity)
        {
            
        }
        public void Push(object value)
        {
            _item = value;
        }
        public object Pop()
        {
            return _item;
        }
    }
}