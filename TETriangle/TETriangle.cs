using System;
using System.Collections.Generic;
using System.Text;

namespace TETriangle
{
    class TETriangle
    {
        private double a_;
        private double b_;
        private double c_;

        public TETriangle()
        {
            Random r = new Random();
            a_ = r.Next(1, 50);
            b_ = a_;
            c_ = a_;
        }

        public TETriangle(double a, double b, double c)
        {
            this.a_ = a;
            this.b_ = b;
            this.c_ = c;
        }

        public TETriangle(TETriangle copy)
        {
            a_ = copy.a_;
            b_ = copy.b_;
            c_ = copy.c_;
        }

        public double A
        {
            get { return a_; }
            set { a_ = value; }
        }

        public double B
        {
            get { return b_; }
            set { b_ = value; }
        }

        public double C
        {
            get { return c_; }
            set { c_ = value; }
        }

        override public string ToString()
        {
            return $"Довжини сторін рівностороннього трикутника {a_} см ";
        }

        public string Output(double a)
        {
            return a + "см";
        }

        public double CalculatePerimeter(TETriangle triangle)
        {
            return (triangle.a_ + triangle.b_ + triangle.c_);
        }

        public double CalculateArea(TETriangle triangle)
        {
            return (Math.Pow(triangle.a_, 2) * Math.Sqrt(3) / 4) ;
        }

        public bool Equals(TETriangle triangle, TETriangle triangle2)
        {
            if (triangle.a_ == triangle2.a_ && triangle.b_ == triangle2.b_ && triangle.c_ == triangle2.c_) return true;
            else return false;
        }
        public static TETriangle operator *(TETriangle triangle, double a)
        {
            TETriangle triangleMultiplied = new TETriangle(triangle.a_ * a, triangle.b_ * a, triangle.c_ * a);
            return triangleMultiplied;
        }

    }
}
