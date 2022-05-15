using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLot
{
    public class TicketNotifySystem
    {
        public static void printMsg(Ticket t, Vehicle v)
        {
            if (t.Flor == -2)
            {
                Console.WriteLine(string.Format("no facility for ur {0}", v.Vtype));
            }
            else if(t.Flor == -1)
            {
                Console.WriteLine(string.Format("no space for ur {0} all slot are occupied", v.Vtype));
            }
            else
            {
                Console.WriteLine(string.Format("ur {0} registered with {1} can be parked in Floor{2}-Slot1-Location{3}",
                    v.Vtype, v.RegistrationNumber, t.Flor, t.Loc));
            }
        }
    }
}
