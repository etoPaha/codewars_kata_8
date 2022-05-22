using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayKata
{
    public class Array_ArrayDiff
    {
        public static void Start()
        {
            // var c = ArrayDiff_v1(new int[]{ 1, 2 }, new int[]{ 1 });
            var c = ArrayDiff_v2(new int[]{ 1, 2 }, new int[]{ });
            // var c = ArrayDiff_v1(new int[]{ }, new int[]{ 1 });
            
            foreach(var n in c)
                Console.WriteLine(n);
        }

        private static int[] ArrayDiff_v1(int[] a, int[] b)
        {
            if (a.Length == 0)
                return a;
            
            return a.Except(b).ToArray();
        }

        private static int[] ArrayDiff_v2(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }

        private static int[] ArrayDiff_v3(int[] a, int[] b)
        {
            HashSet<int> bSet = new HashSet<int>(b);

            return a.Where(n => !bSet.Contains(n)).ToArray();
        }

        private static int[] ArrayDiff_v4(int[] a, int[] b)
        {
            var bSet = new HashSet<int>(b);
            return Array.FindAll(a, n => !bSet.Contains(n));
        }

        private static int[] ArrayDiff_v5(int[] a, int[] b)
        {
            var result = new List<int>();

            bool alreadyIn;
            for (int i = 0; i < a.Length; i++)
            {
                alreadyIn = false;

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                        alreadyIn = true;
                }
                
                if (!alreadyIn)
                    result.Add(a[i]);
            }

            return result.ToArray();
        }
    }
}