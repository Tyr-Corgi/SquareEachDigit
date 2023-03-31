using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_Square_from_a_string
{
    public  class SqureDigits
    {
        public static int SquareAllDigits(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
                Console.WriteLine(int.Parse(output));
            }
            return int.Parse(output);
        }
    }
}
