using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero mayor a 0:");
            string ingreso = Console.ReadLine();
            int numero;
            Console.WriteLine();

            if (int.TryParse(ingreso, out numero))
            {
                for (int i = 0; i <= numero; i++)
                {
                    Console.WriteLine(i);
                }
            }
        
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("2)");

            Console.Write($"Ingrese un numero entero menor a {numero} y mayor a 0 :");
            string ingreso2 = Console.ReadLine();
            
            Console.WriteLine();

            if (int.TryParse(ingreso, out int numero2) && (numero2<numero))
            {
                for (int i = 0; i <= numero; i += numero2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3)");

            int indice = 0;
            do
            {
                if (int.TryParse(ingreso, out numero))
                {
                    indice++;
                    Console.WriteLine(indice);
                    
                }
            } while (indice<numero);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3.1)");

            int indice2 = 0;
            while (indice2<numero)
            {
                if(int.TryParse(ingreso, out numero))
                {
                    indice2++;
                    Console.WriteLine(indice2);

                }
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("4)");





        }

    }
}
