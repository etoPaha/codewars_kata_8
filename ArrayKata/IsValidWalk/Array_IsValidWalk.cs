using System.Linq;

namespace ArrayKata.IsValidWalk
{
    public class Array_IsValidWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            var x = 0;
            var y = 0;

            foreach (var dir in walk)
            {
                if (dir == "n") y++;
                else if (dir == "s") y--;
                else if (dir == "e") x++;
                else if (dir == "w") x--;
            }

            return x == 0 && y == 0;
        }

        public static bool IsValidWalk_v2(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            var numOfN = walk.Count(s => s == "n");
            var numOfS = walk.Count(s => s == "s");
            var numOfW = walk.Count(s => s == "w");
            var numOfE = walk.Count(s => s == "e");

            return numOfN == numOfS && numOfW == numOfE;
        }
    }
}