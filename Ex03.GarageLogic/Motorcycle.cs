using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    abstract class Motorcycle : Vehicle
    {
        private const int c_MaxAirPressure = 30;
        private const int c_AmountOfWheels = 2;

        private AggregateEnumTypes.eTypeOfLicences m_TypeOfLicences;
        private int m_EngineVolume;

        protected Motorcycle(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber)
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            base.TotalAmountOfWheels = c_AmountOfWheels;
            base.SetWheels(c_MaxAirPressure);
        }
    }

    
}
