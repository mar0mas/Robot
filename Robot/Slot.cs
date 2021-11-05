using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Slot
    {
        List<string> brazo1 = new List<string>();
        List<string> brazo2 = new List<string>();
        
        
        public void Entradas()
        {
            
            string sn = "s";
            int dato1 = 0, dato2 = 0;
            int posicion1, posicion2;
            //Ciclo que se encarga a llenar los Brazos con sus respectivas acciones
            while(sn == "s" || sn == "S")
            {

                for (; ;)
                {
                    Console.WriteLine("Opciones del primer Brazo \n");
                    Console.WriteLine("Opcion 1: tallar \nOpcion 2: soldar \nOpcion 3: medir \nOpcion 4: reposo");
                    dato1 = Convert.ToInt32(Console.ReadLine());
                    brazo1.Add(Acciones(dato1));
                    Console.WriteLine("Opciones del segundo Brazo");
                    Console.WriteLine("Opcion 1: tallar \nOpcion 2: soldar \nOpcion 3: medir \nOpcion 4: reposo");
                    dato2 = Convert.ToInt32(Console.ReadLine());
                    brazo2.Add(Acciones(dato2));
                    break;
                }
                Console.WriteLine("\n\nDesea agregar otro dato? \npresione 's' para si, si no cualquier otra letra");
                sn = Console.ReadLine();
            }
            //Imprime las acciones de cada slot para poder visualizarlas
            Console.WriteLine("Brazo 1\n");
            for(int i = 0; i < brazo1.Count; i++)
            {
                Console.WriteLine(i + " - " + brazo1[i]);
            }
            Console.WriteLine("Brazo 2\n");
            for (int j = 0; j < brazo2.Count; j++)
            {
                Console.WriteLine(j + " - " + brazo2[j]);
            }
            //Intercambia acciones entre Slots
            Console.WriteLine("\n\nSeleccione la posicion del brazo 1 que quiere intercambiar por la del brazo 2 ");
            posicion1 = Convert.ToInt32(Console.ReadLine());
            posicion2 = Convert.ToInt32(Console.ReadLine());

            string temp = brazo1[posicion1];
            string temp2 = brazo2[posicion2];
            brazo2[posicion2] = temp;
            brazo1[posicion1] = temp2;

            Console.WriteLine("\n\nBrazo 1");
            for (int i = 0; i < brazo1.Count; i++)
            {
                Console.WriteLine(i + " - " + brazo1[i]);
            }

            Console.WriteLine("\n\nBrazo 2");
            for (int j = 0; j < brazo2.Count; j++)
            {
                Console.WriteLine(j + " - " + brazo2[j]);
            }


        }

        public string Acciones(int op)
        {
            string res = "";
            if (op == 1)
            {
                return res = "tallar";
            }
            else if (op == 2)
            {
                return res = "soldar";
            }
            else if (op == 3)
            {
                return res = "medir";
            }
            else if (op == 4)
            {
                return res = "reposo";
            }
            else
            {
                Console.WriteLine("Hay un error");
            }
            return res;
                
        }

    }
}
