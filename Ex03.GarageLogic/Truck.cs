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
        private eTypeOfFuel m_TypeOfFuel;
        private float m_AmountOfFuel;
        private float m_MaxAmountOfFuel;


        public bool IsCooled { get => m_IsCooled; set => m_IsCooled = value; }
        public float VolumeOfCargo { get => m_VolumeOfCargo; set => m_VolumeOfCargo = value; }
        public eTypeOfFuel TypeOfFuel { get => m_TypeOfFuel; set => m_TypeOfFuel = value; }
        public float AmountOfFuel { get => m_AmountOfFuel; set => m_AmountOfFuel = value; }
        public float MaxAmountOfFuel { get => m_MaxAmountOfFuel; set => m_MaxAmountOfFuel = value; }

        public void Refuel(float amountOfFuelToFill)
        {
            throw new NotImplementedException();
        }
    }
}
