using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Compreendento os Tipo de Valor e Tipos de Referencia
/// 
/// Estruturas são representas implicitamente por System.ValueType
/// 
/// Tipo de Valor:
/// 
/// Tipo de Ref:
/// 
/// Heap: (Responsavel Coleta de Lixo ('Garbage Colector'))
/// 
/// Stack: (Pilha)
/// 
/// </summary>
namespace ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de Valor, Referencia e Operador de Atribuição: ");

            LocalValueTypes();
            ValueTypeAssignment();
            ReferenceTypeAssignment();
            ValueTypeContainsRefType();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        ///  Tipos de Valor Contendo Tipos de Referencia
        ///  Por padrão, quando um tipo de valor contem outros tipos de referencia,
        ///  a atribuicao '=' resulta em uma copia das referencias;
        /// 
        ///  Desta forma temos duas estturas independentes, cada qual contendo uma referencia
        ///  que aponta para o mesmo objeto na memoria.
        /// 
        /// </summary>
        private static void ValueTypeContainsRefType()
        {
            // Crie o primeiro Rectangle
            Console.WriteLine("-> Creating R1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // Agora, atribua um novo Rectangle a r1
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Altere alguns valores valores de r2
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;

            // Imprima os valores de ambos os retangulo
            r1.Display();
            r2.Display();

            Console.WriteLine();
        }

        /// <summary>
        /// Desta forma temos duas estturas independentes, cada qual contendo uma referencia
        /// que aponta para o mesmo objeto na memoria.
        /// 
        /// Aqui depois que p1.X = 100 é atualizado p2.X tambem passa a ser 100, porque nao estamos trabalhos com tipos de valor
        /// </summary>
        private static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");

            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            //Imprime duas referencias
            p1.Display();
            p2.Display();

            // Altere p1.X e imprima novamente.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();

            Console.WriteLine("\n");
        }

        /// <summary>
        /// 
        /// A atribuição de dois tipos de valor intrinsecos resulta em duas variaveis independentes na pilha
        /// Structs nao são iguais a referencia
        /// </summary>
        private static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            //Imprime os dois pontos
            p1.Display();
            p2.Display();

            // Altere p1.X e imprima novamente. p2.X nao é alterado
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();

            Console.WriteLine("\n");
        }

        /// <summary>
        /// As estruturas locais são 
        /// eliminadas da pilha quando um método retorna
        /// </summary>
        private static void LocalValueTypes()
        {
            //Lembre-se! "int" é um System.Int32;
            int i = 0;

            //Lembre-se! Point é um tipo de Estruturas
            Point p = new Point();
        } // i e p sairam da pilha
    }
}
