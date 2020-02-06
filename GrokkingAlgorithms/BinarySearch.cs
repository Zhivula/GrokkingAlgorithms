using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public class BinarySearch<T> where T: IComparable
    {
        public bool TryGetResult(IList<T> list, T element)
        {
            if (list != null)
            {
                var low = 0;
                var high = list.Count()-1;
                var middle = 0;
                while (low<=high)
                {
                    middle = (high + low) / 2;
                    if (list[middle].CompareTo(element) == 0)
                    {
                        return true;
                    }
                    else if(list[middle].CompareTo(element) == 1)//тут нужно поправить
                    {
                        high = middle-1;
                    }
                    else
                    {
                        low = middle+1;
                    }
                }
            }
            return false;
        }
    }
}
