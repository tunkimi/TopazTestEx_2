using graphicstry.Figures;

namespace graphicstry
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap map = null;
        Pen pen = Pens.Black;           //стандартное перо
        Color color = Color.Black;      //цвет пера
        bool penChanged = false;        //менялось ли перо
        float width = 1;
        public Form1()
        {
            InitializeComponent();

            //начальная настройка bitmap'a
            graphics = CreateGraphics();
            SetSize();
        }


        //изменяет размер bitmap'a в соответствии с размером окна
        private void SetSize()  
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(map);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }


        //кнопка выбора цвета
        private void colorChooseButton_Click(object sender, EventArgs e)    
        {
            penChanged = true;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                colorIndicator.BackColor = color;
            }

        }


        //событие изменения толщины пера
        private void widthTextBox_TextChanged(object sender, EventArgs e)   
        {
            penChanged = true;
            float tempwidth;
            if(float.TryParse(widthTextBox.Text, out tempwidth))
            {
                width = tempwidth;
            }
        }


        //отрисовка
        private void drawButton_Click(object sender, EventArgs e)   
        {
            myFigure figure = null;
            int xPos = 0, yPos = 0, xsize = 100, ysize = 120;
            double angle = 0;
            if (penChanged)     //обновляем перо, если его параметры менялись
            {
                pen = new Pen(color, width);
                penChanged = false;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            }

            //определяем фигуру из списка
            switch (figureComboBox.SelectedItem)    
            {
                case FiguresEnum.Triangle:
                    {
                        figure = new myTriangle();
                        break;
                    }
                case FiguresEnum.Rectangle:
                    {
                        figure = new myRectangle();
                        break;
                    }
                case FiguresEnum.Square:
                    {
                        figure = new mySquare();
                        break;
                    }
                case FiguresEnum.Ellipse:
                    {
                        figure = new myEllipse();
                        break;
                    }
                case FiguresEnum.Round:
                    {
                        figure = new myRound();
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            //считываем координаты фигуры
            try
            {
                var positions = positionTextBox.Text.Split('-', ',', ':').Select(s => (int)double.Parse(s)).ToArray();
                xPos = positions[0];
                yPos = positions[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены координаты");
            }

            //считываем угол поворота фигуры
            if(!double.TryParse(angleTextBox.Text.Replace(".", ","), out angle))
            {
                MessageBox.Show("Неверно указан угол поворота");
            }

            //считываем размеры фигуры
            try
            {
                var sizes = sizesTextBox.Text.Split('-', ',', ':').Select(s => (int)double.Parse(s)).ToArray();
                xsize = sizes[0];
                ysize = sizes[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены размеры");
            }

            figure.clearBeforeDraw = clearBeforeDrawСheckBox.Checked;   //указываем необходимость стирать предыдущую фигуру
            figure.SetPen(pen)                                          //устанавливаем перо
                .SetRotateAngle(angle)                                  //устанавливаем угол поворота
                .SetPosition(xPos, yPos);                               //устанавливаем координаты
            figure.SetSize(new int[] { xsize, ysize });                 //устанавливаем размеры фигуры
            figure.Draw(graphics);                              //рисуем фигуру
            pictureBox1.Image = map;                            //отображаем фигуру
        }
    }
}