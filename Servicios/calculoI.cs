using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    /// <summary>
    /// interfaz encargada de ejecutar el cierre y contuacion del programa
    /// y ver si es bisiesto o no
    /// 071123-amd
    /// </summary>
    internal interface calculoI 
    {
        /// <summary>
        /// metodo que dice cuantos dias tiene el mes
        /// 071123-amd
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="año"></param>
        /// <returns> int </returns>
        public int PedirDia(int mes, int año);
    
    }
}
