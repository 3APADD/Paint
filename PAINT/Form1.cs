using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(map);
            graphics.Clear(Color.White);
            pictureBox1.Image = map;
        }

        Bitmap map;
        Graphics graphics;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.White, 3f);
        Pen eraser = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;
        ColorDialog dlg = new ColorDialog();
        Color new_color;
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                graphics.DrawLine(pen, cX, cY, x, y);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    graphics.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    graphics.DrawLine(pen, cX, cY, x, y);
                }
            }
            
        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    graphics.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        

        private void button_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void button_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void button_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pictureBox1, e.Location);
                Fill(map, point.X, point.Y, new_color);
            }
        }

        private void button_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }


        private void button_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); 
            open.Filter = "Image Files(*.png;)|*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName); 
            }

        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Image = map;
            index = 0;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "png(*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(dialog.FileName);
                }
            }
        }

        private void button_pallete_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
            new_color = dlg.Color;
            button_color.BackColor = dlg.Color;
            pen.Color = dlg.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f *pb.Width / pb.Width;
            float pY = 1f *pb.Height / pb.Height;
            return new Point((int)(pt.X*pX), (int)(pt.Y*pY));
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> sp = new Stack<Point>();
            sp.Push(new Point(x, y));
            bm.SetPixel(x, y, new_color);
            if (old_color == new_color) return;

            while (sp.Count > 0)
            {
                Point pt = (Point)sp.Pop();
                if (pt.X >0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, sp, pt.X - 1, pt.Y, old_color, new_color);
                    validate(bm, sp, pt.X, pt.Y - 1, old_color, new_color);
                    validate(bm, sp, pt.X + 1, pt.Y, old_color, new_color);
                    validate(bm, sp, pt.X, pt.Y + 1, old_color, new_color);
                }
            }
        }
    }
}
