using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    public  class Operacion

    {       

       

        public static void puntoAA(Dictionary<string, string> d)
        {
            foreach (KeyValuePair<string, string> pair in d)
            {
                if (pair.Key.Contains("Juan"))
                {
                    Console.WriteLine("Encontro: " + pair.Value);
                }    
                           
            }
            
                  
        }
        public static void puntoA(Dictionary<string, string> d, String nombre)
        {
            if (d.ContainsKey(nombre))
            {
                Console.WriteLine("Encontro de llave: " + nombre + " :" + d[nombre]);
            }
            
        }
        public static void puntoB(Dictionary<string, string> d, string nombre)
        {
            String value = "";
            //devuelve el valor asociado a esa clave.
            if (d.TryGetValue(nombre, out value)){
                Console.WriteLine("Encontro de llave: " + nombre + " :" + value);

            }
            else
            {
                Console.WriteLine("no contiene la llave: "+ nombre);
            }
        }
        public static void recorrerDiccionario(Dictionary<string, string> d)
        {
            foreach (KeyValuePair<string, string> par in d) {
                Console.WriteLine("Clave = {0}, Valor = {1}", par.Key, par.Value);
            }       

        }
        public static void puntoD(Dictionary<string, string> d, String nombre, string telefono)
        {
            if (d.ContainsKey(nombre))
            {
                d[nombre] = telefono;
                Console.WriteLine("Nuevo teléfono de mariana es: "  + d[nombre]);
            }

        }


    }
}
