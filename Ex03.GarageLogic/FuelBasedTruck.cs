using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelBasedTruck : Truck
    {
        private const int c_MaxAmountOfFuel = 115;
        private AggregateEnumTypes.eTypeOfFuel m_TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_96;
        private FuelEngine FuelBasedTruckEngine = null;

        internal FuelBasedTruck(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber) : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            FuelBasedTruckEngine = new FuelEngine();
            FuelBasedTruckEngine.TypeOfFuel = m_TypeOfFuel;
            FuelBasedTruckEngine.MaxAmountOfFuel = c_MaxAmountOfFuel;
            EnergyType = FuelBasedTruckEngine;
            IsCooled = AggregateEnumTypes.eIsCooled.No;
            VolumeOfCargo = 0;
        }
    }
}
