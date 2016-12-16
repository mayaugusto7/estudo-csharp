using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
    /// <summary>
    /// As classes sao sempre tipos de referencia
    /// </summary>
    class PointRef
    {

        // Campos da estrutura
        public int X;
        public int Y;

        public PointRef(int XPos, int YPos)
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
