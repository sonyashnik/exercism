using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2 = HW._4.Task._2.Neighbor.List;

namespace HW._4.Task._3.Neighbor.Dictionary 
{
    static class NeighborExtension
    {
        public static void AddByKey(this Dictionary<int, Task2.Neighbor> dictionary, Task2.Neighbor neighbor)
        {
            dictionary.Add(neighbor.FlatNumber, neighbor);
        }
    }
}
