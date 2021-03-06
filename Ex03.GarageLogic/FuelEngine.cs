﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelEngine : Refillable
    {
        private AggregateEnumTypes.eTypeOfFuel eTypeOfFuel;

        public AggregateEnumTypes.eTypeOfFuel TypeOfFuel { get => eTypeOfFuel; set => eTypeOfFuel = value; }

        public float FuelLevel { get => CurrentValueOfStoredEnergy; set => CurrentValueOfStoredEnergy = value; }

        public float MaxAmountOfFuel { get => MaxValueRecommended; set => MaxValueRecommended = value; }

        public void Refuel(float amountOfFuelToFill)
        {
            Refill(amountOfFuelToFill);
        }

        public override string ToString()
        {
            return string.Format("The type of fuel is {0}, and the amount of current fuel is {1}, and the total is {2}", TypeOfFuel.ToString(), FuelLevel.ToString("0.00"), MaxAmountOfFuel.ToString("0.00"));
        }
    }
}
