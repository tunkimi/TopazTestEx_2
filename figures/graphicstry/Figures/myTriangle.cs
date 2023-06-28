using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicstry.Figures
{
    internal class myTriangle : myRectangle
    {
        protected override void GetPoints()
        {
            points = new Point[]
            {
                new Point(0, -ySize/2),
                new Point(xSize/2, ySize/2),
                new Point(-xSize/2, ySize/2),
                new Point(0, -ySize/2)
            };
        }
    }
}
