using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Losev
{
    internal class Searching
    {
        public static int find(int[] data, int target)
        {          
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
