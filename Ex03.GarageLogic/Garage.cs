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
        private String m_garageName;

        public Dictionary<string, Vehicle> GarageVehicles { get => m_GarageVehicles; set => m_GarageVehicles = value; }
        public string GarageName { get => m_garageName; set => m_garageName = value; }

        // To Implement
        public Garage()
        {
            m_GarageVehicles = new Dictionary<string, Vehicle>();
            GarageName = this.GarageName;
        }

        public void addVehiclesToGarage(AggregateEnumTypes.eTypeOfVehicles eTypeOfVehicles, string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            Vehicle vehicleToAdd = createVehicle(eTypeOfVehicles, i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
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
        public Dictionary<string, Vehicle> dictionaryOfVehiclesInGarageBasedOnStatus(AggregateEnumTypes.eStatus i_eStatus)
        {
            Dictionary<string, Vehicle> vehiclesInGarage = new Dictionary<string, Vehicle>();
            foreach (Vehicle vehicle in m_GarageVehicles.Values)
            {
                if (i_eStatus == vehicle.EStatus)
                {
                    vehiclesInGarage.Add(vehicle.LicenseNumber, vehicle);
                }
            }
            return vehiclesInGarage;
        }

        public void changeStatus(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public void changeStatus(string i_LicenseNumber, AggregateEnumTypes.eStatus i_eStatus)
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
        public void inflateWheels(string i_LicenseNumber)
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
        public void refillVehicle(string i_LicenseNumber, float i_AmountToRefill)
        {
            refillVehicle(i_LicenseNumber, 0, i_AmountToRefill);
        }
        public void refillVehicle(string i_LicenseNumber, AggregateEnumTypes.eTypeOfFuel i_eTypeOfFuel, float i_AmountToRefill)
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
        private Vehicle createVehicle(AggregateEnumTypes.eTypeOfVehicles eTypeOfVehicles, string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            Vehicle vehicle;
            switch (eTypeOfVehicles)
            {
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedMotorcycle:
                    vehicle = new FuelBasedMotorcycle(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    (vehicle as FuelBasedMotorcycle).TypeOfLicenses = getLicenseType();
                    (vehicle as FuelBasedMotorcycle).EngineVolume = getEngineVolume();
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricMotorcycle:
                    vehicle = new ElectricMotorcycle(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    (vehicle as ElectricMotorcycle).TypeOfLicenses = getLicenseType();
                    (vehicle as ElectricMotorcycle).EngineVolume = getEngineVolume();
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedCar:
                    vehicle = new FuelBasedCar(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    (vehicle as FuelBasedCar).TypeOfColor = getColorType();
                    (vehicle as FuelBasedCar).NumOfDoors = getNumberOfDoor();
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricCar:
                    vehicle = new ElectricCar(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    (vehicle as ElectricCar).TypeOfColor = getColorType();
                    (vehicle as ElectricCar).NumOfDoors = getNumberOfDoor();
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedTruck:
                    vehicle = new FuelBasedTruck(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    (vehicle as FuelBasedTruck).IsCooled = getIsCooled();
                    (vehicle as FuelBasedTruck).VolumeOfCargo = getVolumeOfCargo();
                    break;
                default:
                    vehicle = null;
                    break;

            }
            return vehicle;
        }

        private float getVolumeOfCargo()
        {
            throw new NotImplementedException();
        }

        private bool getIsCooled()
        {
            throw new NotImplementedException();
        }

        private AggregateEnumTypes.eNumOfDoors getNumberOfDoor()
        {
            throw new NotImplementedException();
        }

        private AggregateEnumTypes.eTypeColor getColorType()
        {
            throw new NotImplementedException();
        }

        private int getEngineVolume()
        {
            throw new NotImplementedException();
        }

        private AggregateEnumTypes.eTypeOfLicences getLicenseType()
        {
            throw new NotImplementedException();
        }

        public void displayDictionary(Dictionary<string, Vehicle> i_GarageVehicles)
        {
            AggregateConsoleMessages.displayDictionary(i_GarageVehicles);
        }
        public void displayVehiclesInformation()
        {
            AggregateConsoleMessages.displayVehicle(m_GarageVehicles);
        }

    }
}
