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

    }

    enum eTypeOfLicences
    {
        A,
        A1,
        B1,
        B2
    }
}
