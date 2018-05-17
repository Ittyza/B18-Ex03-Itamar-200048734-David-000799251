using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Motorcycle : Vehicle
    {
        private const int c_MaxAirPressure = 30;
        private const int c_AmountOfWheels = 2;

        private AggregateEnumTypes.eTypeOfLicences m_TypeOfLicences;
        private int m_EngineVolume;

        protected Motorcycle(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            TotalAmountOfWheels = c_AmountOfWheels;
            initAndSetWheels(c_MaxAirPressure);
            ManifactureWheels = string.Empty;
        }

        internal int EngineVolume { get => m_EngineVolume; set => m_EngineVolume = value; }

        internal AggregateEnumTypes.eTypeOfLicences TypeOfLicenses { get => m_TypeOfLicences; set => m_TypeOfLicences = value; }

        public override string ToString()
        {
            return string.Format(
                " the model Name is {0}, The license number is : {1}, the owner name is {2}, his phone number is {3} the license tyype is is {4}, and the engine volume is {5},{6}",
                ModelName,
                LicenseNumber,
                OwnerName,
                OwnerPhoneNumber,
                TypeOfLicenses.ToString(),
                EngineVolume,
                Wheels[0].ToString());
        }
    }    
}
