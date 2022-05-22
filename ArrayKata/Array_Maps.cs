using System.Linq;

namespace ArrayKata
{
    public class Array_Maps
    {
        public static void Start()
        {
            
        }

        public static int[] Maps(int[] numbers)
        {
            return numbers.Select(num => num * 2).ToArray();
        }

        public static int[] Maps_v2(int[] numbers) => numbers.Select(n => n + n).ToArray();

        public static int[] Maps_v3(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }

            return numbers;
        }
    }
}