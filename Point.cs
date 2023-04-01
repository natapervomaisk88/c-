using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPU221_NET
{
    internal class Point
    {
        private static int countObject;

        public int Y { get; set; }
        public int X { get; set; } //Делегируем создание скрытых полей компилятору
        /*При созданий свойства:
        1) Создаётся скрытое поле
        2) Создаётся геттер, которые возвращает значение этого поля
        3) Создаётся сеттер, который устанавливает значение для скрытого поля
        */

        //Свойства p.Y = 20
        //public int Y
        //{
        //    get { return y; }
        //    set
        //    {
        //        if (value > 0)
        //            y = value;
        //    }
        //}

        public override bool Equals(object obj)
        {
            Point point = obj as Point;
            if(X == point.X && Y == point.Y)
            {
                return true;
            }
            return false;
           // return base.Equals(obj);
        }
        public Point()
        {
            countObject++;
        }
        public Point(int x, int y)
        {
            countObject++;
            X = x;
            Y = y;
        }

        static Point()
        {
            Point.countObject = 0;
        }



        //public void ShowPoint()
        //{
        //    Console.WriteLine($"X: {X}, Y: {this.y}");
        //}

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        public static void GetCountObject()
        {
            Console.WriteLine(countObject);
        }

        public static Point operator +(Point obj, int a)
        {
            return new Point(obj.X + a, obj.Y + a);
        }

        public static Point operator +(int a, Point obj)
        {
            return new Point(obj.X + a, obj.Y + a);
        }
        //перегрузка инкремента
        public static Point operator ++(Point s)
        {
            s.X++;
            s.Y++;
            return s;
        }
        public static Point operator -(Point s)
        {
            return new Point { X = -s.X, Y = -s.Y };
        }
        //перегрузка декремента
        public static Point operator --(Point s)
        {
            s.X--;
            s.Y--;
            return s;
        }
        public static bool operator <=(Point p, int a)
        {
            if (p.X <= a && p.Y <= a)
                return true;
            return false;
        }
        public static bool operator >=(Point p, int a)
        {
            if (p.X >= a && p.Y >= a)
                return true;
            return false;
        }

        public static bool operator true(Point p)
        {
            if (p.X != 0 && p.Y != 0)
                return true;
            return false;
        }
        public static bool operator false(Point p)
        {
            return false;
        }
    }
}
