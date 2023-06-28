using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicstry.Figures
{
    abstract public class myFigure
    {
        protected Pen pen;          //перо
        protected Point[] points;   //набор отображаемых точек
        protected int xPos;         //координаты центра фигуры
        protected int yPos;
        protected double angle;     //угол поворота фигуры
        protected int xSize;        //размеры фигуры
        protected int ySize;
        public bool clearBeforeDraw = true;     //необходимость очищать старые фигуры
        public myFigure()
        {
            pen = Pens.Black;
            points = new Point[] { new Point { X = 0, Y = 0 } };
            xPos = 0;
            yPos = 0;
            angle = 0;
            xSize = 0;
            ySize = 0;
        }


        //получаем перо
        public myFigure SetPen(Pen pen)
        {
            this.pen = pen;
            return this;
        }


        //получаем угол поворота
        public myFigure SetRotateAngle(double angle)
        {
            this.angle = angle;
            return this;
        }


        //устанавливаем размеры фигуры
        public abstract void SetSize(int[] sizes);


        //устанавливаем координаты фигуры
        public myFigure SetPosition(int xpos, int ypos)
        {
            xPos = xpos;
            yPos = ypos;
            return this;
        }


        //получаем набор точек для отрисовки
        protected abstract void GetPoints();


        //вращаем точки около центра
        abstract protected void Rotate(double angle);


        //рисуем фигуру
        public virtual void Draw(Graphics g)
        {
            if(clearBeforeDraw)
                g.Clear(Color.White);
            GetPoints();
            Rotate(angle);

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += this.xPos;
                points[i].Y += this.yPos;
            }
            g.DrawLines(pen, points);
        }
    }
}
