using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehabFromHolidays
{
    public class Solutions
    {
        private (int, int, int) CalculateDigits(int input)
        {
            int units = input % 10;
            int dozens = input % 100 / 10;
            int hundreds = input / 100;
            return (units, dozens, hundreds);
        }

        #region Integer
        public int Integer1(int input)
            => input / 100;
        public int Integer2(int input)
            => input / 1000;
        public int Integer3(int input)
            => input / 1024;
        public int Integer4(int A, int B)
            => A / B;
        public int Integer5(int A, int B)
            => A % B;
        public (int, int) Integer6(int input)
            => (input / 10, input % 10);
        public (int, int) Integer7(int input)
            => ((input / 10) + (input % 10), (input / 10) * (input % 10));
        public int Integer8(int input)
            => input / 10 + input % 10 * 10;
        public int Integer9(int input)
            => input / 100;
        public (int, int) Integer10(int input)
            => ((input % 10), (input % 100 / 10));
        public (int, int) Integer11(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return (units + dozens + hundreds, units * dozens * hundreds);
        }
        public int Integer12(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units * 100 + dozens * 10 + hundreds;
        }
        public int Integer13(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return dozens * 100 + hundreds * 10 + units;
        }
        public int Integer14(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units * 100 + hundreds * 10 + dozens;
        }
        public int Integer15(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return   dozens * 100 + hundreds * 10 + units;
        }
        public int Integer16(int input)
            => (input % 1000) / 100;
        public int Integer17(int input)
            => input / 1000;
        public int Integer18(int input)
            => input / 1000;
        public int Integer19(int input)
            => input / 60;
        public int Integer20(int input)
            => input / 60 / 60;
        public int Integer21(int input)
            => input % 60;
        public int Integer22(int input)
            => input % 60 % 60;
        public int Integer23(int input)
            => input % 60 % 60 / 60;
        public int Integer24(int input)
            => input % 7;
        public int Integer25(int input)
            => (input + 3) % 7;
        public int Integer26(int input)
            => (input + 1) % 7;
        public int Integer27(int input)
            => (input + 5) % 7;
        public int Integer28(int dayOfAYear, int weekNumberOfFirstDay)
            => (weekNumberOfFirstDay + dayOfAYear) % 7; 
        public int Integer29(int a, int b, int c)
            => (a * b) / (c * c);
        public int Integer30(int input)
            => (input / 100) + 1;

        #endregion
        #region Boolean 

        public bool Boolean1(int input)
            => input > 0;
        public bool Boolean2(int input)
            => input % 2 != 0;
        public bool Boolean3(int input)
            => input % 2 == 0;
        public bool Boolean4(int a, int b)
            => a > 2 && b <= 3;
        public bool Boolean5(int a, int b)
            => a >= 0 && b < -2;
        public bool Boolean6(int a, int b, int c)
            => a < b && b < c;
        public bool Boolean7(int a, int b, int c)
            => (a < b && b < c) || (a > b && b > c);
        public bool Boolean8(int a, int b)
            => a % 2 != 0 && b % 2 != 0;
        public bool Boolean9(int a, int b)
            => a % 2 != 0 && b % 2 != 0;
        public bool Boolean10(int a, int b)
            => (a % 2 != 0 && b % 2 == 0) || (a % 2 == 0 && b % 2 != 0);
        public bool Boolean11(int a, int b)
            => (a % 2 == 0 && b % 2 == 0) || (a % 2 != 0 && b % 2 != 0);
        public bool Boolean12(int a, int b, int c)
            => a > 0 && b > 0 && c > 0;
        public bool Boolean13(int a, int b, int c)
            => a > 0 || b > 0 || c > 0;
        public bool Boolean14(int a, int b, int c)
            => (a > 0 && b <= 0 && c <= 0) || (a <= 0 && b > 0 && c <= 0) || (a <= 0 && b <= 0 && c > 0);
        public bool Boolean15(int a, int b, int c)
            => (a > 0 && b > 0 && c <= 0) || (a <= 0 && b > 0 && c > 0) || (a > 0 && b <= 0 && c > 0);
        public bool Boolean16(int input)
            => input % 2 == 0 && input > 9 && input < 100;
        public bool Boolean17(int input)
            => input % 2 != 0 && input > 99 && input < 1000;
        public bool Boolean18(int a, int b, int c)
            => a == b || b == c || a == c;
        public bool Boolean19(int a, int b, int c)
            => a == -b || b == -c || a == -c;
        public bool Boolean20(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units != dozens && units != hundreds && dozens != hundreds;
        }
        public bool Boolean21(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units < dozens && dozens < hundreds;
        }
        public bool Boolean22(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return (units < dozens && dozens < hundreds) || (units > dozens && dozens > hundreds);
        }
        public bool Boolean23(int input)
            => input == Integer12(input); 
        public bool Boolean24(int a, int b, int c)
            => a * b - 4 * a * c >= 0;
        public bool Boolean25(int x, int y)
            => x < 0 && y > 0; 
        public bool Boolean26(int x, int y)
            => x > 0 && y < 0; 
        public bool Boolean27(int x, int y)
            => (x < 0 && y > 0) || (x < 0 && y < 0);
        public bool Boolean28(int x, int y)
            => (x < 0 && y > 0) || (x < 0 && y < 0);
        public bool Boolean29(int x, int y)
            => (x > 0 && y > 0) || (x < 0 && y < 0);
        public bool Boolean30(int a, int b, int c)
            => a == b && c == b && c == a;
        public bool Boolean31(int a, int b, int c)
            => a == b || c == b || c == a;
        public bool Boolean32(int a, int b, int c)
            => (a == b + c) || (c == b + a) || (b == c + a);
        public bool Boolean33(int a, int b, int c)
            => (a + b) > c && (a + c) > b && (b + c) > a;
        public bool Boolean34(int a, int b, int c)
            => (a + b) > c && (a + c) > b && (b + c) > a;
        public bool Boolean35(int x, int y)
            => (x + y) % 2 != 0;
        public bool Boolean36(int x1, int y1, int x2, int y2)
            => (x1 + y1) % 2 != 0 && (x2 + y2) % 2 == 0 && (x2 + y2) % 2 != 0 && (x1 + y1) % 2 == 0;
        public bool Boolean37(int x1, int y1, int x2, int y2)
            => x2 - x1 <= 1 && y2 - y1 <= 1;
        public bool Boolean38(int x1, int y1, int x2, int y2)
            => Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        public bool Boolean39(int x1, int y1, int x2, int y2)
            => (x1 == x2) || (y1 == y2) || (Math.Abs(x2 - x1) == Math.Abs(y2 - y1));
        public bool Boolean40(int x1, int y1, int x2, int y2)
        {
            int deltaX = Math.Abs(x2 - x1);
            int deltaY = Math.Abs(y2 - y1);
            return (deltaX == 2 && deltaY == 1) || (deltaX == 1 && deltaY == 2);
        }
        #endregion

        public int If18()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                return 3;
            }
            else if (a == c)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        public int If27()
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                return 0;
            }
            else if((x % 2) == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
        public float For10()
        {
            int n = int.Parse(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (float)i;
            }
            return sum;
            
        }
        public float For25()
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            float x1 = x;
            float result = x;

            for (int i = 2; i <= n; ++i)
            {
                x1 *= -1 * x;
                result += x1 / i;
            }
            return result;
        }
        public int While10()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int temp = 3;

            while (temp < n)
            {
                temp *= 3;
                ++k;
            }
            return k;
        }
        public int Series23()
        {
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (!((array[i] > array[i - 1] && array[i] > array[i + 1]) || (array[i] < array[i - 1] && array[i] < array[i + 1])))
                {
                    return i + 1;
                }
            }

            return 0;
        }
        public int Proc28()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] <= 1)
                {
                    Console.WriteLine("Number must be more than 1. Reenter.");
                    i--;
                }
            }

            int primeCount = CountPrimes(numbers);

            return primeCount;
        }
        private bool IsPrime(int N)
        {
            if (N <= 1)
                return false;

            if (N == 2)
                return true;

            if (N % 2 == 0)
                return false;

            for (int i = 3; i * i <= N; i += 2)
            {
                if (N % i == 0)
                    return false;
            }

            return true;
        }
        int CountPrimes(int[] numbers)
        {
            int count = 0;

            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    count++;
                }
            }

            return count;
        }
        public void Proc29()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] <= 0)
                {
                    Console.WriteLine("Number must be more than 1. Reenter.");
                    i--;
                }
            }

            foreach (int number in numbers)
            {
                int digitCount = DigitCount(number);
                Console.WriteLine($"{number}: {digitCount} digits");
            }
        }

        static int DigitCount(int K)
        {
            if (K == 0)
                return 1;

            int count = 0;

            while (K > 0)
            {
                K /= 10;
                count++;
            }

            return count;
        }

    }
}

    /*Integer 8, 27
Boolean 39
If 18, 27
For 10, 25
While 10
Series 23
Proc 28, 29
Minmax 23, 28
Array 28, 47, 74*/
