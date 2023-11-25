using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Boolean mouseMoving = false;
        Pen pen;
        Pen eraser;
        Font font;
        Point mouseStart, mouseEnd;
        int x, y, startX, endX, startY, endY;
        string operation = "pencil";
        string text = string.Empty;
        Point textBoxPoint;
        bool isCollapsed;
        int penSize = 5;
        Color color = Color.Black;

        public Form1()
        {
            InitializeComponent();

            //this.Width = 1100;
            //this.Height = 600;
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;

            pen = new Pen(Color.Black, penSize);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser = new Pen(Color.White, 15);
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            font = new Font("Century Gothic", 10);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                
                color = colorDialog.Color;
                if (operation == "brush")
                {
                    pen.Color = Color.FromArgb(100, color.R, color.G, color.B);
                }
                else
                {
                    pen.Color = colorDialog.Color;
                }
            }
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            text = string.Empty;
            operation = "txt";
            
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog.Font;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;
            int newWidth = TextRenderer.MeasureText(textBox1.Text, textBox1.Font).Width + 5;
            textBox1.Width = newWidth;
            text = textBox1.Text;
        }

        private void textBox_KeyPress(object sender,  KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.ReadOnly = true;
                e.Handled = true;
                Controls.Remove(textBox);
                operation = "pen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    controls.Size = controls.MaximumSize;
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    controls.Size = controls.MinimumSize;
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            penSize = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            penSize = 5;
            pen.Width = penSize;
            eraser.Width = penSize;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            penSize = 10;
            pen.Width = penSize;
            eraser.Width = penSize;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            penSize = 15;
            pen.Width = penSize;
            eraser.Width = penSize;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (mouseMoving)
            {
                if (operation == "line")
                {
                    graphics.DrawLine(pen, startX, startY, x, y);
                }
            }
            if (operation == "txt")
            {
                var textFont = font;
                Brush textBrush = new SolidBrush(color);
                graphics.DrawString(text, textFont, textBrush, textBoxPoint);
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMoving = false;

            endX = x - startX;
            endY = y - startY;

            if (operation == "line")
            {
                graphics.DrawLine(pen, startX, startY, x, y);
            }
            if (operation == "txt")
            {
                var textFont = font;
                Brush textBrush = new SolidBrush(color);
                graphics.DrawString(text, textFont, textBrush, textBoxPoint);
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMoving == true && (operation == "pencil" || operation == "brush"))
            {
                mouseEnd = e.Location;
                graphics.DrawLine(pen, mouseEnd, mouseStart);
                mouseStart = mouseEnd;

            }
            if (mouseMoving == true && operation == "eraser")
            {
                mouseEnd = e.Location;
                graphics.DrawLine(eraser, mouseEnd, mouseStart);
                mouseStart = mouseEnd;
            }
            if (operation == "txt")
            {
                var textFont = font;
                Brush textBrush = new SolidBrush(color);
                graphics.DrawString(text, textFont, textBrush, textBoxPoint);
            }

            pictureBox1.Refresh();
            text = string.Empty;

            x = e.X;
            y = e.Y;
            endX = e.X - startX;
            endY = e.Y - startY;

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMoving = true;
            mouseStart = e.Location;

            startX = e.X;
            startY = e.Y;

        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (operation == "txt" && e.Button == MouseButtons.Left)
            {
                TextBox textBox = new TextBox();
                textBox.ForeColor = color;
                textBox.Location = e.Location;
                textBoxPoint = e.Location;
                textBox.Size = new Size(100, 20);
                Controls.Add(textBox);
                textBox.Font = font;
                textBox.BringToFront();
                textBox.TextChanged += textBox_TextChanged;
                textBox.KeyPress += textBox_KeyPress;
            }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            operation = "eraser";
            
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            operation = "line";
            pen.Color = color;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            operation = "pencil";
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.Color = color;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void buttonBrush_Click(object sender, EventArgs e)
        {
            operation = "brush";
            pen.Color = Color.FromArgb(50, color.R, color.G, color.B);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

        }
    }
}
