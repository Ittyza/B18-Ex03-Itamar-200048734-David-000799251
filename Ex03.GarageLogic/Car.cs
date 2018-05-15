﻿using System;
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

        protected Car(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            base.TotalAmountOfWheels = c_AmountOfWheels;
            base.initAndSetWheels(c_MaxAirPressure);
        }

        internal AggregateEnumTypes.eNumOfDoors NumOfDoors { get => m_NumOfDoors; set => m_NumOfDoors = value; }
        internal AggregateEnumTypes.eTypeColor TypeOfColor { get => m_TypeOfColor; set => m_TypeOfColor = value; }
        public override string ToString()
        {
            return string.Format("The type of license is : {0} and the engine volume is is {1}", ModelName, LicenseNumber, OwnerName, OwnerPhoneNumber, NumOfDoors.ToString(), TypeOfColor.ToString());
        }
    }
 
}
