using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Struct (estruturas) são usadas para modelar entidades matematicas, geometricas e outras "atômicas" na aplicacao.
/// 
/// Uma structure (estrutura) não são igual a enums uma colecao de pares nome/valor. Ao contrario elas podem conter 
/// qualquer numero de campos de dados e membros que operam nesses campos
/// 
/// Na OOP struct (estrutura ) condiz com um tipo de classe leve, conseguimos definir um tipo que suporta encapsulamento, 
/// mas nao podem ser usadas para construir familias de tipos
/// relacionados herança por exemplo tera que usar classe 
/// 
/// </summary>
namespace ValueAndReferenceType
{
    struct Point
    {
        // Campos da estrutura
        public int X;
        public int Y;

        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        // Adicione 1 à posição (X, Y)
        public void Increment()
        {
            X++;
            Y++;
        }

        // Subtraia 1 à posição (X, Y)
        public void Decrement()
        {
            X--;
            Y--;
        }

        // Exiba a posicao atual
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
