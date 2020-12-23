using System;
using System.Collections.Generic;
using System.Text;

namespace TETriangle
{
    class TEPyramid:TETriangle
    {
        private double a_;
        private double b_;
        private double c_;
        private double h_;

        public TEPyramid()
        {
            Random ran = new Random();
            h_ = ran.Next(1, 50);
        }

        public TEPyramid(double a, double b, double с, double h) : base(a, b, с)
        {
            a_ = a;
            b_ = b;
            c_ = с;
            h_ = h;
        }

        public TEPyramid(TEPyramid copy)
        {
            a_ = copy.a_;
            b_ = copy.b_;
            c_ = copy.c_;
            h_ = copy.h_;
        }

        override public string ToString()
        {
            return $"Довжини сторін основи правильної трикутної піраміди {a_} см. Висота піраміди {h_} см";
        }

        public double CalculateVolume(TEPyramid pyramid)
        {
            return (h_ * a_ * a_ ) / (4 * Math.Sqrt(3));
        } 
    }
}
