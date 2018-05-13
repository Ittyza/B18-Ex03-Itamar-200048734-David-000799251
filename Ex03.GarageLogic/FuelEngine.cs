using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelEngine : Refillable
    {
        private AggregateEnumTypes.eTypeOfFuel eTypeOfFuel;

        public AggregateEnumTypes.eTypeOfFuel TypeOfFuel { get => eTypeOfFuel; set => eTypeOfFuel = value; }

        public float AmountOfFuel { get => CurrentValueOfStoredEnergy; set => CurrentValueOfStoredEnergy = value; }

        public float MaxAmountOfFuel { get => MaxValueRecommended; set => MaxValueRecommended = value; }

        public void Refuel(float amountOfFuelToFill)
        {
           base.Refill(amountOfFuelToFill);
        }
    }
}
