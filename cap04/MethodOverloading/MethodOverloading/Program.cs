using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Sobrecarga de Metodos (Overloading Methods)
/// Quando dizemos que um conjunto de metodos com nomes idênticos que diferem pelo numero (ou tipo) de parametros, 
/// diz-se que este metodo esta 'sobrecarregado'
/// </summary>
namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            // Chama a versão int de Add();
            Console.WriteLine(Add(10, 10));

            // Chama a versão long de Add();
            Console.WriteLine(Add(900000000000, 900000000000));

            // Chama a versão double de Add();
            Console.WriteLine(Add(4.3, 4.4));

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        //Método Add() sobrecarregado
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static long Add(long x, long y)
        {
            return x + y;
        }


    }
}
