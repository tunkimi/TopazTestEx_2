using graphicstry.Figures;

namespace graphicstry
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap map = null;
        Pen pen = Pens.Black;           //����������� ����
        Color color = Color.Black;      //���� ����
        bool penChanged = false;        //�������� �� ����
        float width = 1;
        public Form1()
        {
            InitializeComponent();

            //��������� ��������� bitmap'a
            graphics = CreateGraphics();
            SetSize();
        }


        //�������� ������ bitmap'a � ������������ � �������� ����
        private void SetSize()  
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(map);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }


        //������ ������ �����
        private void colorChooseButton_Click(object sender, EventArgs e)    
        {
            penChanged = true;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                colorIndicator.BackColor = color;
            }

        }


        //������� ��������� ������� ����
        private void widthTextBox_TextChanged(object sender, EventArgs e)   
        {
            penChanged = true;
            float tempwidth;
            if(float.TryParse(widthTextBox.Text, out tempwidth))
            {
                width = tempwidth;
            }
        }


        //���������
        private void drawButton_Click(object sender, EventArgs e)   
        {
            myFigure figure = null;
            int xPos = 0, yPos = 0, xsize = 100, ysize = 120;
            double angle = 0;
            if (penChanged)     //��������� ����, ���� ��� ��������� ��������
            {
                pen = new Pen(color, width);
                penChanged = false;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            }

            //���������� ������ �� ������
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

            //��������� ���������� ������
            try
            {
                var positions = positionTextBox.Text.Split('-', ',', ':').Select(s => (int)double.Parse(s)).ToArray();
                xPos = positions[0];
                yPos = positions[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������� ����������");
            }

            //��������� ���� �������� ������
            if(!double.TryParse(angleTextBox.Text.Replace(".", ","), out angle))
            {
                MessageBox.Show("������� ������ ���� ��������");
            }

            //��������� ������� ������
            try
            {
                var sizes = sizesTextBox.Text.Split('-', ',', ':').Select(s => (int)double.Parse(s)).ToArray();
                xsize = sizes[0];
                ysize = sizes[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������� �������");
            }

            figure.clearBeforeDraw = clearBeforeDraw�heckBox.Checked;   //��������� ������������� ������� ���������� ������
            figure.SetPen(pen)                                          //������������� ����
                .SetRotateAngle(angle)                                  //������������� ���� ��������
                .SetPosition(xPos, yPos);                               //������������� ����������
            figure.SetSize(new int[] { xsize, ysize });                 //������������� ������� ������
            figure.Draw(graphics);                              //������ ������
            pictureBox1.Image = map;                            //���������� ������
        }
    }
}