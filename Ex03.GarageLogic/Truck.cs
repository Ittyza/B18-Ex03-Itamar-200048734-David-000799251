using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Truck : Vehicle
    {
        private const int c_MaxAirPressure = 28;
        private const int c_AmountOfWheels = 12;
        private AggregateEnumTypes.eIsCooled m_IsCooled;
        private float m_VolumeOfCargo;

        protected Truck(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            TotalAmountOfWheels = c_AmountOfWheels;
            initAndSetWheels(c_MaxAirPressure);
            ManifactureWheels = string.Empty;
        }

        public AggregateEnumTypes.eIsCooled IsCooled { get => m_IsCooled; set => m_IsCooled = value; }

        public float VolumeOfCargo { get => m_VolumeOfCargo; set => m_VolumeOfCargo = value; }

        public override string ToString()
        {
            return string.Format(
                " the model name is {0}, the license number is : {1}, the owner name is {2}, his phone number is {3} the truck is cooled; {4} and the volume of the cargo is {5}",
                ModelName,
                LicenseNumber,
                OwnerName,
                OwnerPhoneNumber,
                IsCooled,
                VolumeOfCargo.ToString("0.00"));
        }
    }
}
