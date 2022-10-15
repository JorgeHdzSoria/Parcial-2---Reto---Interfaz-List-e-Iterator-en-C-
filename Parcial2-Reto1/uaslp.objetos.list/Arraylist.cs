using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Reto1.uaslp.objetos.list
{
    public class Arraylist{ 
    private string[] data;
    private int size;

    public Arraylist()
    {
        data = new string[2];

    }

    public void addAtTail(string data)
    {
        if (size == this.data.Length)
        {
            increaseArraySize();
        }

        this.data[size] = data;
        size++;
    }

    private void increaseArraySize()
    {
        string[] newArray = new string[this.data.Length * 2];

            for (int i = 0; i < data.Length; i++)
            {
                newArray[i] = data[i];
            }

            data = newArray;
    }

    public void addAtFront(string data)
    {
        if (size == this.data.Length)
        {
            increaseArraySize();
        }

        for (int i = size; i > 0; i--)
        {
            this.data[i] = this.data[i - 1];
        }
        this.data[0] = data;
        size++;
    }

    public Boolean remove(int indexToRemove)
    {
        if (indexToRemove < 0 || indexToRemove >= size)
        {
            return false;
        }

        for (int i = indexToRemove; i < size - 1; i++)
        {
            this.data[i] = this.data[i + 1];
        }
        size--;
        this.data[size] = null;

        return true;
    }

    public void removeAll()
    {
        for (int i = 0; i < size; i++)
        {
            this.data[i] = null;
        }

        size = 0;
    }

    public Boolean setAt(int index, string data)
    {
        if (index < 0 || index >= size)
        {
            return false;
        }

        this.data[index] = data;

        return true;
    }

    public string getAt(int index)
    {
        if (index < 0 || index >= size)
        {
            return null;
        }

        return this.data[index];
    }

    public void removeAllWithValue(string value)
    {
        string[] newArray = new string[data.Length];
        int count = 0;

        for (int i = 0; i < size; i++)
        {
            if (!data[i].Equals(value))
            {
                newArray[count++] = data[i];
            }
        }
        data = newArray;
        size = count;
    }

    public int getSize()
    {
        return size;
    }


    public ArrayListIterator getIterator()
    {
        return new ArrayListIterator(this);
    }

}

}
