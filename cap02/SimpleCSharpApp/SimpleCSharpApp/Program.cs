using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("************** My First C# App **************");
            Console.WriteLine("Hello World");
            Console.WriteLine();

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }

            Console.WriteLine();


            foreach (string arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.WriteLine();

            //Obtem os args utilizados
            string[] theArgs = Environment.GetCommandLineArgs();

            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.WriteLine();
            ShowEnvironmentDetails();
            Console.ReadLine();

            return -1; //codigo de erro arbitrario %ERRORLEVEL% criado um bat.
        }

        private static void ShowEnvironmentDetails()
        {
            /**
             * Imprimir Driver e outros detalhes
             * */
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version {0}", Environment.Version);
            Console.WriteLine("Out App {0}", Environment.ExitCode);
            Console.WriteLine("Maquina name {0}", Environment.MachineName);
            Console.WriteLine("Stacktrace App {0}", Environment.StackTrace);
            Console.WriteLine("Root System {0}", Environment.SystemDirectory);
            Console.WriteLine("Username start app {0}", Environment.UserName);
            
        }
    }
}
