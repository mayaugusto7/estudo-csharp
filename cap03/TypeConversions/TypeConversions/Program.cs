using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    /// <summary>
    /// adicionar um short em int tem denomicao como conversao ascendente nao resulta em perda de dados
    /// estreitamento e quando adiciona uma valor maior em uma variavel com menos valor
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // Adiciona dois shors e printa na tela
            short numb1 = 30000, numb2 = 30000;

            // Converte explicitamente int em short (e permite a perda de dados)
            short answer = (short) Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            
            NarrowingAttempt();
            ProcessBytes();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            // sum deve manter valor 350 entretanto encontramos o valor 94!
            // isso ocorre pelo seguinte um byte possui de 0 a 255 (256 elementos) o calculo é (350 - 256) = 94 
            // Desta vez pedimos o compilador para lançar uma exceção caso ocorra um estouro / estouro negativo
            // Usamos a palavra chave checked pode ser usada em instrucoes e blocos de codigo
            try
            {
                checked
                {
                    //byte sum = checked((byte) Add(b1, b2));
                    byte sum = checked((byte) Add(b1, b2));
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(); 
        }

        private static void NarrowingAttempt()
        {
            byte myByte = 9;
            int myInt = 200;

            // Converte explicitamente int em byte (sem perda de dados)
            myByte = (byte) myInt; // erro porque um int de 200 nao pode ser adicionado a um byte 8 bits
            myByte = Convert.ToByte(myInt);

            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        private static int Add(int numb1, int numb2)
        {
            return numb1 + numb2; // erro porque um int de 60000 nao pode ser adicionado a um short
        }

        /**
        private static short Add(int numb1, int numb2)
        {
            return numb1 + numb2; // errro porque um int de 60000 nao pode ser adicionado a um short
        }**/
    }
}
