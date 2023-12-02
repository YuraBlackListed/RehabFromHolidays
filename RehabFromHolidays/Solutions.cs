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
        public IEnumerable<int> For14()
        {
            int currentSum = 0;
            int i = 1;

            while (true)
            {
                int term = 2 * i - 1;

                currentSum += term;

                yield return currentSum;

                i++;
            }
        }
        public double For23(int x, int n) 
            => CalculateSinApproximation(x, n);

        static double CalculateSinApproximation(double X, int N)
        {
            double result = 0;

            for (int i = 0; i < N; i++)
            {
                int denominator = 2 * i + 1;
                double term = Math.Pow(-1, i) * Math.Pow(X, denominator) / Factorial(denominator);
                result += term;
            }

            return result;
        }

        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }

        public int reversedNumber(int n)
            => ReverseNumber(n);

        static int ReverseNumber(int number)
        {
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number = number / 10;
            }

            return reversedNumber;
        }
        public int Series25(int[] numbers)
            => SumBetweenZeros(numbers);
        static bool AllNumbersHaveTwoZeros(int[] array)
        {
            foreach (int number in array)
            {
                int zeroCount = CountZeros(number);

                if (zeroCount < 2)
                {
                    return false;
                }
            }

            return true;
        }
        static int CountZeros(int num)
        {
            string numAsString = num.ToString();
            int zeroCount = 0;

            foreach (char digit in numAsString)
            {
                if (digit == '0')
                {
                    zeroCount++;
                }
            }

            return zeroCount;
        }
        static int SumBetweenZeros(int[] array)
        {
            if (AllNumbersHaveTwoZeros(array))
            {
                int sum = 0;
                foreach(int number in array)
                {
                    sum += FindNumbersBetweenZeros(number.ToString());
                }

                return sum;
            }
            Console.WriteLine("all numbers must have at least two '0'"); 
            return 0;
        }
        static int FindNumbersBetweenZeros(string input)
        {
            int startIndex = input.IndexOf('0');
            int endIndex = input.LastIndexOf('0');

            if (startIndex != -1 && endIndex != -1 && startIndex < endIndex)
            {
                string substring = input.Substring(startIndex + 1, endIndex - startIndex - 1);

                if (int.TryParse(substring, out int result))
                {
                    return result;
                }
            }

            return -1;
        }
        public int Minmax24(int[] array)
            => FindMaxSum(array);
        static int FindMaxSum(int[] array)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int currentSum = array[i] + array[i + 1];
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

        public int Minmax26(int[] array)
            => FindMaxEvenSequenceLength(array);
        static int FindMaxEvenSequenceLength(int[] array)
        {
            int currentSequenceLength = 0;
            int maxSequenceLength = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    currentSequenceLength++;
                    if (currentSequenceLength > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceLength;
                    }
                }
                else
                {
                    currentSequenceLength = 0;
                }
            }

            return maxSequenceLength;
        }

        public int[] Array17(int[] array)
            => ReorderArray(array);
        static int[] ReorderArray(int[] array)
        {
            int[] reorderedArray = new int[array.Length];
            int index = 0;

            for (int i = 0; i < array.Length / 2; i++)
            {
                reorderedArray[index++] = array[i];
                reorderedArray[index++] = array[array.Length - 1 - i];
            }

            if (array.Length % 2 != 0)
            {
                reorderedArray[index] = array[array.Length / 2];
            }

            return reorderedArray;
        }
        public int Array25(int[] array)
            => CheckGeometricProgression(array);
        static int CheckGeometricProgression(int[] array)
        {
            if (array.Length < 2)
            {
                return 0;
            }

            int commonRatio = array[1] / array[0];

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i + 1] / array[i] != commonRatio)
                {
                    return 0;
                }
            }

            return commonRatio;
        }
        public int Array48(int[] array)
            => FindMaxIdenticalElementsCount(array);
        static int FindMaxIdenticalElementsCount(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (elementCount.ContainsKey(num))
                {
                    elementCount[num]++;
                }
                else
                {
                    elementCount[num] = 1;
                }
            }

            int maxCount = elementCount.Values.Max();

            return maxCount;
        }
        public void IncreaseEvenNumbers(int[] array)
        {
            int firstEven = FindFirstEvenNumber(array);

            if (firstEven != -1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        array[i] += firstEven;
                    }
                }
            }
        }

        static int FindFirstEvenNumber(int[] array)
        {
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    return num;
                }
            }
            return -1;
        }
        public void SquareLocalMinimum(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    array[i] *= array[i];
                }
            }
        }

        public Tuple<Point, Point, double> FindMaxDistancePoints(Point[] points)
        {
            Point maxPoint1 = null;
            Point maxPoint2 = null;
            double maxDistance = 0;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);

                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        maxPoint1 = points[i];
                        maxPoint2 = points[j];
                    }
                }
            }

            return Tuple.Create(maxPoint1, maxPoint2, maxDistance);
        }

        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }   
}