using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricEngine : Refillable
    {

        public float BatteryPercentage { get => base.CurrentValueOfStoredEnergy; set => base.CurrentValueOfStoredEnergy = value; }
        public float MaxTime { get => base.MaxValueRecommended; set => base.MaxValueRecommended = value; }

        public void Recharge(float amountToCharge)
        {
            base.Refill(amountToCharge);
        }
        public override string ToString()
        {
            return string.Format("The amount of current energy is {0} and the total is {1}", BatteryPercentage.ToString("0.00"), MaxTime.ToString("0.00"));
        }
    }
}
