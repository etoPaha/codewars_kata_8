using System;
using System.Linq;

namespace ArrayKata
{
    public class Array_GetAverage
    {
        public static void Start()
        {
            Console.WriteLine(GetAverage(new int[] { 2,2,2,2 }));
            Console.WriteLine(GetAverage(new int[] { 5,10 }));
            
            Console.WriteLine(GetAverage_v2(new int[] { 2,2,2,2 }));
            Console.WriteLine(GetAverage_v2(new int[] { 5,10 }));
            
            Console.WriteLine(GetAverage_v3(new int[] { 2,2,2,2 }));
            Console.WriteLine(GetAverage_v3(new int[] { 5,10 }));
            
            Console.WriteLine(GetAverage_v4(new int[] { 2,2,2,2 }));
            Console.WriteLine(GetAverage_v4(new int[] { 5,10 }));
        }

        public static int GetAverage(int[] marks)
        {
            return (int)marks.Average();
        }

        public static int GetAverage_v2(int[] marks)
        {
            return marks.Sum() / marks.Length;
        }

        public static int GetAverage_v3(int[] marks) => (int)marks.Average();

        public static int GetAverage_v4(int[] marks)
        {
            long marksSum = 0;

            foreach (int mark in marks)
            {
                marksSum += mark;
            }

            return (int) marksSum / marks.Length;
        }
    }
}