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
        private Queue<Point> coords = new Queue<Point>();
        private List<Point> Temp = new List<Point>();
        private bool itemAdded = false;

        public GraphForm()
        {
            InitializeComponent();
            coords.Enqueue(new Point(30, 526));
        }

        public void draw(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(1.0F, -1.0F);
            e.Graphics.TranslateTransform(0.0F, -(float)Height);
            
            Pen pen = new Pen(Color.Black, 3);
            Point[] linePointX = { new Point(30, 150), new Point(1100, 150) };
            Point[] linePointY = { new Point(30, 150), new Point(30, 650) };
            e.Graphics.DrawLines(pen, linePointX);
            e.Graphics.DrawLines(pen, linePointY);
            if (itemAdded)
            {
                Temp.Add(coords.Dequeue());
                Temp.Add(coords.Peek());

                Point[] points = Temp.ToArray();
                e.Graphics.DrawLines(pen, points);
                itemAdded = false;
            }
        }
        
        public void AddPoint(Point coords_)
        {
            coords.Enqueue(coords_);
            itemAdded = true;
            mainPanel.Refresh();
        }

        public void Reset()
        {
            Temp.Clear();
            coords.Clear();
            coords.Enqueue(new Point(30, 526));
            itemAdded = false;
            mainPanel.Refresh();
        }

        private void GraphForm_Load(object sender, EventArgs e) { }
    }
}
