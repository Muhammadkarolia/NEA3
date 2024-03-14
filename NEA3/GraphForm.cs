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

        Graphics g = null;

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
            Pen pen = new Pen(Color.Black, 3);
            //foreach (Point Item in coords)
            //{
            //    Console.WriteLine(Item);
            //}
            Point[] linePointX = { new Point(30, 526), new Point(1100, 526) };
            Point[] linePointY = { new Point(30, 526), new Point(30, 12) };
            e.Graphics.DrawLines(pen, linePointX);
            e.Graphics.DrawLines(pen, linePointY);
            //Console.WriteLine(itemAdded + " bool item");
            if (itemAdded)
            {
                Console.WriteLine("Is ran");
                Temp.Add(coords.Dequeue());
                Temp.Add(coords.Peek());

                Point[] points = Temp.ToArray();
                e.Graphics.DrawLines(pen, points);
                foreach(Point item in Temp)
                {
                    Console.WriteLine(item);
                }
                itemAdded = false;
            }
        }
        
        public void AddToPoint(Point coords_)
        {
            coords.Enqueue(coords_);
            Console.WriteLine(coords.Count());
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
            Console.WriteLine("RESET");
        }

        private void GraphForm_Load(object sender, EventArgs e) { }
    }
}
