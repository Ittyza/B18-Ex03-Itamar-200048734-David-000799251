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

        protected ElectricMotorcycle(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            ElectricMotorcycleEngine = (ElectricEngine)base.EnergyType;
            ElectricMotorcycleEngine.MaxTime = c_MaxAmountOfElectricity;
        }
    }
}
