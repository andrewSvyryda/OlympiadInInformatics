using System;
using System.IO;

namespace Task5
{
    class Point
    {
        public int X{ get; set; }
        public int Y{ get; set; }
    }

    class Triangle
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }

        private double GetSideLength(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public double GetArea()
        {
            double side1 = GetSideLength(Point1, Point2);
            double side2 = GetSideLength(Point1, Point3);
            double side3 = GetSideLength(Point3, Point2);
            double halfPerimetre = (side1 + side2 + side3) / 2;

            if (!File.Exists("RESULT.txt"))
            {
                File.Create("RESULT.txt").Close();
            }

            double Area = Math.Sqrt(halfPerimetre * (halfPerimetre - side1) * (halfPerimetre - side2) * (halfPerimetre - side3));

            File.WriteAllText("RESULT.txt", Area.ToString());

            return Area;
        }

        public void ReadDataFromFile(string fileName)
        {
            string text = File.ReadAllText(fileName);
            string[] sides = text.Split(',');
            Point[] points = new Point[3];

            for (int i = 0; i < sides.Length; i++)
            {
                string[] res = sides[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(res[0]);
                Console.WriteLine(res[1]);
                points[i] = new Point { X = int.Parse(res[0]), Y = int.Parse(res[1]) };
            }

            Point1 = points[0];
            Point2 = points[1];
            Point3 = points[2];
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.ReadDataFromFile("DANO.txt");
            Console.WriteLine(triangle.GetArea());
        }
    }
}
