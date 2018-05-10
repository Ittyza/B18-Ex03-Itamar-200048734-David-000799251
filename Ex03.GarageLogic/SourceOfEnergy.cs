using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class SourceOfEnergy 
    {
        private float m_CurrentValueOfStoredEnergy;
        private float m_MaxValueRecommended;

        public float MaxValueRecommended { get => m_MaxValueRecommended; set => m_MaxValueRecommended = value; }
        public float CurrentValueOfStoredEnergy { get => m_CurrentValueOfStoredEnergy; set => m_CurrentValueOfStoredEnergy = value; }

        public void Refill(float i_ValueToAdd)
        {
            CurrentValueOfStoredEnergy += i_ValueToAdd;
            if (MaxValueRecommended < CurrentValueOfStoredEnergy)
            {
                CurrentValueOfStoredEnergy = MaxValueRecommended;
            }
        }
    }
}
