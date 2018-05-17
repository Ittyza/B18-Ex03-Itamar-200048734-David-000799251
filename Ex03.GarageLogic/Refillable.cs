using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Refillable 
    {
        private float m_CurrentValueOfStoredEnergy;
        private float m_MaxValueRecommended;

        protected float MaxValueRecommended { get => m_MaxValueRecommended; set => m_MaxValueRecommended = value; }

        protected float CurrentValueOfStoredEnergy { get => m_CurrentValueOfStoredEnergy; set => m_CurrentValueOfStoredEnergy = value; }

        protected void Refill(float i_ValueToAdd)
        {
            try
            {
                if (MaxValueRecommended < (CurrentValueOfStoredEnergy + i_ValueToAdd))
                {
                    CurrentValueOfStoredEnergy = MaxValueRecommended;
                }
            }
            catch
            {
                throw new ValueOutOfRangeException("It is overfilled", MaxValueRecommended);
            }

            CurrentValueOfStoredEnergy += i_ValueToAdd;
        }
    }
}
