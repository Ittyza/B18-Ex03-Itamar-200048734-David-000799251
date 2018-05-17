using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricCar : Car
    {
        private const float c_MaxAmountOfElectricity = 3.2f;
        private ElectricEngine ElectricMotorcycleEngine = null;

        internal ElectricCar(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            ElectricMotorcycleEngine = new ElectricEngine();
            ElectricMotorcycleEngine.MaxTime = c_MaxAmountOfElectricity;
            EnergyType = ElectricMotorcycleEngine;
            TypeOfColor = AggregateEnumTypes.eTypeColor.Black;
            NumOfDoors = AggregateEnumTypes.eNumOfDoors.Two;
        }
    }
}
