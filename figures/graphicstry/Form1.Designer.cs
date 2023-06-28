namespace graphicstry
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBeforeDrawСheckBox = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sizesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorIndicator = new System.Windows.Forms.Button();
            this.colorChooseButton = new System.Windows.Forms.Button();
            this.figureComboBox = new System.Windows.Forms.ComboBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearBeforeDrawСheckBox);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.figureComboBox);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // clearBeforeDrawСheckBox
            // 
            this.clearBeforeDrawСheckBox.AutoSize = true;
            this.clearBeforeDrawСheckBox.Checked = true;
            this.clearBeforeDrawСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearBeforeDrawСheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearBeforeDrawСheckBox.Location = new System.Drawing.Point(3, 178);
            this.clearBeforeDrawСheckBox.Name = "clearBeforeDrawСheckBox";
            this.clearBeforeDrawСheckBox.Size = new System.Drawing.Size(192, 19);
            this.clearBeforeDrawСheckBox.TabIndex = 15;
            this.clearBeforeDrawСheckBox.Text = "Стирать предыдущие фигуры";
            this.clearBeforeDrawСheckBox.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.sizesTextBox);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 28);
            this.panel6.TabIndex = 14;
            // 
            // sizesTextBox
            // 
            this.sizesTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.sizesTextBox.Location = new System.Drawing.Point(106, 0);
            this.sizesTextBox.Name = "sizesTextBox";
            this.sizesTextBox.Size = new System.Drawing.Size(86, 23);
            this.sizesTextBox.TabIndex = 1;
            this.sizesTextBox.Text = "120, 170";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Размеры";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.angleTextBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 28);
            this.panel5.TabIndex = 12;
            // 
            // angleTextBox
            // 
            this.angleTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.angleTextBox.Location = new System.Drawing.Point(106, 0);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(86, 23);
            this.angleTextBox.TabIndex = 1;
            this.angleTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Угол поворота";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.positionTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 26);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Координаты";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.positionTextBox.Location = new System.Drawing.Point(106, 0);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(86, 23);
            this.positionTextBox.TabIndex = 0;
            this.positionTextBox.Text = "300, 200";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.widthTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 27);
            this.panel2.TabIndex = 10;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.widthTextBox.Location = new System.Drawing.Point(106, 0);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(86, 23);
            this.widthTextBox.TabIndex = 1;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выбор толщины";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.colorIndicator);
            this.panel3.Controls.Add(this.colorChooseButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 28);
            this.panel3.TabIndex = 9;
            // 
            // colorIndicator
            // 
            this.colorIndicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorIndicator.Enabled = false;
            this.colorIndicator.Location = new System.Drawing.Point(165, 0);
            this.colorIndicator.Name = "colorIndicator";
            this.colorIndicator.Size = new System.Drawing.Size(27, 28);
            this.colorIndicator.TabIndex = 5;
            this.colorIndicator.UseVisualStyleBackColor = true;
            // 
            // colorChooseButton
            // 
            this.colorChooseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorChooseButton.Location = new System.Drawing.Point(0, 0);
            this.colorChooseButton.Name = "colorChooseButton";
            this.colorChooseButton.Size = new System.Drawing.Size(159, 28);
            this.colorChooseButton.TabIndex = 4;
            this.colorChooseButton.Text = "Выбор цвета";
            this.colorChooseButton.UseVisualStyleBackColor = true;
            this.colorChooseButton.Click += new System.EventHandler(this.colorChooseButton_Click);
            // 
            // figureComboBox
            // 
            this.figureComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.figureComboBox.FormattingEnabled = true;
            this.figureComboBox.Items.AddRange(new object[] {
            graphicstry.Figures.FiguresEnum.Rectangle,
            graphicstry.Figures.FiguresEnum.Round,
            graphicstry.Figures.FiguresEnum.Square,
            graphicstry.Figures.FiguresEnum.Ellipse,
            graphicstry.Figures.FiguresEnum.Triangle});
            this.figureComboBox.Location = new System.Drawing.Point(3, 18);
            this.figureComboBox.Name = "figureComboBox";
            this.figureComboBox.Size = new System.Drawing.Size(192, 23);
            this.figureComboBox.TabIndex = 8;
            // 
            // drawButton
            // 
            this.drawButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drawButton.Location = new System.Drawing.Point(3, 422);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(192, 23);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "Нарисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор фигуры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(600, 450);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private Button drawButton;
        private ComboBox figureComboBox;
        private Panel panel2;
        private TextBox widthTextBox;
        private Label label2;
        private Panel panel3;
        private Button colorIndicator;
        private Button colorChooseButton;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private TextBox positionTextBox;
        private Panel panel5;
        private TextBox angleTextBox;
        private Label label4;
        private CheckBox clearBeforeDrawСheckBox;
        private Panel panel6;
        private TextBox sizesTextBox;
        private Label label5;
    }
}