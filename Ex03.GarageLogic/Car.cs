using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic
{
    abstract class Car : Vehicle
    {
        private const int c_MaxAirPressure = 32;
        private const int c_AmountOfWheels = 4;

        AggregateEnumTypes.eTypeColor m_TypeOfColor;
        AggregateEnumTypes.eNumOfDoors m_NumOfDoors;

        protected Car(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            base.TotalAmountOfWheels = c_AmountOfWheels;
            base.SetWheels(c_MaxAirPressure);
        }

        internal AggregateEnumTypes.eNumOfDoors NumOfDoors { get => m_NumOfDoors; set => m_NumOfDoors = value; }
        internal AggregateEnumTypes.eTypeColor TypeOfColor { get => m_TypeOfColor; set => m_TypeOfColor = value; }
    }
 
}
