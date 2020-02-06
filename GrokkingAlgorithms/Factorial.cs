using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Factorial
    {
        public static int GetResult(int number)
        {
            if (number.Equals(1)) return 1;
            else return number * GetResult(number - 1);
        }
    }
}
