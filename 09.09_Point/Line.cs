using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._09_Point
{

    //Обобщенный класс прямой на плоскости.
    public class Line <T>
    {
            
        Point<T> p1;
        Point<T> p2;

        public Line(Point<T> p1, Point<T> p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Line(T x1, T y1, T x2, T y2)
        {
            this.p1 = new Point<T>(x1, y1);
            this.p2 = new Point<T>(x2, y2);
        }

        public override string ToString()
        {
            return $"\n Линия. Начальная точка X1 = {p1.X} Y1 = {p1.Y} " +
                   $" Конечная точка X2 ={p2.X} Y2 ={p2.Y} " +
                   $"\n {typeof(Line<T>)}";
        }

    }
}
