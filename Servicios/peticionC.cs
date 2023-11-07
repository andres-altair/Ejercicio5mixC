using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    internal class peticionC : peticionI
    {
        public int pedirAnnio()
        {
            Console.WriteLine("escribe un año: ");
            int annio = int.Parse(Console.ReadLine());
            return annio;
        }

        public int pedirMes()
        {
            Console.WriteLine("escribe un mes: ");
            int mes = int.Parse(Console.ReadLine());
            return mes;
        }
    }
}
