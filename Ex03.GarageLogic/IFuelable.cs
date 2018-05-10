using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic
{
    interface IFuelable
    {
        AggregateEnumTypes.eTypeOfFuel TypeOfFuel
        {
            get;
            set;
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
    
}
