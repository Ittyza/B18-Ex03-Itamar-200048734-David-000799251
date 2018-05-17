using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private string m_OwnerName;
        private string m_OwnerPhoneNumber;
        private float m_RemainingEnergyPercentage;
        private Wheel[] m_Wheels;
        private int m_TotalAmountOfWheels;
        private AggregateEnumTypes.eStatus m_eStatus;
        private Refillable m_EnergyType;

        public string ModelName { get => m_ModelName; set => m_ModelName = value; }

        public string LicenseNumber { get => m_LicenseNumber; set => m_LicenseNumber = value; }

        public float RemainingEnergyPercentage { get => m_RemainingEnergyPercentage; set => m_RemainingEnergyPercentage = value; }

        internal Wheel[] Wheels { get => m_Wheels; set => m_Wheels = value; }

        internal AggregateEnumTypes.eStatus EStatus { get => m_eStatus; set => m_eStatus = value; }

        public string OwnerPhoneNumber { get => m_OwnerPhoneNumber; set => m_OwnerPhoneNumber = value; }

        public string OwnerName { get => m_OwnerName; set => m_OwnerName = value; }

        internal Refillable EnergyType { get => m_EnergyType; set => m_EnergyType = value; }

        public int TotalAmountOfWheels { get => m_TotalAmountOfWheels; set => m_TotalAmountOfWheels = value; }

        public string ManifactureWheels
        {
            get
            {
                return Wheels[0].ManufacturerName;
            }

            set
            {
                foreach (Wheel wheel in Wheels)
                {
                    wheel.ManufacturerName = value;
                }
            }
        }

        protected Vehicle(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            m_ModelName = i_ModelName;
            m_LicenseNumber = i_LicenseNumber;
            m_OwnerName = i_OwnerName;
            m_OwnerPhoneNumber = i_OwnerPhoneNumber;
            m_eStatus = AggregateEnumTypes.eStatus.InRepair;
        }

        internal void initAndSetWheels(float i_MaxAirPressure)
        {
            Wheels = new Wheel[TotalAmountOfWheels];
            setWheels(i_MaxAirPressure);
        }

        internal void setWheels(float i_MaxAirPressure)
        {
            if(Wheels.Length > 0)
            {
                for (int i = 0; i < Wheels.Length; i++)
                {
                    Wheel wheel = new Wheel();
                    wheel.MaxAirPressureRecommended = i_MaxAirPressure;
                    wheel.CurrentAirPressure = wheel.MaxAirPressureRecommended;
                    Wheels[i] = wheel;
                }
            }
        }

        internal Wheel getWheel()
        {
            Wheel wheelToReturn = null;
            if (Wheels.Length > 0)
            {
                wheelToReturn = Wheels[0];
            }

            return wheelToReturn;
        }
    }
}