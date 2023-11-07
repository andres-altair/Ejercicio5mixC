using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    internal class peticionC : peticionI
    {
        public int pedirAnyo()
        {
            Console.WriteLine("Escribe un Año: ");
            int anyo = int.Parse(Console.ReadLine());
            return anyo;
        }

        public int pedirMes()
        {
            Console.WriteLine("Escribe un Mes: ");
            int mes = int.Parse(Console.ReadLine());
            return mes;
        }
    }
}
