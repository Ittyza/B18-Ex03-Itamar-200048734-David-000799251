using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic
{
    interface IFuelable
    {
        eTypeOfFuel TypeOfFuel
        {
            get;
        }

        float AmountOfFuel
        {
            get;
            set;
        }

        float MaxAmountOfFuel
        {
            get;
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
