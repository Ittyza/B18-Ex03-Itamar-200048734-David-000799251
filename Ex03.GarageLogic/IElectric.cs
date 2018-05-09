﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public interface IElectric
    {
        float m_RemainingTimeOfEngine
        {
            get;
            set;
        }
        
        float m_MaxTime
        {
            get;
            set;
        }
        void Recharge(float amountToCharge);
    }
}
