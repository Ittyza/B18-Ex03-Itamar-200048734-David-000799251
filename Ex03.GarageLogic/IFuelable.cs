using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic
{
    interface IFuelable
    {
        eTypeOfFuel m_TypeOfFuel
        {
            get;
            set;
        }

        float m_AmountOfFuel
        {
            get;
            set;
        }

        float m_MaxAmountOfFuel
        {
            get;
            set;
        }
        void Refuel(float amountOfFuelToFill);
    }
    public enum eTypeOfFuel
    {
        
        Soler = 0,
        Octane_95 = 1,
        Octane_96 = 2,
        Octane_98 = 3
    }
}
