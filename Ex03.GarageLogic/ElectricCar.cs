using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricCar : Car
    {
        ElectricEngine ElectricMotorcycleEngine = null;
        private const float c_MaxAmountOfElectricity = 3.2f;

        protected ElectricCar(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber)
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            ElectricMotorcycleEngine = new ElectricEngine();
            ElectricMotorcycleEngine.MaxTime = c_MaxAmountOfElectricity;
            base.EnergyType = ElectricMotorcycleEngine;
        }

    }
}
