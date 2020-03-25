using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");
            //alternativa al punto a 
            //Operacion.puntoAA(values);
            //punto a
            Operacion.puntoA(values, "Juan");
            //punto b
            Operacion.puntoB(values, "Pedro");
            //punto c
            Operacion.recorrerDiccionario(values);
            //punto d
            Operacion.puntoD(values, "Mariana", "58251425");
            


            Console.ReadKey();
          

        }
    }
}
