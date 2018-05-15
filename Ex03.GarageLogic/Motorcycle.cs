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

        protected Motorcycle(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            base.TotalAmountOfWheels = c_AmountOfWheels;
            base.initAndSetWheels(c_MaxAirPressure);
        }

        internal int EngineVolume { get => m_EngineVolume; set => m_EngineVolume = value; }
        internal AggregateEnumTypes.eTypeOfLicences TypeOfLicenses { get => m_TypeOfLicences; set => m_TypeOfLicences = value; }
        public override string ToString()
        {
            return string.Format("The type of license is : {0} and the engine volume is is {1}", ModelName, LicenseNumber, OwnerName, OwnerPhoneNumber, TypeOfLicenses.ToString(),EngineVolume );
        }
    }


    
}
