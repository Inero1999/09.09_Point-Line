using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _09._09_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            //ИЗ МЕТОДИЧКИ
            // тестирование обобщенного класса - 
            // точки в 2D
            Point2D<int> p1 = new Point2D<int>();
            WriteLine($"x = {p1.X} y = {p1.Y}");
            WriteLine(typeof(Point2D<int>));
            Point2D<double> p2 =new Point2D<double>(10.5, 20.5);
            WriteLine($"\nx = {p2.X} y = {p2.Y}");
            WriteLine(typeof(Point2D<double>));

            // ДОМАШНЕЕ ЗАДАНИЕ Создать необобщенный класс точки Point3D
            Point3D p3 = new Point3D();
            Point3D p4 = new Point3D(1,2,3);
            WriteLine(p3.ToString());
            WriteLine(p4.ToString());

            // ДОМАШНЕЕ ЗАДАНИЕ Создать обобщенный класс прямой на плоскости.
            Point < int > p5= new Point<int>();
            Point<int> p6 = new Point<int>(2,3);
            Line<int> l1 = new Line<int>(p5, p6);
            Line<double> l2 = new Line<double>(1.2, 2.3, 3.4, 4.5);
            WriteLine(l1.ToString());
            WriteLine(l2.ToString());
        }
    }
}
