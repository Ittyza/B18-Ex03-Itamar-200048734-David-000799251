using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Wheel : Refillable
    {
        private string m_ManufacturerName;

        public string ManufacturerName { get => m_ManufacturerName; set => m_ManufacturerName = value; }

        public float CurrentAirPressure { get => CurrentValueOfStoredEnergy; set => CurrentValueOfStoredEnergy = value; }

        public float MaxAirPressureRecommended { get => MaxValueRecommended; set => MaxValueRecommended = value; }

        public void InflateAction(float i_AirToAdd)
        {
            Refill(i_AirToAdd);
        }

        public override string ToString()
        {
            return string.Format(" the weel manifacture name is {0}, current air pressure is {1} and the max air pressure is {2}", ManufacturerName, CurrentAirPressure, MaxAirPressureRecommended);
        }
    }
}
