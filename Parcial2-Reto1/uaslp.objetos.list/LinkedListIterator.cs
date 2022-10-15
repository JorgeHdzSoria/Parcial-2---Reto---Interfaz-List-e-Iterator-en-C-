using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parcial2_Reto1.uaslp.objetos.list
{
    public class LinkedListIterator : Iterator
    {
    private Node current;


    public LinkedListIterator(Node head)
    {
        this.current = head;
    }

    public Boolean hasNext()
    {
        return current != null;
    }
    public string next()
    {
        string data = current.data;
        current = current.next;
        return data;
    }
}
}
