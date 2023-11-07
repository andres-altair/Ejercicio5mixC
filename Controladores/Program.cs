using Ejercicio5mixC;
using Ejercicio5mixC.Servicios;

namespace Ejercicio5mixC
{   /// <summary>
    /// es la clase principal de la aplicacion
    /// 071123-amd
    /// </summary>
    class program
      
    {
        /// <summary>
        /// metodo principal
        /// 071123-amd
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            string a;

            do
            {
                peticionI pI = new peticionC();
                int mes = pI.pedirMes();
                int annio = pI.pedirAnyo(); 
                calculoI cI = new calculoC();

                int diasdelMes = cI.PedirDia(mes,annio);

                Console.WriteLine("el mes es:  " + mes + " tiene: " + diasdelMes + " el año es:  " + annio );

                if (calculoC.Bisiesto(annio))
                {
                    Console.WriteLine("Es bisiesto");
                }
                else
                {
                    Console.WriteLine("No es bisiesto");
                }
                Console.Write("Presiona 's' para continuar o 'n' para salir: ");
                a = Console.ReadLine();

            } while (a == "s") ;
        }
        
    }
}