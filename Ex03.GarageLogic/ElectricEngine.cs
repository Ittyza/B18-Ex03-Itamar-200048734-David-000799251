using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricEngine : Refillable
    {
        
        public float RemainingTimeOfEngine { get => base.CurrentValueOfStoredEnergy; set => base.CurrentValueOfStoredEnergy = value; }
        public float MaxTime { get => base.MaxValueRecommended; set => base.MaxValueRecommended = value; }

        public void Recharge(float amountToCharge)
        {
            base.Refill(amountToCharge);
        }
    }
}
