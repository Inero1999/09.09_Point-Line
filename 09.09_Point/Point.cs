﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._09_Point
{
   
    //Обощенный класс Точка
    public class Point<T>
    {


        public T X { get; set; }
        public T Y { get; set; }

        public Point()
        {
            X = default(T);
            Y = default(T);
        }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }


    }
}
