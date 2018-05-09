using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle, IFuelable
    {
        private bool m_IsCooled;
        private float m_VolumeOfCargo;

        public bool IsCooled { get => m_IsCooled; set => m_IsCooled = value; }
        public float VolumeOfCargo { get => m_VolumeOfCargo; set => m_VolumeOfCargo = value; }
        public eTypeOfFuel m_TypeOfFuel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float m_AmountOfFuel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float m_MaxAmountOfFuel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Refuel(float amountOfFuelToFill)
        {
            throw new NotImplementedException();
        }
    }
}
