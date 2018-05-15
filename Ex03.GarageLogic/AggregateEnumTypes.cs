using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class AggregateEnumTypes
    {
        public enum eTypeOfVehicles
        {
            FuelBasedMotorcycle = 0,
            ElectricMotorcycle = 1,
            FuelBasedCar = 2,
            ElectricCar = 3,
            FuelBasedTruck = 4
        }
        public enum eTypeOfFuel
        {
            Soler = 0,
            Octane_95 = 1,
            Octane_96 = 2,
            Octane_98 = 3
        }
        public enum eStatus
        {
            InRepair = 0,
            Repaired = 1,
            PayedFor = 2
        }
        public enum eTypeOfLicences
        {
            A = 0,
            A1 = 1,
            B1 = 2,
            B2 = 3
        }
        public enum eTypeColor
        {
            Gray = 1,
            Blue = 2,
            White = 3,
            Black = 4
        }
        public enum eNumOfDoors
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5
        }
        public enum eMenuType
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven
        }

    }
}
