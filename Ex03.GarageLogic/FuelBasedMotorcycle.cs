using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    class FuelBasedMotorcycle : Car
    {
        private AggregateEnumTypes.eTypeOfFuel m_TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_96;
        FuelEngine FuelBasedMotorcycleEngine = null;
        private const int c_MaxAmountOfFuel = 6;

        internal FuelBasedMotorcycle(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            FuelBasedMotorcycleEngine = new FuelEngine();
            FuelBasedMotorcycleEngine.TypeOfFuel = m_TypeOfFuel;
            FuelBasedMotorcycleEngine.MaxAmountOfFuel = c_MaxAmountOfFuel;
            base.EnergyType = FuelBasedMotorcycleEngine;
            

        }



    }
}