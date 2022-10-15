using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Reto1.uaslp.objetos.list
{
    public class Node
    {
        public Node next;
        public Node previous;
        public string data;

        public string getData()
        {
            return data;
        }

        public Node(string data)
        {
            this.data = data;
        }

        public Node getNext()
        {
            return next;
        }

        public void setNext(Node next)
        {
            this.next = next;
        }

        public Node getPrevious()
        {
            return previous;
        }

        public void setPrevious(Node previous)
        {
            this.previous = previous;
        }

        public void setData(string data)
        {
            this.data = data;
        }
    }

}
