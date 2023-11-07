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
                int annio = pI.pedirAnnio(); 
                calculoI cI = new calculoC();

                int diasMes = cI.PedirDia(mes,annio);

                Console.WriteLine("el mes es:  " + mes + " tiene: " + diasMes + " el año es:  " + annio );

                if (calculoC.Bisiesto(annio))
                {
                    Console.WriteLine("es bisiesto");
                }
                else
                {
                    Console.WriteLine("no es bisiesto");
                }
                Console.Write("presiona 's' para continuar o 'n' para salir: ");
                a = Console.ReadLine();

            } while (a == "s") ;
        }
        
    }
}