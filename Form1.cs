using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
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
        string text;
        Point textBoxPoint;
        bool isCollapsed;
        int penSize = 5;
        Color color = Color.Black;
        private List<Point> points = new List<Point>();
        List<Control> textBoxes = new List<Control>();


        public Form1()
        {
            InitializeComponent();

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

            buttonCurrentColor.BackColor = Color.Black;

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
                buttonCurrentColor.BackColor = color;
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
                text = textBox.Text;
                e.Handled = true;
                Controls.Remove(textBox);
                textBox.Dispose();
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

        private void buttonCurve_Click(object sender, EventArgs e)
        {
            operation = "curve";
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            operation = "circle";
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            operation = "ellipse";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            operation = "square";
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            operation = "rect";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG Image|*.jpg";
                saveFileDialog.Title = "Save file";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    using (Bitmap bitmap2 = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                    {
                        pictureBox1.DrawToBitmap(bitmap2, pictureBox1.ClientRectangle);
                        bitmap2.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    }
                }
            }
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPEG Image|*.jpg";
                openFileDialog.Title = "Load file";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    graphics.Dispose();
                    bitmap.Dispose();
                    Image image = Image.FromFile(openFileDialog.FileName);
                    graphics = Graphics.FromImage(image);
                    pictureBox1.Image = image;
                    pictureBox1.Refresh();
                }
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (mouseMoving)
            {
                if (operation == "line")
                {
                    graphics.DrawLine(pen, startX, startY, endX, endY);
                }
                if (operation == "ellipse")
                {
                    graphics.DrawEllipse(pen, startX, startY, endX - startX, endY - startY);
                }
                if (operation == "circle")
                {
                    int width = Math.Abs(startX - endX);
                    int height = Math.Abs(startY - endY);
                    if (width > height)
                    {
                        endX = startX + height;
                    }
                    else
                    {
                        endY = startY + width;
                    }
                    graphics.DrawEllipse(pen, startX, startY, endX - startX, endY - startY);
                }
                if (operation == "rect")
                {
                    graphics.DrawRectangle(pen, startX, startY, endX - startX, endY - startY);
                }
                if (operation == "square")
                {
                    int width = Math.Abs(startX - endX);
                    int height = Math.Abs(startY - endY);
                    if (width > height)
                    {
                        endX = startX + height;
                    }
                    else
                    {
                        endY = startY + width;
                    }
                    graphics.DrawRectangle(pen, startX, startY, endX - startX, endY - startY);
                }
                if (operation == "curve" && points.Count >= 3)
                {
                    
                    points.Add(mouseEnd);
                    graphics.DrawCurve(pen, points.ToArray());
                    points.Remove(mouseEnd);
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
            points.Add(mouseEnd);

            switch (operation)
            {
                case "line":
                    graphics.DrawLine(pen, startX, startY, endX, endY);
                    points.Clear();
                    break;
                case "txt":
                    var textFont = font;
                    Brush textBrush = new SolidBrush(color);
                    graphics.DrawString(text, textFont, textBrush, textBoxPoint);
                    points.Clear();
                    break;
                case "ellipse":
                    graphics.DrawEllipse(pen, startX, startY, endX - startX, endY - startY);
                    points.Clear();
                    break;
                case "circle":
                    int width = Math.Abs(startX - endX);
                    int height = Math.Abs(startY - endY);
                    if (width > height)
                    {
                        endX = startX + height;
                    }
                    else
                    {
                        endY = startY + width;
                    }
                    graphics.DrawEllipse(pen, startX, startY, endX - startX, endY - startY);
                    points.Clear();
                    break;
                case "rect":
                    graphics.DrawRectangle(pen, startX, startY, endX - startX, endY - startY);
                    points.Clear();
                    break;
                case "square":
                    int width = Math.Abs(startX - endX);
                    int height = Math.Abs(startY - endY);
                    if (width > height)
                    {
                        endX = startX + height;
                    }
                    else
                    {
                        endY = startY + width;
                    }
                    graphics.DrawRectangle(pen, startX, startY, endX - startX, endY - startY);
                    points.Clear();
                    break;
                case "curve":
                    if (points.Count >= 3)
                    {
                        graphics.DrawCurve(pen, points.ToArray());
                        points.Clear();
                    }
                    break;
                default:
                    break;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMoving)
            {
                mouseEnd = e.Location;
            }

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
            endX = x;
            endY = y;

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStart = e.Location;
            points.Add(mouseStart);
            mouseMoving = true;

            startX = e.X;
            startY = e.Y;

        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (operation == "txt" && e.Button == MouseButtons.Left)
            {
                if (textBoxes.Count > 0)
                {
                    foreach (Control t in textBoxes)
                    {
                        this.Controls.Remove(t);
                        t.Dispose();

                    }
                }
                TextBox textBox = new TextBox();
                textBox.Multiline = true;
                textBox.ForeColor = color;
                textBox.Location = e.Location;
                textBoxPoint = e.Location;
                textBox.Size = new Size(100, 50);
                Controls.Add(textBox);
                textBoxes.Add(textBox);
                textBox.Font = font;
                textBox.BringToFront();
                textBox.TextChanged += textBox_TextChanged;
                textBox.KeyPress += textBox_KeyPress;
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (operation == "ellipse")
                {
                    operation = "circle";
                }
                if (operation == "rect")
                {
                    operation = "square";
                }
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
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.Color = color;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
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
