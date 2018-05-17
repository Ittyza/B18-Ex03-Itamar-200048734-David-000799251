using System;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class UI
    {
        public UI()
        {
        }

        internal void Run()
        {
            Garage garage = new Garage();

            Console.WriteLine("Please choose a name for your Garage");
            garage.GarageName = Console.ReadLine();
            ManageGarage(garage);
        }

        internal void ManageGarage(Garage garage)
        {
            AggregateConsoleMessages.MainMenu(garage);
            int userChosenFuction = ValidateUserInput.validateUserMainMenuAction(7);
            string m_LicenseNumber = string.Empty;
            AggregateEnumTypes.eMenuType parsedUserInputAsEnum = (AggregateEnumTypes.eMenuType)Enum.Parse(typeof(AggregateEnumTypes.eMenuType), userChosenFuction.ToString());

            switch (parsedUserInputAsEnum)
            {
                case AggregateEnumTypes.eMenuType.Zero:
                    ValidateUserInput.exit();
                    break;

                case AggregateEnumTypes.eMenuType.One:
                    AggregateEnumTypes.eTypeOfVehicles TypeOfVehicle = (AggregateEnumTypes.eTypeOfVehicles)ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eTypeOfVehicles>();
                    Console.WriteLine(TypeOfVehicle);
                    Console.WriteLine(ValidateUserInput.C_addVehicleModel);
                    string m_ModelName = ValidateUserInput.validateStringFromUser();
                    Console.WriteLine(ValidateUserInput.C_addLicenseNumber);
                    m_LicenseNumber = ValidateUserInput.validateStringAsNumberFromUser();
                    Console.WriteLine(ValidateUserInput.C_addOwnerName);
                    string m_OwnerName = ValidateUserInput.validateStringFromUser();
                    Console.WriteLine(ValidateUserInput.C_addOwnerNumber);
                    string m_OwnerNumber = ValidateUserInput.validateStringAsNumberFromUser();
                    garage.addVehiclesToGarage(TypeOfVehicle, m_ModelName, m_LicenseNumber, m_OwnerName, m_OwnerNumber);
                    getParamFromUser(TypeOfVehicle, garage, m_LicenseNumber);
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Two:
                    garage.displayDictionary();
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Three:
                    Console.WriteLine(ValidateUserInput.C_addLicenseNumber);
                    m_LicenseNumber = ValidateUserInput.validateStringAsNumberFromUser();
                    garage.changeStatus(m_LicenseNumber, (AggregateEnumTypes.eStatus)ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eStatus>());
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Four:
                    Console.WriteLine(ValidateUserInput.C_addLicenseNumber);
                    m_LicenseNumber = ValidateUserInput.validateStringAsNumberFromUser();
                    garage.inflateWheels(m_LicenseNumber);
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Five:
                    Console.WriteLine(ValidateUserInput.C_addLicenseNumber);
                    m_LicenseNumber = ValidateUserInput.validateStringAsNumberFromUser();
                    garage.refillVehicle(m_LicenseNumber, (AggregateEnumTypes.eTypeOfFuel)ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eTypeOfFuel>(), ValidateUserInput.validateAmountToRefill());
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Six:
                    Console.WriteLine(ValidateUserInput.C_addLicenseNumber);
                    m_LicenseNumber = ValidateUserInput.validateStringAsNumberFromUser();
                    garage.refillVehicle(m_LicenseNumber, ValidateUserInput.validateAmountToRefill());
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Seven:
                    garage.displayVehiclesInformation();
                    ManageGarage(garage);
                    break;
                default:
                    ManageGarage(garage);
                    break;
            }
        }

        private void getParamFromUser(AggregateEnumTypes.eTypeOfVehicles i_TypeOfVehicle, Garage i_Garage, string i_LicenseNumber)
        {
            switch (i_TypeOfVehicle)
            {
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedMotorcycle:
                    AggregateConsoleMessages.SetLicenseType();
                    i_Garage.setParameterOfType<AggregateEnumTypes.eTypeOfLicences>(ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eTypeOfLicences>(), i_LicenseNumber, i_TypeOfVehicle);
                    AggregateConsoleMessages.SetVolumeEngine();
                    i_Garage.setParameterOfType<int>(ValidateUserInput.validateVolume<int>(), i_LicenseNumber, i_TypeOfVehicle);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricMotorcycle:
                    AggregateConsoleMessages.SetLicenseType();
                    i_Garage.setParameterOfType<AggregateEnumTypes.eTypeOfLicences>(ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eTypeOfLicences>(), i_LicenseNumber, i_TypeOfVehicle);
                    AggregateConsoleMessages.SetVolumeEngine();
                    i_Garage.setParameterOfType<int>(ValidateUserInput.validateVolume<int>(), i_LicenseNumber, i_TypeOfVehicle);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedCar:
                    AggregateConsoleMessages.SetColorType();
                    i_Garage.setParameterOfType<AggregateEnumTypes.eTypeColor>(ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eTypeColor>(), i_LicenseNumber, i_TypeOfVehicle);
                    AggregateConsoleMessages.SetDoorsType();
                    i_Garage.setParameterOfType<AggregateEnumTypes.eNumOfDoors>(ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eNumOfDoors>(), i_LicenseNumber, i_TypeOfVehicle);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricCar:
                    AggregateConsoleMessages.SetColorType();
                    i_Garage.setParameterOfType<AggregateEnumTypes.eTypeColor>(ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eTypeColor>(), i_LicenseNumber, i_TypeOfVehicle);
                    AggregateConsoleMessages.SetDoorsType();
                    i_Garage.setParameterOfType<AggregateEnumTypes.eNumOfDoors>(ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eNumOfDoors>(), i_LicenseNumber, i_TypeOfVehicle);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedTruck:
                    AggregateConsoleMessages.SetIsCooledType();
                    i_Garage.setParameterOfType<AggregateEnumTypes.eIsCooled>(ValidateUserInput.validateTypeFromUser<AggregateEnumTypes.eIsCooled>(), i_LicenseNumber, i_TypeOfVehicle);
                    AggregateConsoleMessages.setVolumeOfCargo();
                    i_Garage.setParameterOfType<float>(int.Parse(ValidateUserInput.validateVolume<float>().ToString()), i_LicenseNumber, i_TypeOfVehicle);
                    break;
            }

            AggregateConsoleMessages.setWheelManifactures();
            i_Garage.setParameterOfType<string>(ValidateUserInput.validateStringFromUser(), i_LicenseNumber);
        }
    }
}