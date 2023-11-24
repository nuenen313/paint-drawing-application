namespace drawing
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
            this.controls = new System.Windows.Forms.Panel();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controls
            // 
            this.controls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.controls.Controls.Add(this.buttonColor);
            this.controls.Controls.Add(this.buttonPencil);
            this.controls.Controls.Add(this.buttonLine);
            this.controls.Controls.Add(this.buttonErase);
            this.controls.Location = new System.Drawing.Point(12, 12);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(1064, 72);
            this.controls.TabIndex = 0;
            // 
            // buttonPencil
            // 
            this.buttonPencil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPencil.BackColor = System.Drawing.Color.White;
            this.buttonPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPencil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPencil.Image = global::drawing.Properties.Resources.pencil;
            this.buttonPencil.Location = new System.Drawing.Point(996, 3);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(66, 66);
            this.buttonPencil.TabIndex = 7;
            this.buttonPencil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPencil.UseVisualStyleBackColor = false;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLine.BackColor = System.Drawing.Color.White;
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLine.Image = global::drawing.Properties.Resources.line;
            this.buttonLine.Location = new System.Drawing.Point(852, 3);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(66, 66);
            this.buttonLine.TabIndex = 1;
            this.buttonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonErase.BackColor = System.Drawing.Color.White;
            this.buttonErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErase.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonErase.Image = global::drawing.Properties.Resources.eraser;
            this.buttonErase.Location = new System.Drawing.Point(924, 3);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(66, 66);
            this.buttonErase.TabIndex = 2;
            this.buttonErase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonErase.UseVisualStyleBackColor = false;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1106, 692);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonColor.Location = new System.Drawing.Point(3, 3);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(66, 66);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 692);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

