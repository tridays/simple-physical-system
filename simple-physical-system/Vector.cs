using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_physical_system
{
    class Vector
    {
        public double length;
        public double radian;

        public Vector(double l) : this(l, 0) { }

        public Vector(double l, double r)
        {
            length = l; radian = r;
        }

        public double x
        {
            get
            {
                return length * Math.Cos(radian);
            }
            set
            {
                length = Math.Sqrt(Math.Pow(value, 2) + Math.Pow(y, 2));
                radian = Math.Acos(value / length);
            }
        }

        public double y
        {
            get
            {
                return length * Math.Sin(radian);
            }
            set
            {
                length = Math.Sqrt(Math.Pow(value, 2) + Math.Pow(x, 2));
                radian = Math.Asin(value / length);
            }
        }

        public double degree
        {
            get
            {
                return radian / Math.PI * 180;
            }
            set
            {
                radian = value * Math.PI / 180;
            }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector ret = new Vector(v1.length, v1.radian);
            ret.x += v2.x;
            ret.y += v2.y;
            return ret;
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector ret = new Vector(v1.length, v1.radian);
            ret.x -= v2.x;
            ret.y -= v2.y;
            return ret;
        }

        public static double operator *(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }

        public static double dot(Vector v1, Vector v2)
        {
            return v1 * v2;
        }

        public static double cross(Vector v1, Vector v2)
        {
            // 仅返回了叉乘结果向量的模，方向可由 A x B = |A||B|Sin(θ) 得到
            return v1.x * v2.y - v1.y * v2.x;
        } 
        
    }
}
