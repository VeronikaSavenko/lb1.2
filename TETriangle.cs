using System;
using System.Collections.Generic;
using System.Text;

namespace lb1._2
{
    public class TETriangle
    {
        protected double side;
        public TETriangle()
        {
            side = 5;
        }
        public TETriangle(double a)
        {
            if (a > 0) side = a;
            else throw new ArgumentException("Некоректне введення");
        }
        public TETriangle(TETriangle other)
        {
            side = other.side;
        }
        public double Side
        {
            get { return side; }
        }
        public double Perimetr()
        {
            return side * 3;
        }
        public double Square()
        {
            return (side * side * Math.Sqrt(3)) / 4;
        }
        public override string ToString()
        {
            return $"Рiвностороннiй трикутник iз стороною {side} має периметр {Perimetr()} та площу {Square()}";
        }
        public static TETriangle operator *(double multi, TETriangle triangle)
        {
            return new TETriangle(multi * triangle.side);
        }
        public static TETriangle operator *(TETriangle triangle, double multi)
        {
            return new TETriangle(multi * triangle.side);
        }
        public static bool operator ==(TETriangle t1, TETriangle t2)
        {
            return t1.side == t2.side;
        }
        public static bool operator !=(TETriangle t1, TETriangle t2)
        {
            return !(t1 == t2);
        }
    }
}
