using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RehabFromHolidays
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }
        public static bool CanKnightReach(Point pointA, Point pointB)
        {
            int deltaX = (int)Math.Abs(pointA.X - pointB.X);
            int deltaY = (int)Math.Abs(pointA.Y - pointB.Y);

            return (deltaX == 1 && deltaY == 2) || (deltaX == 2 && deltaY == 1);
        }
    }
    public class Triangle
    {
        public Point Vertex1 { get; }
        public Point Vertex2 { get; }
        public Point Vertex3 { get; }

        public Triangle(Point v1, Point v2, Point v3)
        {
            Vertex1 = v1;
            Vertex2 = v2;
            Vertex3 = v3;
        }

        public double SideLength(Point p1, Point p2)
        {
            return p1.DistanceTo(p2);
        }

        public double Area()
        {
            double a = SideLength(Vertex2, Vertex3);
            double b = SideLength(Vertex1, Vertex3);
            double c = SideLength(Vertex1, Vertex2);

            double s = 0.5 * (a + b + c);

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double HeightFromVertex3()
        {
            double area = Area();
            double distanceToOppositeSide = SideLength(Vertex1, Vertex2);

            return 2 * area / distanceToOppositeSide;
        }
    }
    public static class ArrayExtensions
    {
        public static int CountIncreasingNumbers(this int[] array)
        {
            int count = 0;

            foreach (int number in array)
            {
                if (IsIncreasingNumber(number))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsIncreasingNumber(int number)
        {
            int[] digits = number.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();

            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] >= digits[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
        public static int CountExtremalElements(this int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int min = array[0];
            int max = array[0];

            foreach (int number in array)
            {
                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }
            }

            int extremalCount = 0;

            foreach (int number in array)
            {
                if (number == min || number == max)
                {
                    extremalCount++;
                }
            }

            return extremalCount;
        }
    }
    public static class SpecialNumberExtensions
    {
        public static double CalculateCosApproximation(this double X, int N)
        {
            double sum = 1.0;
            double term = 1.0;

            for (int i = 1; i <= N; i++)
            {
                term *= -X * X / ((2 * i) * (2 * i - 1));
                sum += term;
            }

            return sum;
        }
        public static bool CheckForOddDigits(this int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
    public static class ListExtensions
    {
        public static List<T> SortAscending<T>(this List<T> list) where T : IComparable<T>
        {
            list.Sort();
            return list;
        }
    }
    public static class StringExtensions
    {
        public static string AddTime(this string time1, string time2)
        {
            TimeSpan span1, span2;

            if (!TimeSpan.TryParse(time1, out span1) || !TimeSpan.TryParse(time2, out span2))
            {
                throw new FormatException("Wrong time format. Use HH:MM:SS.");
            }

            TimeSpan sum = span1.Add(span2);

            int days = sum.Days;
            int hours = sum.Hours % 24;
            int minutes = sum.Minutes;
            int seconds = sum.Seconds;

            return $"{days * 24 + hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }

}