using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, Vehicle> m_GarageVehicles;


        public Dictionary<string, Vehicle> GarageVehicles { get => m_GarageVehicles; set => m_GarageVehicles = value; }
        // To Implement
        public Garage()
        {
            m_GarageVehicles = new Dictionary<string, Vehicle>();
        }

        public void addCarsInGarage(AggregateEnumTypes.eTypeOfVehicles eTypeOfVehicles, string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            Vehicle vehicleToAdd = createCars(eTypeOfVehicles, i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
            if (m_GarageVehicles.ContainsKey(i_LicenseNumber))
            {
                vehicleToAdd.EStatus = AggregateEnumTypes.eStatus.InRepair;
                AggregateConsoleMessages.vehicleIsAlreadyInTheGarage(vehicleToAdd);
            }
            else
            {
                GarageVehicles.Add(i_LicenseNumber, vehicleToAdd);
            }
        }
        private Dictionary<string, Vehicle> dictionaryOfVehiclesInGarageBasedOnStatus(AggregateEnumTypes.eStatus i_eStatus)
        {
            Dictionary<string, Vehicle> vehicleInGarage = new Dictionary<string, Vehicle>();
            foreach (Vehicle vehicle in m_GarageVehicles.Values)
            {
                if (i_eStatus == vehicle.EStatus)
                {
                    vehicleInGarage.Add(vehicle.LicenseNumber, vehicle);
                }
            }
            return vehicleInGarage;
        }
        private void changeStatus(string i_LicenseNumber, AggregateEnumTypes.eStatus i_eStatus)
        {
            foreach (string licenceNumber in m_GarageVehicles.Keys)
            {
                if (licenceNumber.Equals(i_LicenseNumber))
                {
                    m_GarageVehicles[i_LicenseNumber].EStatus = i_eStatus;
                }
                else
                {
                    AggregateConsoleMessages.vehicleIsNotInTheGarage();
                }
            }
        }

        internal void inflateWheels(string i_LicenseNumber)
        {
            foreach (string licenceNumber in m_GarageVehicles.Keys)
            {
                if (licenceNumber.Equals(i_LicenseNumber))
                {
                    if (m_GarageVehicles[i_LicenseNumber].Wheels.Length > 0)
                    {
                        m_GarageVehicles[i_LicenseNumber].setWheels(m_GarageVehicles[i_LicenseNumber].Wheels[0].MaxAirPressureRecommended);
                    }
                    else
                    {
                        AggregateConsoleMessages.vehicleHasNoWheels();
                    }
                }
                else
                {
                    AggregateConsoleMessages.vehicleIsNotInTheGarage();
                }
            }
        }

        internal void refillVehicle(string i_LicenseNumber, float i_AmountToRefill)
        {
            refillVehicle(i_LicenseNumber, 0, i_AmountToRefill);
        }
        internal void refillVehicle(string i_LicenseNumber, AggregateEnumTypes.eTypeOfFuel i_eTypeOfFuel, float i_AmountToRefill)
        {
            foreach (string licenceNumber in m_GarageVehicles.Keys)
            {
                if (licenceNumber.Equals(i_LicenseNumber))
                {
                    if (m_GarageVehicles[i_LicenseNumber].EnergyType is FuelEngine)
                    {
                        if ((m_GarageVehicles[i_LicenseNumber].EnergyType as FuelEngine).TypeOfFuel.Equals(i_eTypeOfFuel))
                        {
                            (m_GarageVehicles[i_LicenseNumber].EnergyType as FuelEngine).Refuel(i_AmountToRefill);
                        }
                        else
                        {
                            AggregateConsoleMessages.wrongFuel(i_LicenseNumber);
                        }
                    }
                    else if (m_GarageVehicles[i_LicenseNumber].EnergyType is ElectricEngine)
                    {
                        (m_GarageVehicles[i_LicenseNumber].EnergyType as ElectricEngine).Recharge(i_AmountToRefill);
                    }
                    else
                    {
                        AggregateConsoleMessages.theEngineOfTheVehicleisNotFillable(i_LicenseNumber);
                    }

                }
                else
                {
                    AggregateConsoleMessages.vehicleIsNotInTheGarage();
                }
            }
        }

        private Vehicle createCars(AggregateEnumTypes.eTypeOfVehicles eTypeOfVehicles, string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            Vehicle vehicle;
            switch (eTypeOfVehicles)
            {
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedMotorcycle:
                    vehicle = new FuelBasedMotorcycle(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricMotorcycle:
                    vehicle = new ElectricMotorcycle(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedCar:
                    vehicle = new FuelBasedCar(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricCar:
                    vehicle = new ElectricCar(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedTruck:
                    vehicle = new FuelBasedTruck(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                default:
                    vehicle = null;
                    break;

            }
            return vehicle;
        }
        internal void displayDictionary()
        {
            AggregateConsoleMessages.displayDictionary(m_GarageVehicles);
        }
        internal void displayVehiclesInformation()
        {
            AggregateConsoleMessages.displayVehicle(m_GarageVehicles);

        }

    }
}
