using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            DataTypeBoolean();
            CharFunctionality();
            ParseFromStrings();
            UserDatesAndTimes();
            UseBigInteger();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }


        /// <summary>
        /// Namespace System.Numerics
        /// </summary>
        private static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");

            BigInteger biggy = BigInteger.Parse("99999999999999999999999999999999999999999999999999999999999999999");

            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);

            BigInteger reallyBig = BigInteger.Parse("88888888888888888888888888888888888888888888888888888888888888888");
            Console.WriteLine("Value pf reallyBig is {0}", reallyBig);

            BigInteger reallyBig2 = biggy * reallyBig;
            Console.WriteLine(reallyBig2);

            Console.WriteLine();
        }


        /// <summary>
        /// System.DateTime e System.TimeSpan
        /// </summary>
        private static void UserDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");

            //Construtor mes ano dia
            DateTime dt = new DateTime(2010, 10, 17);

            //Dia do mes
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            //ADD 2, Mes Dezembro
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            //Construtor horas minutos segundos
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            //Subtrair 15 minutos do TimeSpan atual e imprime
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();
        }


        /// <summary>
        /// Analise dos Valores da String de Dados
        /// </summary>
        private static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);

            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);

            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);

            Console.WriteLine();
        }


        /// <summary>
        /// Membros System.Char
        /// </summary>
        private static void CharFunctionality()
        {
            Console.WriteLine("=> Char type Functionality:");

            char myChar = 'a';

            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit('a'));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter('a'));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation ('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }


        /// <summary>
        /// Membros System.Boolean
        /// </summary>
        private static void DataTypeBoolean()
        {
            Console.WriteLine("=> Data type Boolean:");

            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }


        /// <summary>
        /// Membros dos tipos de Dados Numéricos
        /// </summary>
        private static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }


        /// <summary>
        /// Hierarquia de dados tipos de classes
        /// Um int C# é realmente uma abreviação para System.Int32
        /// que herda os seguintes membros de System.Object
        /// </summary>
        private static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality: ");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }


        /// <summary>
        /// Tipos de Dados Intrínsicos e Operador new
        /// Operador new construtores padroes
        /// </summary>
        private static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool(); // Default false
            int i = new int(); // Default 0
            double d = new double(); // Default 0.0
            DateTime dt = new DateTime(); // Default 1/1/0001 12:00:00 AM 
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }


        /// <summary>
        /// Declaração e inicialização de variáveis
        /// Todas variaveis locais devem ser inicializadas antes de ser utilizadas
        /// </summary>
        private static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");

            int myInt = 0;
            string myString = "This is my character data";

            // Declare 3 bools em uma linha
            bool b1 = true, b2 = false, b3 = b1;

            // Usando Boxing para declarar um bool
            System.Boolean b4 = false;

            Console.WriteLine("Your Data {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }
    }
}
