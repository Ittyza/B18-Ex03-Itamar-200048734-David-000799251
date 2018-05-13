using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        String m_ModelName;
        String m_LicenseNumber;
        string m_OwnerName;
        string m_OwnerPhoneNumber;
        float m_RemainingEnergyPercentage;
        Wheel[] m_Wheels;
        int m_TotalAmountOfWheels;
        AggregateEnumTypes.eStatus m_eStatus;
        Refillable m_EnergyType;

        public string ModelName { get => m_ModelName; set => m_ModelName = value; }
        public string LicenseNumber { get => m_LicenseNumber; set => m_LicenseNumber = value; }
        public float RemainingEnergyPercentage { get => m_RemainingEnergyPercentage; set => m_RemainingEnergyPercentage = value; }
        internal Wheel [] Wheels { get => m_Wheels; set => m_Wheels = value; }
        internal AggregateEnumTypes.eStatus EStatus { get => m_eStatus; set => m_eStatus = value; }
        public string OwnerPhoneNumber { get => m_OwnerPhoneNumber; set => m_OwnerPhoneNumber = value; }
        public string OwnerName { get => m_OwnerName; set => m_OwnerName = value; }
        internal Refillable EnergyType { get => m_EnergyType; set => m_EnergyType = value; }
        public int TotalAmountOfWheels { get => m_TotalAmountOfWheels; set => m_TotalAmountOfWheels = value; }

        protected Vehicle(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            m_ModelName = i_ModelName;
            m_LicenseNumber = i_LicenceNumber;
            m_OwnerName = i_OwnerName;
            m_OwnerPhoneNumber = i_OwnerPhoneNumber;
            m_eStatus = AggregateEnumTypes.eStatus.InRepair;

        }

        internal void SetWheels(int i_MaxAirPressure)
        {
            Wheels = new Wheel[TotalAmountOfWheels];
            foreach (Wheel wheel in Wheels)
            {
                wheel.MaxAirPressureRecommended = i_MaxAirPressure;
                wheel.CurrentAirPressure = wheel.MaxAirPressureRecommended;
                
            }
        }

    }
    
}
