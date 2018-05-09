using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricMotorcycle : Motorcycle, IElectric
    {
        private float m_RemainingTimeOfEngine;
        private float m_MaxTime;

        protected ElectricMotorcycle(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber, int i_TotalAmountOfWheels)
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber, i_TotalAmountOfWheels)
        {
        }

        public float RemainingTimeOfEngine { get => m_RemainingTimeOfEngine; set => m_RemainingTimeOfEngine = value; }
        public float MaxTime { get => m_MaxTime; set => m_MaxTime = value; }
        public void Recharge(float amountToCharge)
        {
            RemainingTimeOfEngine += amountToCharge;
            if(RemainingTimeOfEngine > MaxTime)
            {
                RemainingTimeOfEngine = MaxTime;
            }

        }
    }
}
