using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract class Vehicle
    {
        String modelName;
        String licenseNumber;
        float remainingEnergyPercentage;
        List<Wheel> wheels;
    }
}
