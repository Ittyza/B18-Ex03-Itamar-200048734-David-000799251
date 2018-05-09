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
        public float RemainingTimeOfEngine { get => m_RemainingTimeOfEngine; set => m_RemainingTimeOfEngine = value; }
        public float MaxTime { get => m_MaxTime; set => m_MaxTime = value; }
        public void Recharge(float amountToCharge)
        {
            //TODO
        }
    }
}
