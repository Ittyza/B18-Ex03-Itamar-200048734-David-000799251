using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public abstract class Vehicle
    {
        String m_ModelName;
        String m_LicenseNumber;
        float m_RemainingEnergyPercentage;
        List<Wheel> m_Wheels;

        public string ModelName { get => m_ModelName; set => m_ModelName = value; }
        public string LicenseNumber { get => m_LicenseNumber; set => m_LicenseNumber = value; }
        public float RemainingEnergyPercentage { get => m_RemainingEnergyPercentage; set => m_RemainingEnergyPercentage = value; }
        internal List<Wheel> Wheels { get => m_Wheels; set => m_Wheels = value; }
    }
}
