using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLot
{
    public class slot
    {
        private static int count;

        public static int getCount()
        {
            return count;
        }
        public slot(int s)
        {
            count = s;
        }
    }
}
