using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLot
{
    public class floor
    {
        private static int count;

        public static int GetCount()
        {
            return count;
        }
        public floor(int c)
        {
            count = c;
        }

    }

    
}
