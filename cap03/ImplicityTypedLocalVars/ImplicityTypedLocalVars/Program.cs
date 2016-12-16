using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicityTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variaveis Locais Implicitas...");

            DeclareExplicitVars();
            DeclareImplicitVars();
            InitializeImplicitVars();
            GetAnInt();
            ImplicitTypingsStringTyping();
            QueryOverInts();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //Consulta LINQ!
            var subset = from i in numbers where i < 10 select i;

            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0}", i);
            }

            Console.Write("");

            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
            Console.WriteLine();
        }

        private static void ImplicitTypingsStringTyping()
        {
            // O compilador sabe que "s" é System.String
            var s = "This variable can only hold string data!";
            s = "This is fine...";

            // É possivel chamar qualquer membro do tipo subjacente
            string upper = s.ToUpper();
            // Erro! o Compilador ja tem o tipo definido como string
            // s = 44;
        }

        /// <summary>
        /// É possivel retornar uma variavel local digitada implicitamente  desde que o retorno do methodo
        /// e seu seu valor sejam do mesmo tipo 
        /// </summary>
        private static int GetAnInt()
        {
            var retVal = 9;
            return retVal;
        }

        private static void InitializeImplicitVars()
        {
            // Erro! Deve atribuir um valor
            // var myData;

            // Erro! Deve atribuir um valor na hora exata da declaração
            // var myInt;
            // myInt = 0;

            // Erro! Não pode atribuir null como valor inicial
            // var myObj = null;

            // Permitido apenas depois da referencia usando new
            // var myCar = new SportsCar();
            // myCar = null;

            // Tambem esta certo
            var myInt = 0;
            var anotherInt = myInt;

            string myString = "Wake up!";
            var myData = myString;

            // Não, não pode definir variaveis implicitas nulas
            //var? nope = new SportsCar();
            //var? stilloNo = 12;
            //var? noWay = null;  
        }

        private static void DeclareImplicitVars()
        {
            // As variaveis locais digitas implicitamente
            // são declaradas como a seguir:
            // var variableName = initialValue
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            //Print  usando Reflexao
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);

            Console.WriteLine();
        }

        private static void DeclareExplicitVars()
        {
            // As variaveis locais digitas explicitamente
            // são declaradas como a seguir:
            // datatype variableName = initialValue
            int myInt = 0;
            bool myBoot = true;
            string myString = "Time, marches on...";
            Console.WriteLine();
        }
    }

    class ThisWillNeverCompile
    {
        //Erro! var nao pode ser usado como um membro da classe
        //private var myInt = 10;

        // Erro! var nao pode ser usado como um valor de retorno 
        // ou típo do parametro!
        //public var myMethod(var x, var y) { }
    }
}
