using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Methods *****\n");

            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

            /**
             * Não é necessario atribuir um valor inicial as variaveis locais
             * utilizadas como parametros de saida, contanto que na primeira vez
             * voce as utiliza seja como argumentos de saida
             */
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans);

            /**
             * Multiply parameters return 'out'
             * */
            int i;
            string str;
            bool b;

            // Para fazer chamada de retorno colocar o 'out' antes do paramentro passado na chamada do methodo
            FillTheseValues(out i, out str, out b);

            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);

            /**
             *  Palavra chave 'ref'
             * */
            string s1 = "Flip";
            string s2 = "Flop";
            Console.WriteLine("Before: {0}, {1} ", s1, s2);
            // Para fazer chamada de retorno colocar o 'ref' antes do paramentro passado na chamada do methodo
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0}, {1} ", s1, s2);

            /***
             * 
             * Arrays de parametros usando a palavra chave 'params'
             * C# exige que um metodo suporte apenas um unico argumento 'params'
             * que deve ser o argumento final na lista de parametros
             * 
             * */
            //Transmita uma lista de doubles limitada por virgulas...
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            // ... ou transmita um array de doubles
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            // A media de 0 é 0
            Console.WriteLine("Average of data is: {0}", CalculateAverage());


            /***
             * Parametros opcionais
             * **/
            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can't find the payroll data", "CFO");

            /**
             * Parametros nomeados
             * Nao importa a ordem de declaracao dos parametros
             * nomenclatura
             * properties: value
             * */
            DisplayFancyMessage(message: "Won! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);

            // Isto está bem, pois os arg posicionais sao listados antes dos args nomeados
            DisplayFancyMessage(ConsoleColor.Blue, message: "Testing...", backgroundColor: ConsoleColor.White);

            // Isto é um ERRO, pois os args posicionais sao listados depois dos args nomeados
            // DisplayFancyMessage(message: "Testing...", backgroundColor: ConsoleColor.White, ConsoleColor.Blue);

            /**
             * Exemplo de parametros opcionais e nomeados trabalhando juntos
             * */
            DisplayFancyMessageOptional(message: "Hello!");
            DisplayFancyMessageOptional(backgroundColor: ConsoleColor.Green);

            Console.WriteLine("");
            Console.WriteLine("Press any key continue...");
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            int ans = x + y;

            // O solicitante não verá estas mudanças
            // ja que voce esta alterando uma copia dos dados originais
            x = 10000;
            y = 88888;

            return ans;
        }

        /// <summary>
        /// Utilizando a palavra chave 'out' como parametro de saída
        /// Nao e necessario colocar um retorno definido
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        /// <summary>
        /// Retornando diversos parametros de saida usando 'out'
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        /// <summary>
        /// Sempre devemos atribuir ao parametro, um valor valido, o codigo asseguir tem um erro de compilação
        /// </summary>
        /// <param name="a"></param>
        static void ThisWontCompile(out int a)
        {
            a = 5;
            //Console.WriteLine("Error! Forgot to assign output arg!");
        }

        /// <summary>
        /// Parametros de referencia 'ref' devem ser inicializados antes de serem transmitidos
        /// para o metodo
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        /// <summary>
        /// Retorna a media de um numero de doubles
        /// Usamos a palavra chave 'params' 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;

            if (values.Length == 0)
                return sum;

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return (sum / values.Length);
        }

        /// <summary>
        /// Parametros opcionais C#
        /// No parametro opcional o seu valor deve ser conhecido no momento da compilação e antes da execucao;
        /// Parametrso opcionais sempre devem ser colocados no final de uma assinatura do metodo. Um erro do 
        /// compilador ter parâmetros opcionais listados antes do parametros nao opcionais
        /// 
        /// Erro: Tempo de Execucao parametro opcional
        /// static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = DataTime.Now)
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        //
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textColor"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="message"></param>
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            PrintMehtod(textColor, backgroundColor, message);
        }

        static void DisplayFancyMessageOptional(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
        {
            PrintMehtod(textColor, backgroundColor, message);
        }

        private static void PrintMehtod(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // Armazene as antigas cores a restaurar assim que a mensagem for impressa.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbBackgroundColor = Console.BackgroundColor;

            // Defina novas cores e imprima a mensagem
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            // Restaure as cores anteriores
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbBackgroundColor;
        }
    }
}
