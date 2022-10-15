using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Reto1.uaslp.objetos.list
{
    public static class Main
    {
        public class main
        {
            public static void Main(string[] args)
            {
                LinkedList datos = new LinkedList();

                datos.addAtTail("Jorge");
                datos.addAtTail("Alberto");
                datos.addAtTail("Hernandez");
                datos.addAtTail("Soria");
                datos.addAtTail("UwU");

                datos.addAtFront("3");
                datos.addAtFront("0");
                datos.addAtFront("6");
                datos.addAtFront("8");
                datos.addAtFront("4");
                datos.addAtFront("3");

                Iterator iterator = datos.getIterator();

                while (iterator.hasNext())
                {
                    string data = iterator.next();
                    Console.WriteLine(data);
                }

                datos.addAtFront("1");
                datos.addAtFront("2");
                datos.addAtFront("3");

                datos.removeAll();


                Console.WriteLine("------------------");

                iterator = datos.getIterator();

                while (iterator.hasNext())
                {
                    string data = iterator.next();
                    Console.WriteLine(data);
                }
            }
        }
    }
}
