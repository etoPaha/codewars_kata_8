using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayKata
{
    public class Array_DuplicateEncode
    {
        public static void Start()
        {
            Console.WriteLine(DuplicateEncode("din"));
            Console.WriteLine(DuplicateEncode("recede"));
            Console.WriteLine(DuplicateEncode("Success"));
            Console.WriteLine(DuplicateEncode("(( @"));
        }

        public static string DuplicateEncode(string word)
        {
            var lowerWord = word.ToLower();
            var bracketCharArr = lowerWord.Select(ch =>
            {
                var numOfChar = word.ToLower().Count(innerCh => ch == innerCh);
                return numOfChar == 1 ? '(' : ')';
            }).ToArray();

            return new string(bracketCharArr);
        }

        public static string DuplicateEncode_v2(string word)
        {
            // Подсчитываем количество символов
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (var c in word.ToUpper())
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts.Add(c, 1);
            }

            // Проверяем количество символов и строим новую строку из скобок
            StringBuilder builder = new StringBuilder();
            foreach (var c in word.ToUpper())
            {
                if (counts[c] == 1)
                    builder.Append('(');
                else
                    builder.Append(')');
            }

            return builder.ToString();
        }
    }
}