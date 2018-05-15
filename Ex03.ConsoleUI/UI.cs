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

            Console.WriteLine(
                "Please choose a name for your Garage");

            garage.GarageName = Console.ReadLine();

            ManageGarage(garage);

            }

        internal void ManageGarage(Garage garage)
        {
            AggregateConsoleMessages.MainMenu(garage);

            int userChosenFuction = ValidateUserInput.validateUserMainMenuAction();

            AggregateEnumTypes.eMenuType parsedUserInputAsEnum = (AggregateEnumTypes.eMenuType)Enum.Parse(typeof(AggregateEnumTypes.eMenuType), userChosenFuction.ToString());

            switch (parsedUserInputAsEnum)
            {
                case AggregateEnumTypes.eMenuType.Zero:
                    ValidateUserInput.exit();
                    break;

                case AggregateEnumTypes.eMenuType.One:
                    garage.addVehiclesToGarage(ValidateUserInput.validateTypeOfVehicleFromUser(), ValidateUserInput.validateModelName(), ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateOwnerNameFromUser(), ValidateUserInput.validateOwnerPhoneNumberFromUser());
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Two:
                    garage.displayVehiclesInformation();
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Three:
                    garage.changeStatus(ValidateUserInput.validateLicenseNumberFromUser() ,ValidateUserInput.statusFromUser());
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Four:
                    garage.inflateWheels(ValidateUserInput.validateLicenseNumberFromUser());
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Five:
                    garage.refillVehicle(ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateTypeOfFuelFromUser(),ValidateUserInput.validateAmountToRefill());
                    ManageGarage(garage);
                    break;
                case AggregateEnumTypes.eMenuType.Six:
                    garage.refillVehicle(ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateAmountToRefill());
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
    }

}