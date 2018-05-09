using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Ex03.GarageLogic
{
    abstract class Motorcycle : Vehicle
    {
        private eTypeOfLicences m_TypeOfLicences;
        private int m_EngineVolume;

        protected Motorcycle(string i_ModelName, string i_LicenceNumber, string i_OwnerName, string i_OwnerPhoneNumber, int i_TotalAmountOfWheels)
            : base(i_ModelName, i_LicenceNumber, i_OwnerName, i_OwnerPhoneNumber, i_TotalAmountOfWheels)
        {
        }
    }

    enum eTypeOfLicences
    {
        A,
        A1,
        B1,
        B2
    }
}
