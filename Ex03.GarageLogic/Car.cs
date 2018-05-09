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
        int m_TotalAmountOfWWheels;

        protected Car(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber, int i_TotalAmountOfWheels)
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber, i_TotalAmountOfWheels)
        {
        }

        internal eNumOfDoors NumOfDoors { get => m_NumOfDoors; set => m_NumOfDoors = value; }
        internal eTypeColor TypeOfColor { get => m_TypeOfColor; set => m_TypeOfColor = value; }
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
