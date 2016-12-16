using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    /// <summary>
    /// No C# é aceito um EmpType para enums
    /// No java seria necessario cria dois atributos descricao valor e getters and setters e seu construtor
    /// </summary>
    enum EmpType
    {
        Manager, // = 0
        Grunt, // = 1
        Contractor, // = 2
        VicePresident // 3
    }

    /// <summary>
    /// Enum type de 102 a 105
    /// </summary>
    enum EmpTypeInitialize
    {
        Manager = 102, 
        Grunt, // = 103
        Contractor, // = 104
        VicePresident // 105
    }

    /// <summary>
    /// Os Elementos de uma enumeracao nao precisam estar em sequencia
    /// </summary>
    enum EmpTypeNotSequence
    {
        Manager = 10,
        Grunt = 1, 
        Contractor = 100, 
        VicePresident = 9
    }

    /// <summary>
    /// Desta vez, EmpType mapeia para um byte subjacente
    /// </summary>
    enum EmpTypeSubjancent : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9 // se colocar 999 vai dar um erro no compilador um byte suporta no maximo 0 - 255
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Enums *****");

            // Crie um tipo fornecedor
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            TestDeclartions();
            PrintStorageEnum(emp);
            PrintParKeyValue(emp);

            EmpType e2 = EmpType.Contractor;

            // Estes tipos sao enums no namespace System
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);

            Console.WriteLine("Press any to continue...");
            Console.ReadLine();            
        }


        /// <summary>
        /// Usando System.Enum
        /// Este metodo imprime os detalhes de qualquer enum
        /// </summary>
        /// <param name="e"></param>
        private static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            // Obter todos os pares de nome/valor para o parametro de entrada.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            // Agora exiba o nome da string e o valor associado, usando a flag do formato D 
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Podemos usar o ToString() para imprimir pares chave/valor de um enum
        /// </summary>
        /// <param name="emp"></param>
        private static void PrintParKeyValue(EmpType emp)
        {
            Console.WriteLine("emp is a {0}.", emp.ToString()); // nome variavel enum Contractor
            Console.WriteLine("{0} = {1}", emp.ToString(), (int) emp); // valor variavel enum Contractor = 2
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Existem duas formas de obter o tipo de armazenamento de um enum
        /// emp.GetType
        /// or
        /// typeof(EmpType)
        /// </summary>
        /// <param name="emp"></param>
        private static void PrintStorageEnum(EmpType emp)
        {
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(typeof (EmpType)));
            Console.WriteLine("\n");
        }

        private static void TestDeclartions()
        {
            // Erro! Sales manager nao esta em EmpType
            // EmpType emp = EmpType.SalesManager;

            // Erro esqueceu de aplicar o escopo do valor Grunt enum EmpType    
            // emp = Grunt;
            // Correct: Abaixo
            // EmpType emp = EmpType.Grunt;
        }


        /// <summary>
        /// Enums como parametros
        /// </summary>
        /// <param name="emp"></param>
        private static void AskForBonus(EmpType emp)
        {
            switch (emp)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
                default:
                    break;
            }
        }
    }
}
