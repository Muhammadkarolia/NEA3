using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA3
{
    internal class Mass
    {
        public readonly string name;
        public BetterVector size;
       
        public BetterVector startPos;
        public BetterVector location;
        public BetterVector otherLocation;
        public BetterVector velocity = new BetterVector(0, 0);
        public BetterVector acceleration = new BetterVector(0, 0);
        public float mass;
        public float otherMass;

        public SolidBrush color;
        public float width;
        public float height;

        public Mass(String Name_, BetterVector Size_, BetterVector startPos_, SolidBrush sb)
        {
            name = Name_;
            size = Size_;
            startPos = startPos_; location = startPos_;
            color = sb;

            width = (float)size.x;
            height = (float)size.y;
        }   

        public void Move(BetterVector force)
        {
            BetterVector acc = new BetterVector();
            acc.Div(force, mass); // f = ma therefore a = f/m
            acceleration.Add(acc);

            // Since t = 1, v = u + a
            velocity.Add(acceleration); 
            location.Add(velocity);
            // reset acceleration
            acceleration.Mult(0);
        }

        public double getSpeed()
        {
            // a² + b² = c²
            double xSqr = velocity.x * velocity.x;
            double ySqr = velocity.y * velocity.y;
            Console.WriteLine(name + " " + Math.Sqrt(xSqr + ySqr));
            return Math.Sqrt(xSqr + ySqr);
        }
        public BetterVector centerLocation()
        {
            return new BetterVector(this.location.x + (this.width / 2), this.location.y + (this.height / 2));
        }
    }

}