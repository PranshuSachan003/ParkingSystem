using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLot
{
    public class Vehicle
    {
        private string vType;
        private static int[] carCount = new int[2] {3,3};
        private static int[] carInd = new int[2] { 1,1};
        private static int[] TruckCount = new int [2]{1,1};
        private static int[] TruckInd = new int[2] { 0,0};
        private static int[] BikeCount = new int[2] { slot.getCount() - 4, slot.getCount()-4};
        private static int[] BikeInd = new int[2] { 4,4};
        private static int floorCount = floor.GetCount();
        private string color;
        private string registrationNumber;

        public string Vtype
        {
            get { return vType; }
        }

        public string Color
        {
            get { return color; }
        }

        public string RegistrationNumber
        {
            get { return registrationNumber; }
        }
        public Vehicle(string type, string col, string registration)
        {
            vType = type;
            color = col;
            registrationNumber = registration;
        }

        public Ticket Parking()
        {
            Ticket t = new Ticket();
            t.Flor = -1;
            t.Loc = -1;
            for (int i = 0; i < floorCount; i++)
            {
                if (String.Equals(vType, "Truck") && TruckCount[i] > 0)
                {
                    TruckCount[i]--;
                    TruckInd[i]++;
                    t.Flor = i + 1;
                    t.Loc = TruckInd[i];
                    break;
                    // string.Format("Your {0} have color {1} registered with {2} can be parked in F{3}S1L{4}", vType,
                     //   color, registrationNumber, i+1, TruckInd[i]);
                }
                else if (String.Equals(vType, "Car") && carCount[i] > 0)
                {
                    carCount[i]--;
                    carInd[i]++;
                    t.Flor = i + 1;
                    t.Loc = carInd[i];
                    break;
                    //return string.Format("Your {0} have color {1} registered with {2} can be parked in F{3}S1L{4}", vType,
                    //  color, registrationNumber, i+1, carInd[i]);
                }
                else if (String.Equals(vType, "Bike") && BikeCount[i] > 0)
                {
                    BikeCount[i]--;
                    BikeInd[i]++;
                    t.Flor = i + 1;
                    t.Loc = BikeInd[i];
                    break;
                    //return string.Format("Your {0} have color {1} registered with {2} can be parked in F{3}S1L{4}", vType,
                    //  color, registrationNumber, i+1, BikeInd[i]);

                }
                else if (!string.Equals(vType, "Car") && !string.Equals(vType, "Truck") &&
                         !string.Equals(vType, "Bike"))
                {
                    t.Flor = -2;
                    t.Loc = -2;
                }
            }

            return t;
            //return "sorry, we are occupied";
        }

        public string LeaveVehicle(int floor, int loca)
        {
                if (String.Equals(vType, "Truck"))
                {
                    TruckCount[floor-1]++;
                    TruckInd[floor-1]--;
                }
                else if (String.Equals(vType, "Car"))
                {
                    carCount[floor-1]++;
                    --carInd[floor-1];
                }
                else if (String.Equals(vType, "Bike"))
                {
                    BikeCount[floor-1]++;
                    --BikeInd[floor-1];
                }

            return string.Format("ur {0} is left parking from Floor{1}-Slot1-Location{2}", vType, floor, loca);
        }

        public  static List<Ticket> VacentSpace()
        {
            List<Ticket> noOccu = new List<Ticket>();
            Ticket t = new Ticket();
            for (int i = 0; i < floorCount; i++)
            {
                while (TruckCount[i] > 0 && TruckInd[i] > -1)
                {
                    t.Flor = i + 1;
                    t.Loc = TruckInd[i] + 1;
                    noOccu.Add(t);
                    TruckCount[i]--;
                    TruckInd[i]--;
                }

                while (carCount[i] > 0 && carInd[i] > 0)
                {
                   
                    t.Flor = i + 1;
                    t.Loc = carInd[i] + 1;
                    noOccu.Add(t);
                    carCount[i]--;
                    carInd[i]--;
                }
                while (BikeCount[i] > 0 && BikeInd[i] > 3)
                {

                    t.Flor = i + 1;
                    t.Loc = BikeInd[i] + 1;
                    noOccu.Add(t);
                    BikeCount[i]--;
                    BikeInd[i]--;
                }
            }

            return noOccu;
        }
    }
}
