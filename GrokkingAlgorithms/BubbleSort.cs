using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class BubbleSort<T> where T: IComparable
    {
        public IList<T> Sort(IList<T> list)
        {
            for (var i = 1; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count - i; j++)
                {
                    if (list[j].CompareTo(list[j+1]) == 1)
                    {
                        T value = list[j];
                        list[j] = list[j+1];
                        list[j+1] = value;
                    }
                }
            }

            return list;
        }
    }
}
