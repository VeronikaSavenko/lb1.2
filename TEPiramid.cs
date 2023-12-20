using System;
using System.Collections.Generic;
using System.Text;

namespace lb1._2
{
    class TEPiramid : TETriangle
    {
        protected double height;
        public TEPiramid()
        {
            height = 3;
        }
        public TEPiramid(double a, double h) : base(a)
        {
            if (h > 0) height = h;
            else throw new ArgumentException("Некоректне введення");
        }
        public TEPiramid(TEPiramid other) : base(other)
        {
            height = other.height;
        }
        public double Height
        {
            get { return height; }
        }
        public double Volume()
        {
            return (height * Side * Side) / (Math.Sqrt(3) * 4);
        }
        public override string ToString()
        {
            return $"Правильна трикутна пiрамiда iз стороною {Side} та висотою {height} має об'єм {Volume()}";
        }
        public static bool operator ==(TEPiramid p1, TEPiramid p2)
        {
            return p1.Side == p2.Side && p1.height == p2.height;
        }
        public static bool operator !=(TEPiramid p1, TEPiramid p2)
        {
            return !(p1 == p2);
        }
        public static TEPiramid operator *(double multi, TEPiramid pyramid)
        {
            return new TEPiramid(multi * pyramid.Side, multi * pyramid.height);
        }

        public static TEPiramid operator *(TEPiramid pyramid, double multi)
        {
            return new TEPiramid(multi * pyramid.Side,multi * pyramid.height);
        }
    }
}
