using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Ex03.GarageLogic
{
    abstract class Car : Vehicle
    {
        eTypeColor m_TypeOfColor;
        eNumOfDoors m_NumOfDoors;
        
    }
     enum eTypeColor
    {
        Gray = 1,
        Blue = 2,
        White = 3,
        Black = 4
    }
     enum eNumOfDoors
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5
    }
}
