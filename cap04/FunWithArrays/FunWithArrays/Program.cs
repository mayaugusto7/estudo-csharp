using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultiDimensionalArray();
            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");

            //Inicialize
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Imprima os nomes na ordem declarada
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            //Iverte-os
            Array.Reverse(gothicBands);

            Console.WriteLine(" -> The reversed array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.WriteLine(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            //Limpe tudo, menos o membro final
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.WriteLine(gothicBands[i] + ", ");

            }

            Console.WriteLine();
        }

        /// <summary>
        /// Array dentado (jagged)
        /// Matriz de Matriz
        /// </summary>'
        private static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");

            // Um array dentado MD (ou seja, um array de arrays).
            // Aqui temos um array de 5 arrays diferentes
            int[][] myJagArray = new int[5][];

            // Crie um array dentado
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            // Imprima cada linha
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Array Bi dimensional
        /// </summary>
        private static void RectMultiDimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");

            // Um array MD retangular
            int[,] myMatrix;
            myMatrix = new int[6, 6];

            // Preencha o Array 6 * 6
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myMatrix[i , j] = i * j;
                }
            }

            //Print array 6 * 6
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array de Objects.");

            // Um array de objects pode ser qualquer coisa
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Arrays Locais implicitos
        /// </summary>
        private static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicity Array Initalization.");

            // a é realmente um int
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b é realmente double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is b: {0}", b.ToString());

            // c é realmente string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is c: {0}", c.ToString());

            // d é realmente string[]
            var d = new[] { null, null, "world" };
            Console.WriteLine("d is d: {0}", d.ToString());

            // e Erro! nao podemos mesclar tipos diferentes
            // var e = new[] { 1, "one", 2, "two", false };

            Console.WriteLine();
        }

        private static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initalization.");

            // Sintaxe de inicialização do array utilizando a palavra-chave new
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Sintaxe de inicialização do array sem usar palavra-chave new
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Inicialização do array com a palavra-chave new
            // Java nao permite esta sintaxe de array
            // Erro! num elementos maior que tamanho do array int[] intArray = new int[2] { 20, 22, 23, 0 };
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);

            Console.WriteLine();
        }

        private static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation."); 
            // Atribua um array de ints contendo 3 elementos {0, 1, 2}
            int[] myInts = new int[3];

            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        
            // Inicialize um array de strings com 100 itens, indexado {0 - 99}
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        /// <summary>
        /// Array como parametro
        /// </summary>
        /// <param name="myInts"></param>
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// // Retornar array de strings
        /// </summary>
        /// <returns></returns>
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };

            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");

            // Transmita o array como parametro
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Obter o array com valor de retorno
            string[] strs = GetStringArray();
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }
    }
}
