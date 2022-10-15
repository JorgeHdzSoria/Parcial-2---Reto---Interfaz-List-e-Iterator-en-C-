using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parcial2_Reto1.uaslp.objetos.list
{
    public class LinkedList
    {
    private Node head;
    private Node tail;
    private int size;

        public void addAtTail(string data)
    {
        Node node = new Node(data);
        node.setPrevious(tail);
        tail = node;

        if (head == null)
        {
            head = node;
        }
        else
        {
            node.getPrevious().setNext(node);
        }
        size++;
    }
    public void addAtFront(string data)
    {
        Node node = new Node(data);
        node.setNext(head);
        head = node;

        if (tail == null)
        {
            tail = node;
        }
        else
        {
            node.getNext().setPrevious(node);
        }
        size++;
    }

    public int getSize()
    {
        return size;
    }

    public Boolean remove(int indexToRemove)
    {

        if (indexToRemove < 0 || indexToRemove >= size)
        {
            return false;
        }
        if (size == 1)
        {
            head = null;
            tail = null;
            size = 0;
        }
        else if (indexToRemove == 0)
        {
            head = head.getNext();
            head.setPrevious(null);
        }
        else if (indexToRemove == size - 1)
        {
            tail = tail.getPrevious();
            tail.setNext(null);
        }
        else
        {
            Node iteratorNode = findNodeByIndex(indexToRemove);
            iteratorNode.getPrevious().setNext(iteratorNode.getNext());
            iteratorNode.getNext().setPrevious(iteratorNode.getPrevious());

        }
        size--;
        return true;
    }

    public void removeAll()
    {
        head = null;
        tail = null;
        size = 0;
    }
    public void removeAllWithValue(string value)
    {
        Node current = head;

        while (current != null)
        {
            if (current.data.Equals(value))
            {
                if (current == head)
                {
                    head = current.next;
                    if (head == null)
                    {
                        tail = null;
                    }
                    else
                    {
                        head.previous = null;
                    }
                }
                else
                {
                    current.previous.next = current.next;
                    if (current == tail)
                    {
                        tail = current.previous;
                    }
                    else
                    {
                        current.next.previous = current.previous;
                    }
                }
            }
            current = current.next;
        }
    }

    public Boolean setAt(int index, string data)
    {
        if (index < 0 || index >= size)
        {
            return false;
        }
        Node node = findNodeByIndex(index);
        node.setData(data);
        return true;
    }

    public string getAt(int index)
    {
        if (index < 0 || index >= size)
        {
            return null;
        }
        Node node = findNodeByIndex(index);
        return node.getData();
    }

    private Node findNodeByIndex(int index)
    {
        Node iteratorNode = head;
        int indexIteratorNode = 0;

        while (indexIteratorNode < index)
        {
            iteratorNode = iteratorNode.getNext();
            indexIteratorNode++;
        }
        return iteratorNode;
    }

    public LinkedListIterator getIterator()
    {
        return new LinkedListIterator(head);
    }
    }
}
