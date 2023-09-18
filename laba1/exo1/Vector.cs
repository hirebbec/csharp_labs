using System;
namespace laba1
{
    public class Vector
    {
        private int x;
        private int y;
        private int z;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            int newX = v1.x + v2.x;
            int newY = v1.y + v2.y;
            int newZ = v1.z + v2.z;

            return new Vector(newX, newY, newZ);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            int newX = v1.x - v2.x;
            int newY = v1.y - v2.y;
            int newZ = v1.z - v2.z;

            return new Vector(newX, newY, newZ);
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

        public static int operator *(Vector v1, Vector v2)
        {
            int result = (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
            return result;
        }

        public double len()
        {
            return Math.Round(Math.Sqrt(Convert.ToDouble(x * x + y * y + z * z)), 2);
        }

        public double cos(Vector other)
        {
            return Math.Round((this * other) / (this.len() * other.len()), 2);
        }
    }
}
