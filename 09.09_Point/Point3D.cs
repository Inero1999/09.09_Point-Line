using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._09_Point
{
    class Point3D:Point2D<int>
    {

        // НЕОБОБЩЕННЫЙ КЛАСС Point3D
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Point3D()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public override string ToString()
        {
            return $"\nX = {X} Y = {Y} Z={Z} \n {typeof(Point3D)}";
        }


    }
}
