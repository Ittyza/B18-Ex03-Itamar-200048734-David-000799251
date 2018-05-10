using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class AggregateEnumTypes
    {
        public enum eTypeOfFuel
        {
            Soler = 0,
            Octane_95 = 1,
            Octane_96 = 2,
            Octane_98 = 3
        }
        public enum eStatus
        {
            InRepair,
            Repaired,
            PayedFor
        }
        public enum eTypeOfLicences
        {
            A,
            A1,
            B1,
            B2
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
    }
}
