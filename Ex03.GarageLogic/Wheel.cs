using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Wheel : SourceOfEnergy
    {
        private String m_ManufacturerName;

        public string ManufacturerName { get => m_ManufacturerName; set => m_ManufacturerName = value; }
        public float CurrentAirPressure { get => CurrentValueOfStoredEnergy; set => CurrentValueOfStoredEnergy = value; }
        public float MaxAirPressureRecommended { get => MaxValueRecommended; set => MaxValueRecommended = value; }
        public void InflateAction (float i_AirToAdd)
        {
            base.Refill(i_AirToAdd);
        }

    }
}
