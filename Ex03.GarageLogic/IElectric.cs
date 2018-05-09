using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public interface IElectric
    {
        float RemainingTimeOfEngine
        {
            get;
            set;
        }
        
        float MaxTime
        {
            get;
            set;
        }
        void Recharge(float amountToCharge);
    }
}
