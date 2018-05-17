using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelBasedMotorcycle : Motorcycle
    {
        private const int c_MaxAmountOfFuel = 6;
        private AggregateEnumTypes.eTypeOfFuel m_TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_96;
        protected FuelEngine FuelBasedMotorcycleEngine = null;

        internal FuelBasedMotorcycle(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            FuelBasedMotorcycleEngine = new FuelEngine();
            FuelBasedMotorcycleEngine.TypeOfFuel = m_TypeOfFuel;
            FuelBasedMotorcycleEngine.MaxAmountOfFuel = c_MaxAmountOfFuel;
            EnergyType = FuelBasedMotorcycleEngine;
            TypeOfLicenses = AggregateEnumTypes.eTypeOfLicences.A;
            EngineVolume = 0;
        }
    }
}