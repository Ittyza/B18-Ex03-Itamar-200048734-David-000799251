using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    
    class FuelBasedCar : Car, IFuelable
    {
        private eTypeOfFuel m_TypeOfFuel = eTypeOfFuel.Octane_98;
        private float m_AmountOfFuel;
        private float m_MaxAmountOfFuel = 45;

        protected FuelBasedCar(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber, int i_TotalAmountOfWheels)
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber, i_TotalAmountOfWheels)
        {
        }

        public eTypeOfFuel TypeOfFuel { get => m_TypeOfFuel; }
        public float AmountOfFuel { get => m_AmountOfFuel; set => m_AmountOfFuel = value; }
        public float MaxAmountOfFuel { get => m_MaxAmountOfFuel;}

        public void Refuel(float amountOfFuelToFill)
        {
            AmountOfFuel += amountOfFuelToFill;
            if (MaxAmountOfFuel < AmountOfFuel)
            {
                AmountOfFuel = MaxAmountOfFuel;
            }
        }

    }
}