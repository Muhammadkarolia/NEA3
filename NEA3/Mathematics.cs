using NEA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA3
{
    static class MathPlus
    {
        private const double G = 6.6743e-11; //0.000000000066743

        public static BetterVector ForceOfGrav(Mass m)
        {
            BetterVector forceVector = new BetterVector();
            forceVector.Sub(m.otherLocation, m.location);
            float distanceSqr = forceVector.Dist() * forceVector.Dist();

            double forceG = G * (m.mass * m.otherMass / distanceSqr);
            forceVector.Mult((float)forceG);

            return forceVector;
        }

        // Rnd function the mathPlus class
        public static Int64[] CheckInt(string varToCheck)
        {
            Int64 Temp;
            Int16 isInt = 0;
            if (Int64.TryParse(varToCheck, out Temp))
            {
                isInt = 1;
            }
            Int64[] array = { isInt, Temp };

            return array;
        }

        public static double[] CheckDouble(string varToCheck)
        {
            double Temp;
            double isDouble = 0;
            if (double.TryParse(varToCheck, out Temp))
            {
                isDouble = 1;
            }
            double[] array = { isDouble, Temp };

            return array;
        }
    }

    struct BetterVector
    {
        private double x_;
        private double y_;

        public BetterVector(double x, double y)
        {
            x_ = x;
            y_ = y;
        }

        public void Update(double x, double y)
        {
            x_ = x;
            y_ = y;
        }

        public double x
        {
            get
            {
                return x_;
            }
        }

        public double y
        {
            get
            {
                return y_;
            }
        }

        public void Add(BetterVector v)
        {
            x_ += v.x_;
            y_ += v.y_;
        }

        public void Sub(BetterVector v1, BetterVector v2)
        {
            x_ = v1.x_ - v2.x_; y_ = v1.y_ - v2.y_;
        }

        public void Mult(double Num)
        {
            x_ *= Num;
            y_ *= Num;
        }

        public void Div(BetterVector v, float number)
        {
            x_ = v.x / number;
            y_ = v.y / number;
        }

        public float Dist()
        {
            // root (x² + y²)
            return (float)Math.Sqrt(x_ * x_ + y_ * y_);
        }

    }
}