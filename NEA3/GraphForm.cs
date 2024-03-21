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
        private Point Orign = new Point(30, 100);
        private Point[] linePointX = { new Point(30, 100), new Point(1100,100) }; 
        private Point[] linePointY = { new Point(30, 100), new Point(30, 650) };
        // I get error CS0236 if I tried doing { Orign, new Point(1100,100) } or { Orign, new Point(30, 650) }
        // The fix would be longer then the currnt code hence the reason the orgin variable is not used hear
        private Pen pen = new Pen(Color.Black, 3);

        private bool itemAdded1 = false;
        private bool itemAdded2 = false;
        private bool isChange = false;

        public GraphForm()
        {
            InitializeComponent();
            coords1.Enqueue(Orign);
        }

        public void drawPanel1(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(1.0f, -1.0F);
            e.Graphics.TranslateTransform(0.0F, -(float)Height);

            e.Graphics.DrawLines(pen, linePointX);
            e.Graphics.DrawLines(pen, linePointY);
            if (itemAdded1)
            {
                Point[] points = Temp1.ToArray();
                e.Graphics.DrawLines(pen, points);
            }
            itemAdded1 = false;
        }

        public void drawPanel2(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(1.0F, -1.0F);
            e.Graphics.TranslateTransform(0.0F, -(float)Height);

            e.Graphics.DrawLines(pen, linePointX);
            e.Graphics.DrawLines(pen, linePointY);
            if (itemAdded2)
            {
                Point[] points = Temp2.ToArray();
                e.Graphics.DrawLines(pen, points);
            }
            itemAdded2 = false;
        }

        public void AddPoint(Point coords1_, Point coords2_)
        {
            coords1.Enqueue(coords1_); coords2.Enqueue(coords2_);
            try
            {
                Temp1.Add(coords1.Dequeue()); Temp1.Add(coords1.Peek());   
                Temp2.Add(coords2.Dequeue()); Temp2.Add(coords2.Peek());
            } catch { }
            itemAdded1 = true; itemAdded2 = true;
            if (isChange) { mass2Panel.Refresh(); }
            else { mass1Panel.Refresh(); }
        }

        public void Reset()
        {
            Temp1.Clear();           Temp2.Clear();
            coords1.Clear();         coords2.Clear();
            coords1.Enqueue(Orign);  coords2.Enqueue(Orign);
            itemAdded1 = false;      itemAdded2 = false;
            mass1Panel.Refresh();    mass2Panel.Refresh();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (!isChange) 
            { mass2Panel.Show(); isChange = true;  Identifier.Text = "Mass2 shown"; }
            else 
            { mass2Panel.Hide(); isChange = false; Identifier.Text = "Mass1 shown"; }
        }

        public bool isChanged()
        {
            return isChange;
        }

        private void GraphForm_Load(object sender, EventArgs e) { }
    }
}

