using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars_8KyuKata
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(MakeNegative(42));
            
            // Console.WriteLine(RemoveСhars("ok"));
            // Console.WriteLine(RemoveСhars("place"));
            // Console.WriteLine(RemoveСhars("person"));
            // Console.WriteLine(RemoveСhars("country"));
            // Console.WriteLine(RemoveСhars("eloqunent"));
            
            // Console.WriteLine(RemoveCharsV2("o"));
            // Console.WriteLine(RemoveCharsV2("ok"));
            // Console.WriteLine(RemoveCharsV2("place"));
            // Console.WriteLine(RemoveCharsV2("person"));
            // Console.WriteLine(RemoveCharsV2("country"));
            // Console.WriteLine(RemoveCharsV2("eloqunent"));
            
            // Console.WriteLine(RepeatStr(3,"*"));
            // Console.WriteLine(RepeatStr_LinqV1(3,"*"));
            // Console.WriteLine(RepeatStr_StringBuilderV1(3,"*"));
            // Console.WriteLine(RepeatStr_StringBuilderV2(3,"*"));
            // Console.WriteLine(RepeatStr_StringJoin(3,"*"));
            
            // ---------------------------------------------

            // Console.WriteLine(Reverse("abc"));
            // Console.WriteLine(Reverse_LinqV1("abc"));
            // Console.WriteLine(Reverse_ForLoop("abc"));
            // Console.WriteLine(Reverse_Concat("abc"));
            
            // ---------------------------------------------

            // Console.WriteLine(Summation(2));
            // Console.WriteLine(Summation(5));
            //
            // Console.WriteLine(Summation_ShortFormula(2));
            // Console.WriteLine(Summation_ShortFormula(5));
            
            // ---------------------------------------------
            //
            // Console.WriteLine(Summation_Linq(2));
            // Console.WriteLine(Summation_Linq(5));
            
            // ---------------------------------------------

            // Console.WriteLine(FindSmallestInt_ForeachLoop(new int[] { 5, -1, 2 }));
            // Console.WriteLine(FindSmallestInt_Linq(new int[] { 5, -1, 2 }));
            // Console.WriteLine(FindSmallestInt_ArraySort(new int[] { 5, -1, 2 }));
            // Console.WriteLine(FindSmallestInt_LinqOrderBy(new int[] { 5, -1, 2 }));

            // Console.WriteLine(PositiveSum(new int[] { 1, -1, 1 }));
            
            // ---------------------------------------------

            // Console.WriteLine(RemoveSpaces("1 23  4  5 67 8  9"));
            // Console.WriteLine(RemoveSpacesV2("1 23  4  5 67 8  9"));
            // Console.WriteLine(RemoveSpacesV3("1 23  4  5 67 8  9"));
            // Console.WriteLine(RemoveSpacesV4("1 23  4  5 67 8  9"));
            // Console.WriteLine(RemoveSpacesV5("1 23  4  5 67 8  9"));
            
            // ---------------------------------------------
            
            // Console.WriteLine(BoolToWord(true));
            // Console.WriteLine(BoolToWordV2(true));
            // Console.WriteLine(BoolToWordV3(true));
            
            // ---------------------------------------------
            
            // Console.WriteLine(NumberToString(-1));
            // Console.WriteLine(NumberToString(1));
            // Console.WriteLine(NumberToStringV2(-1));
            // Console.WriteLine(NumberToStringV2(1));
            // Console.WriteLine(NumberToStringV3(-1));
            // Console.WriteLine(NumberToStringV3(1));
            
            // ---------------------------------------------

            // var sheeps = new bool[] {true, false, true}; 
            
            // Console.WriteLine(CountSheeps(null));
            // Console.WriteLine(CountSheeps(new bool[] {}));
            // Console.WriteLine(CountSheeps(sheeps));
            //
            // Console.WriteLine(CountSheepsV2(null));
            // Console.WriteLine(CountSheepsV2(new bool[] {}));
            // Console.WriteLine(CountSheepsV2(sheeps));
            //
            // Console.WriteLine(CountSheepsV3(null));
            // Console.WriteLine(CountSheepsV3(new bool[] {}));
            // Console.WriteLine(CountSheepsV3(sheeps));
            //
            // Console.WriteLine(CountSheepsV4(null));
            // Console.WriteLine(CountSheepsV4(new bool[] {}));
            // Console.WriteLine(CountSheepsV4(sheeps));
            
            // Console.WriteLine(CountSheepsV5(null));
            // Console.WriteLine(CountSheepsV5(new bool[] {}));
            // Console.WriteLine(CountSheepsV5(sheeps));
            
            // ---------------------------------------------
            
            // Console.WriteLine(SquareSum(new [] { 1, 2, 2 }));
            // Console.WriteLine(SquareSumV2(new [] { 1, 2, 2 }));
            
            // ---------------------------------------------
            
            // Console.WriteLine(CenturyFromYear(1));
            // Console.WriteLine(CenturyFromYear(100));
            // Console.WriteLine(CenturyFromYear(2021));
            
            // Console.WriteLine(CenturyFromYearV2(1));
            // Console.WriteLine(CenturyFromYearV2(100));
            // Console.WriteLine(CenturyFromYearV2(2021));
            //
            // Console.WriteLine(CenturyFromYearV3(1));
            // Console.WriteLine(CenturyFromYearV3(100));
            // Console.WriteLine(CenturyFromYearV3(2021));
            
            // Console.WriteLine(CenturyFromYearV4(1));
            // Console.WriteLine(CenturyFromYearV4(100));
            // Console.WriteLine(CenturyFromYearV4(2021));
            
            // Console.WriteLine(BasicOp('+', 2, 2));
            // Console.WriteLine(BasicOp('-', 2, 2));
            // Console.WriteLine(BasicOp('*', 2, 2));
            // Console.WriteLine(BasicOp('/', 2, 2));
            
            // Console.WriteLine(BasicOpV2('+', 2, 2));
            // Console.WriteLine(BasicOpV2('-', 2, 2));
            // Console.WriteLine(BasicOpV2('*', 2, 2));
            // Console.WriteLine(BasicOpV2('/', 2, 2));
            
            // Console.WriteLine(BasicOpV3('+', 2, 2));
            // Console.WriteLine(BasicOpV3('-', 2, 2));
            // Console.WriteLine(BasicOpV3('*', 2, 2));
            // Console.WriteLine(BasicOpV3('/', 2, 2));
            
            // Console.WriteLine(BasicOpV3('+', 2, 2));
            // Console.WriteLine(BasicOpV3('-', 2, 2));
            // Console.WriteLine(BasicOpV3('*', 2, 2));
            // Console.WriteLine(BasicOpV3('/', 2, 2));
            
            Console.WriteLine(BasicOpV4('+', 2, 2));
            Console.WriteLine(BasicOpV4('-', 2, 2));
            Console.WriteLine(BasicOpV4('*', 2, 2));
            Console.WriteLine(BasicOpV4('/', 2, 2));
            
            Console.ReadLine();
        }

        #region BasicOp

        public static double BasicOp(char op, double val1, double val2)
        {
            switch (op)
            {
                case '+': return val1 + val2;
                case '-': return val1 - val2;
                case '*': return val1 * val2;
                case '/': return val1 / val2;
                default:
                    throw new ArgumentException("Unknown operaion!", op.ToString());
            }
        }

        public static double BasicOpV2(char op, double a, double b)
        {
            return op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
                _ => throw new ArgumentException("Unknown operation", $"{op}")
            };
        }

        public static double BasicOpV3(char op, double val1, double val2)
        {
            var opDict = new Dictionary<char, Func<double, double, double>>()
            {
                { '+', (a, b) => a + b },
                { '-', (a, b) => a - b },
                { '*', (a, b) => a * b },
                { '/', (a, b) => a / b }
            };

            return opDict[op](val1, val2);
        }

        public static double BasicOpV4(char op, double a, double b)
        {
            var result = new DataTable().Compute($"{a}{op}{b}", "");
            
            return Convert.ToDouble(result);
        }
        
        #endregion

        #region CenturyFromYear

        public static int CenturyFromYear(int year)
        {
            return (year - 1) / 100 + 1;
        }

        public static int CenturyFromYearV2(int year)
        {
            int yearToCentury;
            
            if (year % 100 == 0)
            {
                yearToCentury = year / 100;
            }
            else
            {
                yearToCentury = (year / 100) + 1;
            }

            return yearToCentury;
        }

        public static int CenturyFromYearV3(int year) => year % 100 == 0 ? year / 100 : year / 100 + 1;

        public static int CenturyFromYearV4(int year)
        {
            return (int)Math.Ceiling(year / 100.00f);
        }
        
        #endregion
        
        #region SquareSum

        public static int SquareSum(int[] numbers)
        {
            return (int)numbers.Sum(n => Math.Pow(n, 2));
        }

        public static int SquareSumV2(int[] numbers) => numbers.Sum(n => n * n);
        
        #endregion
        
        // -----------------------------------------

        #region Other

        public static int PositiveSum(int[] numbers)
        {
            return numbers.Where(num => num > 0).Sum();
        }

        /// <summary>
        /// Сделать отрицательным
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int MakeNegative(int number)
        {
            return -Math.Abs(number);
        }
        
        #endregion

        #region RemoveChars

        public static string RemoveСhars(string s)
        {
            if (s.Length < 2)
                return s;

            return s.Remove(0, 1).Remove(s.Length - 2);
        }

        public static string RemoveCharsV2(string s)
        {
            if (s.Length < 2)
                return s;
            
            return s.Substring(1, (s.Length - 2));
        }
        
        #endregion

        #region RepeatStr
        
        public static string RepeatStr(int n, string s)
        {
            string result = String.Empty;
            
            for (int i = 0; i < n; i++)
            {
                result += s;
            }

            return result;
        }

        public static string RepeatStr_LinqV1(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }

        public static string RepeatStr_StringBuilderV1(int n, string s)
        {
            return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        }

        public static string RepeatStr_StringBuilderV2(int n, string s)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                builder.Append(s);
            }

            return builder.ToString();
        }

        public static string RepeatStr_StringJoin(int n, string s)
        {
            return string.Join("", Enumerable.Repeat(s, n));
        }
        
        #endregion

        #region Reverse

        public static string Reverse(string s)
        {
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        public static string Reverse_LinqV1(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }

        public static string Reverse_ForLoop(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public static string Reverse_Concat(string str)
        {
            return string.Concat(str.Reverse());
        }
        
        #endregion

        #region Summation

        public static int Summation(int number)
        {
            int result = 0;

            for (int i = 1; i <= number; i++)
            {
                result += i;
            }

            return result;
        }

        public static int Summation_ShortFormula(int num)
        {
            return num * (num + 1) / 2;
        }

        public static int Summation_Linq(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }
        
        #endregion

        #region FindSmallestInt
        
        public static int FindSmallestInt_ForeachLoop(int[] numbers)
        {
            int result = numbers[0];

            foreach (var num in numbers)
            {
                if (result > num)
                    result = num;
            }

            return result;
        }

        public static int FindSmallestInt_Linq(int[] numbers)
        {
            return numbers.Min();
        }

        public static int FindSmallestInt_ArraySort(int[] numbers)
        {
            Array.Sort(numbers);

            return numbers[0];
        }

        public static int FindSmallestInt_LinqOrderBy(int[] numbers) => numbers.OrderBy(num => num).First();
    
        #endregion

        #region RemoveSpaces

        public static string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }

        public static string RemoveSpacesV2(string input)
        {
            return input.Replace(" ", String.Empty);
        }

        public static string RemoveSpacesV3(string input) => input.Replace(" ", "");

        public static string RemoveSpacesV4(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            return input.Replace(" ", string.Empty);
        }

        public static string RemoveSpacesV5(string input)
        {
            return Regex.Replace(input, @"\s+", "");
        }
        
        #endregion

        #region BoolToWord

        public static string BoolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }

        public static string BoolToWordV2(bool word) => word ? "Yes" : "No";

        public static string BoolToWordV3(bool word)
        {
            string result = "";

            switch (word)
            {
                case true:
                    result = "Yes";
                    break;
                case false:
                    result = "No";
                    break;
            }

            return result;
        }
        
        #endregion

        #region NumberToString
        
        public static string NumberToString(int num)
        {
            return $"{num}";
        }

        public static string NumberToStringV2(int num) => num.ToString();

        public static string NumberToStringV3(int num) => Convert.ToString(num);
        
        #endregion

        #region CountSheeps

        public static int CountSheeps(bool[] sheeps)
        {
            if (sheeps == null)
                return 0;
            
            return sheeps.Select(s => s ? 1 : 0).Sum();
        }

        public static int CountSheepsV2(bool[] sheeps) => sheeps?.Count(s => s) ?? 0;

        public static int CountSheepsV3(bool[] sheeps)
        {
            if (sheeps == null)
                return 0;
            
            int count = 0;

            foreach (bool sheep in sheeps)
                if (sheep)
                    count++;

            return count;
        }

        public static int CountSheepsV4(bool[] sheeps)
        {
            if (sheeps == null)
                return 0;
            
            int count = 0;

            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i]) count++;
            }

            return count;
        }

        public static int CountSheepsV5(bool[] sheeps)
        {
            return sheeps?.Sum(s => s ? 1 : 0) ?? 0;
        }
        
        #endregion
    }
}