using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NEA3
{
    public partial class Form1 : Form
    {
        // Stuff to do with masses
        private static BetterVector m1I = new BetterVector(300, 200);
        private static BetterVector m2I = new BetterVector(500, 400);
        private static Mass mass1 = new Mass("Mass1", new BetterVector(17, 17), m1I, new SolidBrush(Color.Blue));
        private static Mass mass2 = new Mass("Mass2", new BetterVector(17, 17), m2I, new SolidBrush(Color.Red));
        private static List<Mass> listMasses = new List<Mass>();
        private double xStartingForce1; // maybey TODO: Also add velocity 
        private double yStartingForce1;
        private double xStartingForce2; 
        private double yStartingForce2;
        private List<Point> orbitLines1 = new List<Point>();
        private List<Point> orbitLines2 = new List<Point>();

        private bool isRunning = false;
        private bool mouseDown = false;
        private bool mouseMovingMass1 = false;
        private bool mouseMovingMass2 = false;
        private bool graphFormActive = false;
        // This will allow the program to know if it has alredy been ran once
        // I update the strarting force in the Start_Click func
        // This means that evreytime I click it it will reset the force
        // This bool stops that
        private bool canRun = false;

        private GraphForm graphForm = new GraphForm();
        private int xGraph = 30;

        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphForm.Hide();
            listMasses.Add(mass1); listMasses.Add(mass2);

            foreach (Mass mass in listMasses)
            {
                mass.location = mass.startPos;
            }
        }

        // handels painting of mainPanel
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (isRunning)
            {
                foreach (Mass x in listMasses)
                {
                    foreach (Mass y in listMasses)
                    {
                        if (x != y)
                        {
                            makeGravHappen(x, y);
                        }
                    }
                }
            }

            foreach (Mass mass in listMasses)
            {
                Draw(mass, e.Graphics);
            }
        }

        private void makeGravHappen(Mass m1, Mass m2)
        {
            m1.otherMass = m2.mass;
            m1.location.Update(m1.location.x, m1.location.y);
            m1.otherLocation.Update(m2.location.x, m2.location.y);
            BetterVector force = MathPlus.ForceOfGrav(m1);
            m1.Move(force);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (canRun) 
            { 
                isRunning = true;
                timer1.Start();
                Stop.Enabled = true;
                Start.Enabled = false;
            }
            else 
            { IsValuesCorrect.Text = "Update values before pressing start"; }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stop.Enabled = false;
            Start.Enabled = true;
            isRunning = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Location Text Box
            string mass1Loc = $"X: {(int)mass1.location.x} Y: {(int)mass1.location.y}";
            string mass2Loc = $"X: {(int)mass2.location.x} Y: {(int)mass2.location.y}";
            locationBox.Text = mass1Loc; 
            locationBox.AppendText(Environment.NewLine);
            locationBox.AppendText(mass2Loc);

            // Graph work
            Point Coords1 = new Point(xGraph, 50 * (int)mass1.getSpeed() + 150);
            Point Coords2 = new Point(xGraph, 50 * (int)mass2.getSpeed() + 150);
            if (graphFormActive & isRunning) { graphForm.AddPoint(Coords1, Coords2); }
            xGraph += 1;
            
            mainPanel.Refresh();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            isRunning = false;
            Start.Enabled = true;
            Stop.Enabled = false;
            canRun = false;
            xStartingForce1 = 0;    yStartingForce1 = 0;
            orbitLines1.Clear();    orbitLines2.Clear();
            xGraph = 30;

            // Resets location, velosity and accselration
            foreach (Mass mass in listMasses)
            {
                mass.location = mass.startPos;
                mass.velocity.Update(0, 0);
                mass.acceleration.Update(0, 0);
            }

            timer1.Stop();
            mainPanel.Refresh();                
            graphForm.Reset();
        }

        private void Draw(Mass Mass_, Graphics g)
        {
            // Draw mass
            float x = (float)Mass_.location.x;
            float y = (float)Mass_.location.y;
            g.FillEllipse(Mass_.color, x, y, Mass_.width, Mass_.height);

            // Draw movement line thing
            float x1 = (float)Mass_.location.x + (float)Mass_.velocity.x * 10;
            float y2 = (float)Mass_.location.y + (float)Mass_.velocity.y * 10;
            if (!(Mass_.getSpeed() < 1)) // pen, x1, y1, x2, y2
            { g.DrawLine(new Pen(Color.Green) { Width = 3, EndCap = LineCap.ArrowAnchor }, x + 10, y + 10, x1, y2); }

            // Draw orbit line
            Point[] foo;
            try
            {
                if (Mass_.name == "Mass1")
                {
                    orbitLines1.Add(new Point((int)x + 10, (int)y + 10));
                    foo = orbitLines1.ToArray();
                    g.DrawLines(new Pen(Color.White) { Width = 2 }, foo);
                    if(orbitLines1.Count > 500) // TODO: Make input
                    {
                        orbitLines1.RemoveRange(0, 1);
                    }
                }
                else
                {
                    orbitLines2.Add(new Point((int)x + 10, (int)y + 10));
                    foo = orbitLines2.ToArray();
                    g.DrawLines(new Pen(Color.White) { Width = 2 }, foo);
                    if (orbitLines2.Count > 500) // TODO: Make input
                    {
                        orbitLines2.RemoveRange(0, 1);
                    }
                }
            } catch { }
        }
        private void ValueUpdate_Click(object sender, EventArgs e)
        {
            bool firstCheck = false;
            bool secCheck = false;

            // The first item returened will be either 1 or 0
            // if it is 0 then the txt is no possialbe be int
            // the secound item is the converted text#
            // Not expandalbe, TOODO: Make expandalbe
            Int64[] firstMassBox = MathPlus.CheckInt(Mass1tb.Text);
            Int64[] secMassBox = MathPlus.CheckInt(Mass2tb.Text);

            // For first mass Force
            double[] StartForceX1 = MathPlus.CheckDouble(XStartForce1.Text);
            double[] StartForceY1 = MathPlus.CheckDouble(YStartForce1.Text);
            // For sec mass Force
            double[] StartForceX2 = MathPlus.CheckDouble(XStartForce2.Text);
            double[] StartForceY2 = MathPlus.CheckDouble(YStartForce2.Text);

            if (firstMassBox[0] == 1 & secMassBox[0] == 1)
            {
                mass1.mass = firstMassBox[1];
                mass2.mass = secMassBox[1];
                firstCheck = true;
            }

            if (StartForceX1[0] == 1 & StartForceY1[0] == 1)
            {
                xStartingForce1 = StartForceX1[1];
                yStartingForce1 = StartForceY1[1];
                mass1.velocity.Update(xStartingForce1, yStartingForce1);
                if (StartForceX2[0] == 1 & StartForceY2[0] == 1)
                {
                    xStartingForce2 = StartForceX2[1];
                    yStartingForce2 = StartForceY2[1];
                    mass2.velocity.Update(xStartingForce2, yStartingForce2);
                    secCheck = true;
                }
            }

            // Changes IsValuesCorrect based on wich inputs are incorrect
            if (firstCheck & secCheck) {canRun = true; IsValuesCorrect.Text = "Values updated successfully";} 
            else if (!firstCheck & !secCheck) { IsValuesCorrect.Text = "Multiple bad inputs"; }
            else if (!firstCheck) { IsValuesCorrect.Text = "Bad mass input"; }
            else { IsValuesCorrect.Text = "Bad force input"; }
        }

        private void LocationUpdate_Click(object sender, EventArgs e)
        {
            bool check = false;

            Int64[] x1 = MathPlus.CheckInt(m1X.Text);
            Int64[] y1 = MathPlus.CheckInt(m1Y.Text);
            Int64[] x2 = MathPlus.CheckInt(m2X.Text);
            Int64[] y2 = MathPlus.CheckInt(m2Y.Text);

            if (x1[0] == 1 & y1[0] == 1)
            {
                if (x2[0] == 1 & y2[0] == 1)
                {
                    mass1.location.Update(x1[1], y1[1]);
                    mass2.location.Update(x2[1], y2[1]);
                    check = true;
                } 
            }

            if (check) { IsValuesCorrect.Text = "location updated succsefuly"; }
            else { IsValuesCorrect.Text = "Bad location input"; }
        }

        public void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            isRunning = false;
        }

        public void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            mouseMovingMass1 = false;
            mouseMovingMass2 = false;
            if (canRun & !Start.Enabled) { isRunning = true; }
        }

        public void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point cursorPos = PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
            double cursorX = cursorPos.X - 15;
            double cursorY = cursorPos.Y - 12;

            double mass1X = mass1.location.x;
            double mass1Y = mass1.location.y;

            double mass2X = mass2.location.x;
            double mass2Y = mass2.location.y;

            if (mouseDown)
            {
                if (cursorX >= mass1X - 15 & cursorX <= mass1X + 15 &
                    cursorY >= mass1Y - 15 & cursorY <= mass1Y + 15 & !mouseMovingMass2)
                {
                    mass1.location.Update(cursorX, cursorY);
                    mouseMovingMass1 = true;
                    orbitLines1.Clear();
                    mainPanel.Refresh();
                }
                if (cursorX >= mass2X - 15 & cursorX <= mass2X + 15 &
                    cursorY >= mass2Y - 15 & cursorY <= mass2Y + 15 & !mouseMovingMass1)
                {
                    mass2.location.Update(cursorX, cursorY);
                    mouseMovingMass2 = true;
                    orbitLines2.Clear();
                    mainPanel.Refresh();
                }
            }
        }

        private void velGraph_Click(object sender, EventArgs e)
        {
            graphForm.Show();
            graphFormActive = true;
        }
    }
}