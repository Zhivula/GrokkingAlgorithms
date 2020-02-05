using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class BinarySearch
    {
        public static bool TryGetResult(IList<int> list, int element)
        {
            if (list != null)
            {
                var low = 0;
                var high = list.Count()-1;
                var middle = (list.Count()-1) / 2;
                while (low<=high)
                {
                    if (list[middle]==element)
                    {
                        return true;
                    }
                    else if(list[middle] > element)
                    {
                        high = middle-1;
                        middle = (high + low) / 2;
                    }
                    else
                    {
                        low = middle+1;
                        middle = (low + high) / 2;
                    }
                }
            }
            return false;
        }
    }
}
