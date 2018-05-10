using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelBasedTruck : Truck
    {
        FuelEngine FuelBasedTruckEngine = null;
        private const int c_MaxAmountOfFuel = 115;
        protected FuelBasedTruck(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber) : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            FuelBasedTruckEngine = (FuelEngine)base.EnergyType;
            FuelBasedTruckEngine.TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_98;
            FuelBasedTruckEngine.MaxAmountOfFuel = c_MaxAmountOfFuel;
        }
    }
}
