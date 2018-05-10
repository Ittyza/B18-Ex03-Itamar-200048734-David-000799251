using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Garage
    {
        private  Dictionary<string, Vehicle> m_GarageVehicles;

        public Dictionary<string, Vehicle> GarageVehicles { get => m_GarageVehicles; set => m_GarageVehicles = value; }
        // To Implement
    }
}
