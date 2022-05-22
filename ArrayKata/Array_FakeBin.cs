using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrayKata
{
    public class Array_FakeBin
    {
        public static void Start()
        {
            Console.WriteLine(FakeBin("45385593107843568"));
            Console.WriteLine(FakeBin_v2("45385593107843568"));
            Console.WriteLine(FakeBin_v3("45385593107843568"));
        }

        public static string FakeBin(string numbersStr)
        {
            var binStrArr = numbersStr.Select(n => n < '5' ? "0" : "1");

            return string.Concat(binStrArr);
        }

        public static string FakeBin_v2(string x)
        {
            StringBuilder builder = new StringBuilder();

            foreach (char c in x)
            {
                var binChar = c >= '5' ? '1' : '0';
                builder.Append(binChar);
            }

            return builder.ToString();
        }

        public static string FakeBin_v3(string x)
        {
            x = Regex.Replace(x, "[4321]", "0");
            x = Regex.Replace(x, "[56789]", "1");
            return x;
        }
        
        /// <summary>
        /// Мое гавно решение, которое нихуя не работает
        /// </summary>
        /// <param name="numbersStr"></param>
        /// <returns></returns>
        public static string FakeBin_MyExample(string numbersStr)
        {
            char[] charArr = numbersStr.ToCharArray();
            var binChars = charArr
                .Select(character =>
                {
                    int num = (int) char.GetNumericValue(character) >= 5 ? 1 : 0;
                    char c = Convert.ToChar(num);
                    return c;
                }).ToArray();
        
            var result = new string(binChars);
        
            return result;
        }
        
        
    }
}