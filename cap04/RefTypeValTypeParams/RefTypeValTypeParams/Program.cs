using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    /// <summary>
    /// Transmitir Tipos de Referencia pelo Valor
    /// 
    /// Regras:
    /// 
    /// 1 - Se um tipo de referência é transmitido pela referencia, o solicitado pode alterar
    /// os valores dos dados de estado do objeto, bem como o objeto que está referenciado
    /// 
    /// 2 - Se um tipo de referencia é transmitido pelo valor, o solicitado pode alterar os valores dos
    /// dados de estado do objeto, mas não o objeto que esta referenciado
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Transmitindo os tipos de referencia pelo valor.
            Console.WriteLine("*********** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);

            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();

            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();

            Console.WriteLine("\n");

            Person mel = new Person("Mel", 23);

            Console.WriteLine("\nBefore by value call, Person is:");
            mel.Display();
            
            SendAPersonByReference(ref mel);

            Console.WriteLine("\nAfter by value call, Person is:");
            mel.Display();

            Console.WriteLine("Press any to continue...");
            Console.ReadLine();
        }


        static void SendAPersonByReference(ref Person p)
        {
            // Altere alguns dados de "p"
            p.personAge = 555;

            // Agora "p" eta apontando para um novo objeto no heap
            p = new Person("Nikki", 999);
        }


        /// <summary>
        /// Foi feita uma copia da referencia para o objeto solicitante, portanto o metodo
        /// SendAPersonByValue() esta apontando para o mesmo objeto do solicitante, por isso é possivel
        /// alterar os dados do estado do objeto. O que não é possivel é reatribuir aquilo para o qual a referencia esta apontando
        /// ex:  p = new Person("Nikki", 99);
        /// </summary>
        /// <param name="p"></param>
        static void SendAPersonByValue(Person p)
        {
            // Mudar a idade de "p"? Funciona aponta para o mesmo objeto solicitante fred
            p.personAge = 99;

            // O Solicitante verá esta requisição? Nao funciona
            p = new Person("Nikki", 99);
        }
    }
}
