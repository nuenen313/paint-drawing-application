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
        Point mouseStart, mouseEnd;
        int x, y, startX, endX, startY, endY;
        string operation = "pencil";

        public Form1()
        {
            InitializeComponent();

            this.Width = 1100;
            this.Height = 600;
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;

            pen = new Pen(Color.Black, 5);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser = new Pen(Color.White, 15);
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMoving = true;
            mouseStart = e.Location;

            startX = e.X;
            startY = e.Y;

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseMoving == true && operation == "pencil")
            {
                mouseEnd = e.Location;
                graphics.DrawLine(pen, mouseEnd, mouseStart);
                mouseStart = mouseEnd;

            }
            if (mouseMoving == true && operation == "eraser")
            {
                mouseEnd = e.Location;
                graphics.DrawLine(eraser, mouseEnd, mouseStart );
                mouseStart = mouseEnd;
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;
            endX = e.X - startX;
            endY = e.Y - startY;

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
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            operation = "eraser";
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            operation = "line";
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            operation = "pencil";
        }
    }
}
