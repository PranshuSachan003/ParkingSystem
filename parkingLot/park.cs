using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLot
{
    public class park
    {
        private floor f;
        private slot s;

        public park(int nf, int ns)
        {
            f = new floor(nf);
            s = new slot(ns);
        }
    }
}
