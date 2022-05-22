using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ArrayKata
{
    class Program
    {
        static void Main(string[] args)
        {
            // var result1 = string.Join(" ", Digitize(12345));
            // Console.WriteLine($"[{result1}]");
            //
            // var result2 = string.Join(" ", DigitizeV2(12345));
            // Console.WriteLine($"[{result2}]");
            //
            // var result3 = string.Join(" ", DigitizeV3(12345));
            // Console.WriteLine($"[{result3}]");

            // string[] nameSplit = nameof.Split();
            
            // -----------------------------------------------------

            // Console.WriteLine(AbbrevName("Березкин Павел"));
            // Console.WriteLine(AbbrevNameV2("Березкин Павел"));
            // Console.WriteLine(AbbrevNameV3("Березкин Павел"));
            
            // -----------------------------------------------------

            // var inputInts = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            //
            // var result = CountPositivesSumNegatives(inputInts);
            // var resultV2 = CountPositivesSumNegativesV2(inputInts);
            //
            // Console.WriteLine($"{result[0]}, {result[1]}");
            // Console.WriteLine($"{resultV2[0]}, {resultV2[1]}");
            
            // -----------------------------------------------------
            
            // Array_FakeBin.Start();
            
            // -----------------------------------------------------

            // Array_GetAverage.Start();
            
            // -----------------------------------------------------

            // Array_DuplicateEncode.Start();
            
            // -----------------------------------------------------

            Array_ArrayDiff.Start();
            
            Console.ReadLine();
        }
        
        #region AbbrevName
        
        public static string AbbrevName(string name)
        {
            string[] nameSplit = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var initials = new List<string>();
            foreach (var item in nameSplit)
            {
                initials.Add(item[..1].ToUpper());
            }

            return string.Join('.', initials);
        }

        public static string AbbrevNameV2(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();

        public static string AbbrevNameV3(string name)
        {
            string[] buf = name.Split(' ');

            var firstName = buf.First();
            var lastName = buf.Last();

            var oneUpper = Char.ToUpper(firstName.First());
            var twoUpper = Char.ToUpper(lastName.First());

            return $"{oneUpper}.{twoUpper}";
        }
        
        #endregion
        
        #region Digitize

        public static long[] Digitize(long n)
        {
            return n.ToString()
                .Reverse()
                .Select(charNum => Convert.ToInt64(charNum.ToString()))
                .ToArray();
        }

        public static long[] DigitizeV2(long n)
        {
            List<long> list = new List<long>();

            while (n > 0)
            {
                list.Add(n % 10);
                n /= 10;
            }

            return list.ToArray();
        }

        public static long[] DigitizeV3(long n)
        {
            int lengthArr = (int)Math.Log10(n);
            long[] digits = new long[lengthArr + 1];

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[digits.Length - 1 - i] = (n % 10);

                n = (n / 10);
            }

            return digits;
        }

        #endregion
        
        private static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
                return new int[0];
            
            return new int[] { input.Count(n => n > 0), input.Where(n => n < 0).Sum() };
        }

        private static int[] CountPositivesSumNegativesV2(int[] input)
        {
            if (input == null || input.Length == 0)
                return new int[0];

            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }
    }
}