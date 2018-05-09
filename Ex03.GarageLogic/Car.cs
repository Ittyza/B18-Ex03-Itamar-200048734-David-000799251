using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    abstract class Car 
    {
        private enum Color
        {
            Gray = 1,
            Blue = 2,
            White = 3,
            Black = 4
        }
        private enum NumOfDoors
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5
        }
    }
}
