using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicstry.Figures
{
    internal class myRectangle : myFigure
    {
        public override void Draw(Graphics g)
        {
            base.Draw(g);
        }

        protected override void GetPoints()
        {
            //определяем набор точек
            points = new Point[]
            {
                new Point(-xSize/2, -ySize/2),
                new Point(xSize/2, -ySize/2),
                new Point(xSize/2, ySize/2),
                new Point(-xSize/2, ySize/2),
                new Point(-xSize/2, -ySize/2)
            };
        }

        public override void SetSize(int[] sizes)
        {
            xSize = sizes[0];
            ySize = sizes[1];
        }

        protected override void Rotate(double angle)
        {
            //вращаем точки вокруг центра фигуры
            for(int i = 0; i < points.Length; i++)
            {
                int tempx = (int)(points[i].X * Math.Cos(angle) + points[i].Y * Math.Sin(angle));
                int tempy = (int)(-points[i].X * Math.Sin(angle) + points[i].Y * Math.Cos(angle));
                points[i].X = tempx;
                points[i].Y = tempy;
            }
        }
    }
}
