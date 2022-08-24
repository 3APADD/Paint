namespace PAINT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_color = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_pallete = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.button_fill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button_color);
            this.panel1.Controls.Add(this.button_pallete);
            this.panel1.Controls.Add(this.button_line);
            this.panel1.Controls.Add(this.button_rectangle);
            this.panel1.Controls.Add(this.button_ellipse);
            this.panel1.Controls.Add(this.button_eraser);
            this.panel1.Controls.Add(this.button_pencil);
            this.panel1.Controls.Add(this.button_fill);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 49);
            this.panel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 1);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(191, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.Color.White;
            this.button_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_color.Location = new System.Drawing.Point(502, 15);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(30, 30);
            this.button_color.TabIndex = 3;
            this.button_color.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // button_pallete
            // 
            this.button_pallete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pallete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_pallete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_pallete.ForeColor = System.Drawing.Color.Transparent;
            this.button_pallete.Image = global::PAINT.Properties.Resources.color;
            this.button_pallete.Location = new System.Drawing.Point(538, 3);
            this.button_pallete.Name = "button_pallete";
            this.button_pallete.Size = new System.Drawing.Size(41, 42);
            this.button_pallete.TabIndex = 4;
            this.button_pallete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_pallete.UseVisualStyleBackColor = true;
            this.button_pallete.Click += new System.EventHandler(this.button_pallete_Click);
            // 
            // button_line
            // 
            this.button_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_line.ForeColor = System.Drawing.Color.Transparent;
            this.button_line.Image = global::PAINT.Properties.Resources.line;
            this.button_line.Location = new System.Drawing.Point(820, 3);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(41, 42);
            this.button_line.TabIndex = 10;
            this.button_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_rectangle.ForeColor = System.Drawing.Color.Transparent;
            this.button_rectangle.Image = global::PAINT.Properties.Resources.rectangle;
            this.button_rectangle.Location = new System.Drawing.Point(773, 3);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(41, 42);
            this.button_rectangle.TabIndex = 9;
            this.button_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_ellipse
            // 
            this.button_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ellipse.ForeColor = System.Drawing.Color.Transparent;
            this.button_ellipse.Image = global::PAINT.Properties.Resources.circle;
            this.button_ellipse.Location = new System.Drawing.Point(726, 3);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(41, 42);
            this.button_ellipse.TabIndex = 8;
            this.button_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ellipse.UseVisualStyleBackColor = true;
            this.button_ellipse.Click += new System.EventHandler(this.button_ellipse_Click);
            // 
            // button_eraser
            // 
            this.button_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_eraser.ForeColor = System.Drawing.Color.Transparent;
            this.button_eraser.Image = global::PAINT.Properties.Resources.eraser;
            this.button_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_eraser.Location = new System.Drawing.Point(679, 3);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(41, 42);
            this.button_eraser.TabIndex = 7;
            this.button_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_eraser.UseVisualStyleBackColor = true;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // button_pencil
            // 
            this.button_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_pencil.ForeColor = System.Drawing.Color.Transparent;
            this.button_pencil.Image = global::PAINT.Properties.Resources.pencil;
            this.button_pencil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_pencil.Location = new System.Drawing.Point(632, 3);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(41, 42);
            this.button_pencil.TabIndex = 6;
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_pencil.UseVisualStyleBackColor = true;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
            // 
            // button_fill
            // 
            this.button_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fill.ForeColor = System.Drawing.Color.Transparent;
            this.button_fill.Image = global::PAINT.Properties.Resources.bucket;
            this.button_fill.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_fill.Location = new System.Drawing.Point(585, 3);
            this.button_fill.Name = "button_fill";
            this.button_fill.Size = new System.Drawing.Size(41, 42);
            this.button_fill.TabIndex = 5;
            this.button_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_fill.UseVisualStyleBackColor = true;
            this.button_fill.Click += new System.EventHandler(this.button_fill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 487);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button_pallete;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Button button_pencil;
        private System.Windows.Forms.Button button_fill;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_ellipse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

