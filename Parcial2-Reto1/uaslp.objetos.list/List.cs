using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Reto1.uaslp.objetos.list
{
        public interface List
        {
            void addAtTail(String data);
            void addAtFront(String data);
            Boolean remove(int index);
            void removeAll();
            Boolean setAt(int index, String data);
            String getAt(int index);
            void removeAllWithValue(String data);
            int getSize();
            Iterator getIterator();
        }

}
