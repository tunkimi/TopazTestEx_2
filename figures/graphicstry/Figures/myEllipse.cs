using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicstry.Figures
{
    internal class myEllipse : myRound
    {
        protected override void GetPoints()
        {
            base.GetPoints();
            //растягиваем полученные в Round.GetPoints() точки фигуры
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Y = (int)(points[i].Y * ySize / xSize);
            }
        }
        public override void SetSize(int[] sizes)
        {
            base.SetSize(sizes);
            ySize = sizes[1];
        }
    }
}
