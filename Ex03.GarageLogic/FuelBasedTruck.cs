using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelBasedTruck : Truck
    {
        private AggregateEnumTypes.eTypeOfFuel m_TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_96;
        FuelEngine FuelBasedTruckEngine = null;
        private const int c_MaxAmountOfFuel = 115;
        internal FuelBasedTruck(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber) : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            FuelBasedTruckEngine = new FuelEngine();
            FuelBasedTruckEngine.TypeOfFuel = m_TypeOfFuel;
            FuelBasedTruckEngine.MaxAmountOfFuel = c_MaxAmountOfFuel;
            base.EnergyType = FuelBasedTruckEngine;
        }
    }
}
