using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicstry.Figures
{
    internal class myRound : mySquare
    {
        protected override void GetPoints()
        {
            points = new Point[361];
            for(int i = 0; i < points.Length; i++)
            {
                points[i] = new Point((int)(xSize/2 * Math.Cos(i * Math.PI / 180)), (int)(xSize/2 * Math.Sin(i * Math.PI / 180)));
            }
        }

        protected override void Rotate(double angle)
        {
            //вращать круг бессмысленно
            return;
        }

        public override void SetSize(int[] sizes)
        {
            base.SetSize(sizes);
        }
    }
}
