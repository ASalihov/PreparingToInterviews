using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{



    public class Generics<T>
        where T : class, new()
    {
        public static void SameDataLinkedList()
        {
            var defVal = default(T);
            Node head = new Node<String>("U");
            head = new Node<String>("B", head);
            head = new Node<Char>('A', head);
            Console.WriteLine(head.ToString()); // Displays "ABC"
        }
    }
    public class Node
    {

        public Node m_next;
        public Node(Node n)
        {
            m_next = n;
        }
    }

    internal sealed class Node<T> : Node
    {
        public T m_data;

        public Node(T data)
            : this(data, null)
        {
        }
        public Node(T data, Node next)
            : base(next)
        {
            m_data = data;
        }
        public override String ToString()
        {
            return m_data.ToString() +
            ((m_next != null) ? m_next.ToString() : String.Empty);
        }
    }

    internal interface IVariance<in Tin, out Tout>
        where Tin : B
        where Tout : B
    {
        //Tout retunT(Tin s);
    }

    internal class Variance : IVariance<B, D>
    {
        private B b = new B();
        private D d = new D();

        public Variance()
        {
            b.a = 1;
            b.b = 2;
            b.c = 3;

            d.a = 10;
            d.b = 20;
            d.c = 30;
            d.d = 40;
        }
        public D retunT(D arg2)
        {
            D d = new D();
            return d;
        }
    }
}
