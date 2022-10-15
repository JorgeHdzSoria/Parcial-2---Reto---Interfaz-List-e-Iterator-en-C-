using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Reto1.uaslp.objetos.list
{
    public class ArrayListIterator : Iterator
    {

    private Arraylist arraylist;
    private int currentIndex = 0;

    public ArrayListIterator(Arraylist arraylist)
    {
        this.arraylist = arraylist;
    }

    public Boolean hasNext()
    {
        return currentIndex < arraylist.getSize();
    }

    public string next()
    {
        return arraylist.getAt(currentIndex++);
    }
}
}
