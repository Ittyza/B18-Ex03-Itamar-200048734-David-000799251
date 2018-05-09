using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Wheel
    {
        private String m_ManufacturerName;
        private float m_CurrentAirPressure;
        private float m_MaxAirPressureRecommended;

        public string ManufacturerName { get => m_ManufacturerName; set => m_ManufacturerName = value; }
        public float CurrentAirPressure { get => m_CurrentAirPressure; set => m_CurrentAirPressure = value; }
        public float MaxAirPressureRecommended { get => m_MaxAirPressureRecommended; set => m_MaxAirPressureRecommended = value; }
        public void InflateAction (float i_AirToAdd)
        {
            //TODO
        }

    }
}
