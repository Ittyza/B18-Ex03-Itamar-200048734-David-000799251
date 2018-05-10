using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    abstract class Truck : Vehicle
    {
        private const int c_MaxAirPressure = 28;
        private const int c_AmountOfWheels = 12;
        private bool m_IsCooled;
        private float m_VolumeOfCargo;

        protected Truck(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            base.TotalAmountOfWheels = c_AmountOfWheels;
            base.SetWheels(c_MaxAirPressure);
            
        }

        public bool IsCooled { get => m_IsCooled; set => m_IsCooled = value; }
        public float VolumeOfCargo { get => m_VolumeOfCargo; set => m_VolumeOfCargo = value; }


    }
}
