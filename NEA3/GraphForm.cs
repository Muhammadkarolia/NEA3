using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA3
{
    public partial class GraphForm : Form
    {
        private Queue<Point> coords1 = new Queue<Point>();
        private List<Point> Temp1 = new List<Point>();
        private Queue<Point> coords2 = new Queue<Point>();
        private List<Point> Temp2 = new List<Point>();
        private Point[] linePointX = { new Point(30, 150), new Point(1100, 150) };
        private Point[] linePointY = { new Point(30, 150), new Point(30, 650) };
        private Pen pen = new Pen(Color.Black, 3);

        private bool itemAdded = false;
        private bool itemAdded2 = false;
        private bool isChange = false;

        public GraphForm()
        {
            InitializeComponent();
            coords1.Enqueue(new Point(30, 150));
        }

        public void drawPanel1(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(1.0F, -1.0F);
            e.Graphics.TranslateTransform(0.0F, -(float)Height);

            e.Graphics.DrawLines(pen, linePointX);
            e.Graphics.DrawLines(pen, linePointY);
            if (itemAdded)
            {
                Temp1.Add(coords1.Dequeue());
                Temp1.Add(coords1.Peek());

                Point[] points = Temp1.ToArray();
                e.Graphics.DrawLines(pen, points);
                itemAdded = false;
            }
            itemAdded = false;
        }

        public void drawPanel2(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(1.0F, -1.0F);
            e.Graphics.TranslateTransform(0.0F, -(float)Height);

            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLines(pen, linePointX);
            e.Graphics.DrawLines(pen, linePointY);
            if (itemAdded2)
            {
                Temp2.Add(coords2.Dequeue());
                Temp2.Add(coords2.Peek());

                Point[] points = Temp2.ToArray();
                e.Graphics.DrawLines(pen, points);
                itemAdded2 = false;
            }
            itemAdded2 = false;
        }

        public void AddPoint(Point coords1_, Point coords2_)
        {
            coords1.Enqueue(coords1_); coords2.Enqueue(coords2_);
            itemAdded = true; itemAdded2 = true;
            mass1Panel.Refresh(); mass2Panel.Refresh();
        }

        public void Reset()
        {
            Temp1.Clear(); Temp2.Clear();
            coords1.Clear(); coords2.Clear();
            coords1.Enqueue(new Point(30, 526)); coords2.Enqueue(new Point(30, 526));
            itemAdded = false; itemAdded2 = true;
            mass1Panel.Refresh(); mass2Panel.Refresh();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (!isChange) { mass2Panel.Show(); isChange = true; }
            else { mass2Panel.Hide(); isChange = false; }
        }

        public bool isChanged()
        {
            return isChange;
        }

        private void GraphForm_Load(object sender, EventArgs e) { }
    }
}

