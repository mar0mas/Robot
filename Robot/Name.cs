using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    
    class Name
    {
        public string name;
        public string date = DateTime.Now.ToString("dd-MM-yyyy hh:mm");
        public Name(string nombre)
        {
            this.name = nombre;
        }
        public void GetName()
        {
            Console.WriteLine("who am I " + name + " : " + date);
        }

    }
}
