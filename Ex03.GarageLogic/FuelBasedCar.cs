using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelBasedCar : Car
    {
        private const int c_MaxAmountOfFuel = 45;
        private AggregateEnumTypes.eTypeOfFuel m_TypeOfFuel = AggregateEnumTypes.eTypeOfFuel.Octane_98;
        private FuelEngine FuelBasedCarEngine = null;

        internal FuelBasedCar(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            FuelBasedCarEngine = new FuelEngine();
            FuelBasedCarEngine.TypeOfFuel = m_TypeOfFuel;
            FuelBasedCarEngine.MaxAmountOfFuel = c_MaxAmountOfFuel;
            EnergyType = FuelBasedCarEngine;
            TypeOfColor = AggregateEnumTypes.eTypeColor.Black;
            NumOfDoors = AggregateEnumTypes.eNumOfDoors.Two;
        }        
    }
}