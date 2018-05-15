using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricMotorcycle : Motorcycle
    {
        ElectricEngine ElectricMotorcycleEngine = null;
        private const float c_MaxAmountOfElectricity = 1.8f;

        internal ElectricMotorcycle(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            ElectricMotorcycleEngine = new ElectricEngine();
            ElectricMotorcycleEngine.MaxTime = c_MaxAmountOfElectricity;
            base.EnergyType = ElectricMotorcycleEngine;
        }
    }
}
