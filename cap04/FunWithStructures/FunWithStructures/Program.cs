using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            //Cria um Point inicial
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // Ajuste os valores de X e Y 
            myPoint.Increment();
            myPoint.Display();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
