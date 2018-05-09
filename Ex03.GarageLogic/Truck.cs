using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool m_IsCooled;
        private float m_VolumeOfCargo;

        public bool IsCooled { get => m_IsCooled; set => m_IsCooled = value; }
        public float VolumeOfCargo { get => m_VolumeOfCargo; set => m_VolumeOfCargo = value; }
    }
}
