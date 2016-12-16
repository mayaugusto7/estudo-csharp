using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Strings ******");

            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            StringTextual();
            StringEquality();
            StringAreImmutable();
            FunWithStringBuilder();
            Console.WriteLine("Press any key continue...");
            Console.ReadLine();
        }

        private static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");

            StringBuilder sb = new StringBuilder("***** Fantastic Games *****", 256); // por padrao uma string inicial e 16 podemos aumeta-la 
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Beyond Good and Evil");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine("System.Shock");

            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb as {0} chars.", sb.Length);
            Console.WriteLine();
        }

        /// <summary>
        /// Entretanto se obervarmos de perto o que acontece é que os metodos string estao retornando uma string
        /// na verdade retornando um objeto string novinho em um formato modificado
        /// </summary>
        private static void StringAreImmutable()
        {
            Console.WriteLine("=> String are Immutable:");

            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            //Colocar s1 em maiusculo?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Não! s1 fica com o mesmo formato!
            Console.WriteLine("s1 = {0}", s1);

            string s2 = "My other string";
            s2 = "New string value"; // novo objeto string usando operador de atribuicao =
            Console.WriteLine(s2);

            Console.WriteLine();
        }

        private static void StringEquality()
        {
            Console.WriteLine("=> String equality:");

            string s1 = "Hello!";
            string s2 = "Yo!";

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //Teste estas strings para a igualdade
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        /// <summary>
        /// Quando prefixamos a string com @, cria-se uma string textual.
        /// Quando usamos a string textual desativamos caracteres de scape e imprime a string igual ela é.
        /// </summary>
        private static void StringTextual()
        {
            Console.WriteLine("=> Strings Textuais @");

            Console.WriteLine(@"C:\myApp\bin\Debug");

            string myLongString = @"This a very
                                                very
                                                    very
                                                         long string";

            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
            Console.WriteLine();
        }

        private static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");

            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a");

            Console.WriteLine("All finished. \n\n\n\a");
            Console.WriteLine();
        }

        private static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");

            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2; // mesma coisa que String.Concat(s1, s2); O CIL converte o operador para o metodo Concat.
            Console.WriteLine(s3);
            Console.WriteLine(); 
        }

        private static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");

            string firstName = "Freddy";

            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();    
        }
    }
}
