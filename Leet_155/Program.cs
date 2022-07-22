using System;
using System.Collections;

namespace Leet_155
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(2147483646);
            minStack.Push(2147483646);
            minStack.Push(2147483647);
            var ret = minStack.Top();
            minStack.Pop();
            // ret = minStack.Top();
            ret = minStack.GetMin();
            minStack.Pop();
            ret = minStack.GetMin();
            minStack.Pop();
            minStack.Push(2147483647);
            ret = minStack.Top();
            ret = minStack.GetMin();
            minStack.Push(-2147483648);
            ret = minStack.Top();
            ret = minStack.GetMin();
            minStack.Pop();
            minStack.GetMin();
        }
    }
    /// <summary>
    /// 这个栈里面有两个栈，一个维护自身，一个维护栈中最小值   ???  怎么只用一个栈呢，我们用一个变量保存最小元素，然后
    /// </summary>
    //public class MinStack
    //{
    //    private Stack _own;
    //    private Stack _minStack;
    //    public MinStack()
    //    {
    //        _own = new Stack();
    //        _minStack = new Stack();
    //    }

    //    public void Push(int val)
    //    {
    //        _own.Push(val);
    //        if (_minStack.Count == 0)
    //        {
    //            _minStack.Push(val);
    //        }
    //        else
    //        {
    //            _minStack.Push(Math.Min(val, (int)_minStack.Peek()));
    //        }
    //    }

    //    public void Pop()
    //    {
    //        _own.Pop();
    //        _minStack.Pop();
    //    }

    //    public int Top()
    //    {
    //        return (int)_own.Peek();
    //    }

    //    public int GetMin()
    //    {
    //        return (int)_minStack.Peek();
    //    }
    //}


    public class MinStack
    {
        private Stack _own;
        int min;
        public MinStack()
        {
            _own = new Stack();
        }

        public void Push(int val)
        {
            if (_own.Count == 0)
            {
                min = val;
                _own.Push(val);
            }
            else
            {
                if (val <= min)
                {
                    _own.Push(min);
                    min = val;
                }
                _own.Push(val);
            }
        }

        public void Pop()
        {
            var topValue = _own.Pop();
            if((int)topValue == min && _own.Count != 0)
            {
                min = (int)_own.Pop();
            }
        }

        public int Top()
        {
            return (int)_own.Peek();
        }

        public int GetMin()
        {
            return min;
        }
    }
}
