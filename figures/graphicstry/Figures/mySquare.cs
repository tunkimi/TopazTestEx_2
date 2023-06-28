using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicstry.Figures
{
    internal class mySquare : myRectangle
    {
        public override void SetSize(int[] sizes)
        {
            //у квадрата размеры по осям совпадают, берется первое значение из sizes
            xSize = sizes[0];
            ySize = sizes[0];
        }

    }
}
