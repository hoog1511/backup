using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3Opdrachten
{
    //zie Blackboard voor opdrachten uitleg
    //We kunnen nog op een andere manier een stack maken. Dit doen we class Node. Iedere node verwijst naar de volgend node en bevat een waarde. 
    //Een node is een inner-class van LinkStack.Inner classes vormen een uitzondering op de regel dat instantie variabelen private moeten zijn.Omdat de class Node private is en nergens gebruikt kan worden behalve in LinkStack zelf.
    //Maak een stack op basis van class Node. Noem deze stack LinkStack.

    public class LinkStack<T> : IStack<T>
    {
        private class Node
        {
            public T value;
            public Node next;
        }
        private Node top;

        public int Count
        {
            get
            {
                int count = 0;
                if (top == null)
                {
                    return count;
                }

                Node current = top;
                while (current != null)
                {
                    count++;
                    current = current.next;
                }

                return count;
            }
        }

        public int CountEven
        {
            get
            {
                int count = 0;
                if (top == null)
                {
                    return count;
                }

                Node current = top;
                while (current != null)
                {
                    if (Convert.ToInt32(current.value) % 2 == 0)
                    {
                        count++;
                    }

                    current = current.next;
                }

                return count;
            }
        }

        public void Push(T val)
        {
            top = new Node() { value = val, next = top };
        }

        public T Pop()
        {
            T toReturn = top.value;
            top = top.next;
            return toReturn;
        }

        public T Peek()
        {
            return top.value;
        }

        public string Print()
        {
            if (top == null)
            {
                return null;
            }


            Node current = top;
            string returVal = "";
            while (current != null)
            {
                returVal += current.value;
                if (current.next != null)
                {
                    returVal += ",";
                }
                current = current.next;
            }

            return returVal;
        }
    }


}
