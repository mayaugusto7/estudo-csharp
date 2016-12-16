using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure a IU do Console 
            ConfigureUI();

            // Esperar tecla Enter
            Console.ReadLine();
        }

        private static void ConfigureUI()
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************************");
            Console.WriteLine("************ Welcome to My Rocking App **********************");
            Console.WriteLine("*************************************************************");
        }

    }
}
