using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    }


    public class Solutions
    {
        private (int, int, int) CalculateDigits(int input)
        {
            int units = input % 10;
            int dozens = input % 100 / 10;
            int hundreds = input / 100;
            return (units, dozens, hundreds);
        }
        public void Begin40(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            int D = a1 * b2 - a2 * b1;

            if (D != 0)
            {
                double x = (c1 * b2 - c2 * b1) / D;
                double y = (a1 * c2 - a2 * c1) / D;

                Console.WriteLine($"Solution to the system: x = {x}, y = {y}");
            }
            else
            {
                Console.WriteLine("The system does not have a unique solution.");
            }
        }

        public bool Bolean20(int number)
        {
            int digit1 = number % 10;
            int digit2 = (number / 10) % 10;
            int digit3 = number / 100;

            return digit1 != digit2 && digit1 != digit3 && digit2 != digit3;
        }

        public bool Bolean33(int a, int b, int c)
            => a + b > c && a + c > b && b + c > a;

        public int If19(int a, int b, int c, int d)
        {
            if (a == b && a == c && a != d)
                return 4;
            else if (a == b && a == d && a != c)
                return 3;
            else if (a == c && a == d && a != b)
                return 2;
            else
                return 1;
        }
        public double For23(int x, int n)
        {
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
                sum += term;
            }

            return sum;
        }
        private double Factorial (int n)
        {
            if (n == 0 || n == 1)
                return 1;

            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        public (int, int, int) Proc14(int a, int b, int c)
            => (c, a, b); // or
        public void Proc14Again(ref int a, ref int b, ref int c)
        {
            int temp = a;
            a = c;
            c = b;
            b = temp;
        }

        public int MinMax17(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[maxIndex])
                    maxIndex = i;
            }

            return array.Length - 1 - maxIndex;
        }

        public (double, Point, Point) Array135(Point[] setA, Point[] setB)
        {
            double minDistance = double.MaxValue;

            foreach (var point1 in setA)
            {
                foreach (var point2 in setB)
                {
                    double distance = point1.DistanceTo(point2);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        return (distance, point1, point2);
                    }
                }
            }
            return (0, null, null);
        }


        public void Matrix51(int[,] matrix)
        {
            int minRowIndex = 0, maxRowIndex = 0;
            int minValue = matrix[0, 0], maxValue = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                        minRowIndex = i;
                    }

                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxRowIndex = i;
                    }
                }
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[minRowIndex, j];
                matrix[minRowIndex, j] = matrix[maxRowIndex, j];
                matrix[maxRowIndex, j] = temp;
            }
        }

        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        public void PrintUppercaseLetters(int N)
        {
            char startLetter = 'A';

            for (int i = 0; i < N; i++)
            {
                char currentLetter = (char)(startLetter + i);
                Console.WriteLine(currentLetter + " ");
            }
        }
        public List<Point> Task12(List<Point> points, Point center, double distance)
        {
            List<Point> result = new List<Point>();

            foreach (var point in points)
            {
                double distanceToCenter = point.DistanceTo(center);

                if (distanceToCenter < distance)
                {
                    result.Add(point);
                }
            }

            return result;
        }
    }   
    

}