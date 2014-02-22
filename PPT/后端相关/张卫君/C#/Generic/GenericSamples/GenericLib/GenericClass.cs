using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLib
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _next;

        public Node(T data)
            : this(data, null)
        {

        }

        public Node(T data, Node<T> next)
        {
            _data = data;
            _next = next;
        }

        public override string ToString()
        {
            return _data.ToString() + _next ?? _next.ToString();
        }
    }

    public class IntNode : Node<int>
    {
        public IntNode(int data)
            : base(data)
        { 
        }

        public IntNode(int data, IntNode next)
            : base(data, next)
        { 
        }
    }


}
