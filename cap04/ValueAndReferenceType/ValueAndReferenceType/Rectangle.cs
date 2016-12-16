using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
    /// <summary>
    /// Tipos de Valor Contendo Tipos de Referencia
    /// </summary>
    struct Rectangle
    {
        // A estrutura Rectangle contém um membro do tipo de referencia
        public ShapeInfo rectInfo;

        public int rectTop;
        public int rectLeft;
        public int rectRight;
        public int rectBottom;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectLeft = left;
            rectRight = right;
            rectBottom = bottom;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, Left = {3}, Right = {4}", rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }

    }
}
