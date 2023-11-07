using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    /// <summary>
    /// interfaz encargada de pedir el año y mes en formato numero
    /// 071123-amd
    /// </summary>
    internal interface peticionI
    {
        /// <summary>
        /// metodo pide que el mes
        /// 071123-amd
        /// </summary>
        /// <returns> int </returns>
        /// <exception cref="NotImplementedException"></exception>
        public int pedirMes();
        /// <summary>
        /// metodo que pide le año
        /// 071123-amd
        /// </summary>
        /// <returns> int </returns>
        public int pedirAnnio();

    }
}
