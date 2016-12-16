using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops...");

            ForAndForEachLoop();
            VarInForEachLoop();
            ExecuteWhileLoop();
            ExecuteDoWhileLoop();
            ExecuteIfElse();
            ExecuteSwitch();
            ExecuteSwitchOnString();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Switch com string option ma pratica 
        /// Ideal criar um Enumerator
        /// </summary>
        private static void ExecuteSwitchOnString()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
           
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language");
                    break;

                case "VB":
                    Console.WriteLine("VB .NET: OOP, multithreading, and more!");
                    break;

                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Switch Number
        /// </summary>
        private static void ExecuteSwitch()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language");
                    break;

                case 2:
                    Console.WriteLine("VB .NET: OOP, multithreading, and more!");
                    break;
                     
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// IF ELSE
        /// </summary>
        private static void ExecuteIfElse()
        {
            Console.WriteLine("IF and Else...");

            string stringData = "My textual data";

            if (stringData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
            else
            {
                Console.WriteLine("string is Empty");
            }

            Console.WriteLine();

        }

        /// <summary>
        /// Loop do while
        /// </summary>
        private static void ExecuteDoWhileLoop()
        {
            string userIsDone = " ";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");

            Console.WriteLine();
        }

        /// <summary>
        /// Loop while
        /// </summary>
        private static void ExecuteWhileLoop()
        {
            string userIsDone = " ";

            // Teste em cópia de classe inferior da string
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("In while loop");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Interando uma variavel implicita
        /// util somente quando nao sabemos o tipo que estamos manipulando
        /// </summary>
        private static void VarInForEachLoop()
        {
            int[] myInts = { 10, 20, 30, 40 };

            //use var em um loop for each padrao
            foreach (var item in myInts)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Loop for basico
        /// </summary>
        private static void ForAndForEachLoop()
        {
            // Note! "i" só fica visível dentro do escopo do loop for
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Numbers is: {0} ", i);
            }

            Console.WriteLine();
            ForEachLoop();
        }

        /// <summary>
        /// Interar os itens usando o for each
        /// </summary>
        private static void ForEachLoop()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };

            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            int[] myInts = { 10, 20, 30, 40 };

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
    }
}
