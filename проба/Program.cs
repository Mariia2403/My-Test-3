using System;

//Правило : перевизначайте GetHeshCode первизначаючи Equals

namespace ClassObject

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object obj1 = new Object();
            Object obj2 = new Object();
            Console.WriteLine(obj1.Equals(obj2));
        }
    }
    public class Point : object

    {

        protected int x, y;

        public Point(int xValue, int yValue)

        {
            x = xValue;

            y = yValue;

        }

        public override bool Equals(object obj)

        {

            if (obj == null || this.GetType() != obj.GetType())

                return false;

            Point p = (Point)obj;

            return (x == p.x) && (y == p.y);

        }

       /* public override int GetHashCode()

        {

            return x ^ y;

        }*/

    }
}