using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_y_sus_métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Por favor, ingresa tu nombre y presiona Enter.");
            nombre = Console.ReadLine();
            

            
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.Trim());
            Console.WriteLine(nombre.Substring(4));

            Console.ReadLine();
            

        }
         
        

        }






    
}
