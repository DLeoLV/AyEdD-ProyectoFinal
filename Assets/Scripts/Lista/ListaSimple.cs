using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaSimple : MonoBehaviour
{
    public SimpleLinkedList<int> ListInt = new SimpleLinkedList<int>();

    void Start()
    {
        Debug.Log(ListInt.PrintAllNodes());
    }

    public class SimpleLinkedList<T>
    {
        class Node
        {
            public T Value { get; set; }

            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }
        private Node Head { get; set; }
        public int length = 0;

        public void InsertAtStart(T value)
        {
            if (Head == null)
            {
                Node newNode = new Node(value);
                Head = newNode;
                length = length + 1;
            }
            else
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Head = newNode;
                length = length + 1;
            }
        }

        public void ModifyAtStart(T value)
        {
            if (Head == null)
            {
                //Console.WriteLine("No hay nodos");
            }
            else
            {
                Head.Value = value;
            }
        }
        public void ModifyAtEnd(T value)
        {
            if (Head == null)
            {
                //Console.WriteLine("No hay nodos");
            }
            else
            {
                Node last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Value = value;
            }
        }
        public void ModifyValueAtPosition(T value, int position)
        {
            if (position == 0)
            {
                ModifyAtStart(value);
            }
            else if (position == length - 1)
            {
                ModifyAtEnd(value);
            }
            else if (position >= length)
            {
                //Console.WriteLine("No se puede");
            }
            else
            {
                Node tmp = Head;
                int iterator = 0;
                while (iterator < position)
                {
                    tmp = tmp.Next;
                    iterator = iterator + 1;
                }
                tmp.Value = value;
            }
        }

        public T GetNodeAtStart()
        {
                return Head.Value;
        }
        public T GetNodeAtEnd()
        {
            Node last = Head;
            while (last.Next != null)
            {
                last = last.Next;
            }
            return last.Value;
        }
        public T GetNodeAtPosition(int position)
        {
            if (position == 0)
            {
                return GetNodeAtStart();
            }
            else if (position == length - 1)
            {
                return GetNodeAtEnd();
            }
            else
            {
                Node tmp = Head;
                int iterator = 0;
                while (iterator < position)
                {
                    tmp = tmp.Next;
                    iterator = iterator + 1;
                }
                return tmp.Value;
            }
        }

        public string PrintAllNodes()
        {
            Node tmp = Head;
            string result = "Lista: ";
            while (tmp != null)
            {
                result += tmp.Value + " -> ";
                tmp = tmp.Next;
            }
            result += "null";
            return result;
        }

        public void MostrarValores()
        {
            Debug.Log(PrintAllNodes());
        }

        public int GetLength()
        {
            return length;
        }
    }
}
