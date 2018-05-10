using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    
    class FuelBasedCar : Car
    {
        private AggregateEnumTypes.eTypeOfFuel m_TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_98;
        FuelEngine FuelBasedCarEngine = null;
        private const int c_MaxAmountOfFuel = 45;

        protected FuelBasedCar(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            FuelBasedCarEngine = (FuelEngine)base.EnergyType;
            FuelBasedCarEngine.TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_98;
            FuelBasedCarEngine.MaxAmountOfFuel = c_MaxAmountOfFuel;
        }
        
    }
}