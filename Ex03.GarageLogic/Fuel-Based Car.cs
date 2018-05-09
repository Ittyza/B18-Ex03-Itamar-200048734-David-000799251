using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Fuel_Based_Car : Car , IFuelable
    {
        private eTypeOfFuel m_TypeOfFuel;
        private float m_AmountOfFuel;
        private float m_MaxAmountOfFuel;



        public eTypeOfFuel TypeOfFuel { get => m_TypeOfFuel; set => m_TypeOfFuel = value; }
        public float AmountOfFuel { get => m_AmountOfFuel; set => m_AmountOfFuel = value; }
        public float MaxAmountOfFuel { get => m_MaxAmountOfFuel; set => m_MaxAmountOfFuel = value; }

        public void Refuel(float amountOfFuelToFill)
        {
            throw new NotImplementedException();
        }
        
    }
}
