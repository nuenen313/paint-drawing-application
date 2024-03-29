﻿namespace drawing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controls = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCurve = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCurrentColor = new System.Windows.Forms.Button();
            this.controls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controls
            // 
            this.controls.BackColor = System.Drawing.Color.White;
            this.controls.Controls.Add(this.panel1);
            this.controls.Location = new System.Drawing.Point(1345, 40);
            this.controls.MaximumSize = new System.Drawing.Size(891, 180);
            this.controls.MinimumSize = new System.Drawing.Size(891, 73);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(891, 73);
            this.controls.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(161, 174);
            this.panel1.MinimumSize = new System.Drawing.Size(161, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 66);
            this.panel1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Image = global::drawing.Properties.Resources.size4;
            this.button5.Location = new System.Drawing.Point(0, 146);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 27);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Image = global::drawing.Properties.Resources.size3;
            this.button4.Location = new System.Drawing.Point(0, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 27);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = global::drawing.Properties.Resources.size2;
            this.button3.Location = new System.Drawing.Point(0, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 27);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = global::drawing.Properties.Resources.sizes;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Size";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = global::drawing.Properties.Resources.size1;
            this.button2.Location = new System.Drawing.Point(0, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 27);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1891, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.saveToolStripMenuItem.Text = "Save file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.loadFileToolStripMenuItem.Text = "Load file";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonCurrentColor);
            this.panel2.Controls.Add(this.buttonCurve);
            this.panel2.Controls.Add(this.buttonRectangle);
            this.panel2.Controls.Add(this.buttonSquare);
            this.panel2.Controls.Add(this.buttonEllipse);
            this.panel2.Controls.Add(this.buttonCircle);
            this.panel2.Controls.Add(this.buttonBrush);
            this.panel2.Controls.Add(this.buttonText);
            this.panel2.Controls.Add(this.buttonFont);
            this.panel2.Controls.Add(this.buttonPencil);
            this.panel2.Controls.Add(this.buttonColor);
            this.panel2.Controls.Add(this.buttonErase);
            this.panel2.Controls.Add(this.buttonLine);
            this.panel2.Location = new System.Drawing.Point(356, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 73);
            this.panel2.TabIndex = 4;
            // 
            // buttonCurve
            // 
            this.buttonCurve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCurve.BackColor = System.Drawing.Color.White;
            this.buttonCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurve.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCurve.Image = global::drawing.Properties.Resources.curve;
            this.buttonCurve.Location = new System.Drawing.Point(384, 3);
            this.buttonCurve.Name = "buttonCurve";
            this.buttonCurve.Size = new System.Drawing.Size(66, 66);
            this.buttonCurve.TabIndex = 17;
            this.buttonCurve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCurve.UseVisualStyleBackColor = false;
            this.buttonCurve.Click += new System.EventHandler(this.buttonCurve_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRectangle.BackColor = System.Drawing.Color.White;
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRectangle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRectangle.Image = global::drawing.Properties.Resources.rectangle;
            this.buttonRectangle.Location = new System.Drawing.Point(672, 3);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(66, 66);
            this.buttonRectangle.TabIndex = 16;
            this.buttonRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSquare.BackColor = System.Drawing.Color.White;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquare.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSquare.Image = global::drawing.Properties.Resources.shape_square;
            this.buttonSquare.Location = new System.Drawing.Point(600, 3);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(66, 66);
            this.buttonSquare.TabIndex = 15;
            this.buttonSquare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEllipse.BackColor = System.Drawing.Color.White;
            this.buttonEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEllipse.Image = global::drawing.Properties.Resources.ellipse;
            this.buttonEllipse.Location = new System.Drawing.Point(528, 3);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(66, 66);
            this.buttonEllipse.TabIndex = 14;
            this.buttonEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCircle.BackColor = System.Drawing.Color.White;
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCircle.Image = global::drawing.Properties.Resources.circle;
            this.buttonCircle.Location = new System.Drawing.Point(456, 3);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(66, 66);
            this.buttonCircle.TabIndex = 13;
            this.buttonCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBrush.BackColor = System.Drawing.Color.White;
            this.buttonBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrush.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrush.Image = global::drawing.Properties.Resources.brush2;
            this.buttonBrush.Location = new System.Drawing.Point(917, 3);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(66, 66);
            this.buttonBrush.TabIndex = 12;
            this.buttonBrush.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBrush.UseVisualStyleBackColor = false;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonText
            // 
            this.buttonText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonText.Image = global::drawing.Properties.Resources.text;
            this.buttonText.Location = new System.Drawing.Point(3, 3);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(66, 66);
            this.buttonText.TabIndex = 9;
            this.buttonText.Text = "Text";
            this.buttonText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonText.UseVisualStyleBackColor = false;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFont.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFont.Image = global::drawing.Properties.Resources.font;
            this.buttonFont.Location = new System.Drawing.Point(75, 3);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(66, 66);
            this.buttonFont.TabIndex = 10;
            this.buttonFont.Text = "Font";
            this.buttonFont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFont.UseVisualStyleBackColor = false;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPencil.BackColor = System.Drawing.Color.White;
            this.buttonPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPencil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPencil.Image = global::drawing.Properties.Resources.pencil;
            this.buttonPencil.Location = new System.Drawing.Point(845, 3);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(66, 66);
            this.buttonPencil.TabIndex = 7;
            this.buttonPencil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPencil.UseVisualStyleBackColor = false;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonColor.Image = global::drawing.Properties.Resources.colors;
            this.buttonColor.Location = new System.Drawing.Point(147, 3);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(66, 66);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color";
            this.buttonColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonErase.BackColor = System.Drawing.Color.White;
            this.buttonErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErase.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonErase.Image = global::drawing.Properties.Resources.eraser;
            this.buttonErase.Location = new System.Drawing.Point(773, 3);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(66, 66);
            this.buttonErase.TabIndex = 2;
            this.buttonErase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonErase.UseVisualStyleBackColor = false;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLine.BackColor = System.Drawing.Color.White;
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLine.Image = global::drawing.Properties.Resources.line;
            this.buttonLine.Location = new System.Drawing.Point(312, 3);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(66, 66);
            this.buttonLine.TabIndex = 1;
            this.buttonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1513, 895);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // buttonCurrentColor
            // 
            this.buttonCurrentColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCurrentColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurrentColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCurrentColor.Location = new System.Drawing.Point(219, 3);
            this.buttonCurrentColor.Name = "buttonCurrentColor";
            this.buttonCurrentColor.Size = new System.Drawing.Size(66, 66);
            this.buttonCurrentColor.TabIndex = 18;
            this.buttonCurrentColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCurrentColor.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 895);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.controls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonCurve;
        private System.Windows.Forms.Button buttonCurrentColor;
    }
}

