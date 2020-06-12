using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Round
    {
        public Point Center { get; set; }

        public double Radius { get; set; }

        public Round() { }

        public Round(double radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public double RoundArea
        {
            get { return Math.PI * Radius * Radius; }
        }

        public double Roundference
        {
            get { return Math.PI * 2 * Radius; }
        }

        //public bool IsInside(Point point)
        //{         
        //    Point vector = new Point(point.x - Center.x, point.y - Center.y);
        //    double distance = vector.x * vector.x + vector.y * vector.y;
        //    return distance <= Radius * Radius;
        //}

        //public WhatthePoint()
        //{
        //    bool a = IsInside(Center);
        //    if (a == true)
        //    {
        //        Console.WriteLine("Точка принадлежит окружности");
        //        return;
             
        //    }
        //    else
        //    {
        //        Console.WriteLine("Точка не принадлежит окружности");
        //    }
            
        //}

        public override string ToString()
        {
            return String.Format("Radius: {0}; Center: {1}", Radius, Center);
        }






    }
}
