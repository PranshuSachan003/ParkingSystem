using System;
using System.Collections.Generic;

namespace parkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            park p = new park(2,5);
            List<Ticket> vcSpace = Vehicle.VacentSpace();
            foreach (var tick in vcSpace)
            {
                Console.WriteLine(tick.Flor + " "+ tick.Loc);
            }
            //Vehicle v1 = new Vehicle("Car", "Red", "1234");
            //Ticket t1 = v1.Parking();
            //Vehicle v2 = new Vehicle("Car", "Red", "1234");
            //Console.WriteLine(v2.Parking());
            //Vehicle v3 = new Vehicle("Car", "Red", "1234");
            //Console.WriteLine(v3.Parking());
            //Vehicle v4 = new Vehicle("Car", "Red", "1234");
            //Console.WriteLine(v4.Parking());
            Vehicle v5 = new Vehicle("Truck", "Red", "1234");
            Ticket t5 = v5.Parking();
            TicketNotifySystem.printMsg(t5, v5);
            Vehicle v6 = new Vehicle("Truck", "Red", "1234");
            Ticket t6 = v6.Parking();
            TicketNotifySystem.printMsg(t6,v6);
            //Vehicle v7 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v7.Parking());
            //Vehicle v8 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v8.Parking());
            //Vehicle v9 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v9.Parking());
            //Vehicle v10 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v10.Parking());
            //Vehicle v11 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v11.Parking());
            //Vehicle v12 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v12.Parking());
            //Vehicle v13 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v13.Parking());
            //Vehicle v14 = new Vehicle("Bike", "Red", "1234");
            //Console.WriteLine(v14.Parking());
            Vehicle v15 = new Vehicle("HawaiJahaj", "white", "56789");
            Ticket t15 = v15.Parking();
            TicketNotifySystem.printMsg(t15,v15);
            Vehicle v16 = new Vehicle("Truck", "Red", "1234");
            Ticket t16 = v16.Parking();
            TicketNotifySystem.printMsg(t16,v16);
            Console.WriteLine(v6.LeaveVehicle(t6.Flor,t6.Loc));
            t16 = v16.Parking();
            TicketNotifySystem.printMsg(t16,v16);
            Vehicle v17 = new Vehicle("Truck", "Red", "1234");
            Ticket t17 = v17.Parking();
            TicketNotifySystem.printMsg(t17,v17);
        }
    }
}
