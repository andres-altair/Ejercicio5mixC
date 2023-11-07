using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    internal class calculoC : calculoI
    {
        public static bool Bisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
        

        public int PedirDia(int mes, int año)
        {
            int dia;
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dia = 30;
            }
            else if (mes == 2)
            {
                if (Bisiesto(año))
                {
                    dia = 29;
                }
                else
                {
                    dia = 28;
                }
            }
            else
            {
                dia = 31;
            }
            return dia;
        }
    }
}
