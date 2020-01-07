using System.Collections.Generic;

namespace Stack.Library {
    public class MyStack<T>
    {
        public MyStack()
        {
            
        }
        public int Count { get; set; }

        public MyStack<T> Push(T value)
        {
            return new MyStack<T>();
        }

        public MyStack<T> Pop()
        {
            return new MyStack<T>();
        }

        public T Peek()
        {
            return default(T);
        }
    }
}