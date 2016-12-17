using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    /// <summary>
    /// Nullable Types 
    /// Tipos locais anulaveis
    /// 
    /// Tipos de valor jamais podem receber null ex: bool {true, false}
    /// Nullable Types (Tipos locais anulaveis)  usamos '?' ele permite o uso de null ex: bool {true, false, null}
    ///
    /// No C# ? é uma referencia 'atalho' para System.Nullable<T>
    /// 
    /// Recomendao para usar em banco de dados relacionais para tratar colunas vazias ou indefinidas
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            //Obtenha int a partir de database
            int? i = dr.GetIntFromDatabase();

            if (i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is: undefined.");

            //Obtenha bool a partir de database
            bool? b = dr.GetBoolFromDatabase();

            if (b.HasValue)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("Value of 'i' is: undefined.");


            // Testando Operador ?? ele pode usado quando um valor null é retornado de fato 
            // e queremos colocar um valor default
            // ?? equivale a um if/else ternario
            // Se o valor de GetIntFromDataBase() for null
            // atribua a variavel local para 100
            int? myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);

            // Versao longa a mao utlizacao da sintaxa ? : ??;
            int? moreData = dr.GetIntFromDatabase();

            if (!moreData.HasValue)
                moreData = 100;

            Console.WriteLine("Value of moreData: {0}", moreData);

            Console.ReadLine();
        }

        static void LocalNullableVariables()
        {
            // Defina alguns tipos locais anulaveis
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

            // Erro! Strings são tipos de referência
            // string? s = "oops";
        }

        static void LocalNullableVariablesUsingNullable()
        {
            //Defina alguns tipos de anulaveis locais utilizando Nullable<T>
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new int?[10];
        }
    }
}
