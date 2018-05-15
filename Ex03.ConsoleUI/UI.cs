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
            AggregateConsoleMessages.welcomeMessage(garage);

            int userChosenFuction = int.Parse(Console.ReadLine());
            AggregateEnumTypes.eMenuType parsedUserInputAsEnum = (AggregateEnumTypes.eMenuType)Enum.Parse(typeof(AggregateEnumTypes.eMenuType), userChosenFuction.ToString());

            switch (parsedUserInputAsEnum)
            {
                case AggregateEnumTypes.eMenuType.Zero:
                    //quit();
                    break;
                case AggregateEnumTypes.eMenuType.One:
                    garage.addVehiclesToGarage(ValidateUserInput.validateTypeOfVehicleFromUser(), ValidateUserInput.validateModelName(), ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateOwnerNameFromUser(), ValidateUserInput.validateOwnerPhoneNumberFromUser());
                    break;
                case AggregateEnumTypes.eMenuType.Two:
                    garage.displayVehiclesInformation();
                    break;
                case AggregateEnumTypes.eMenuType.Three:
                    garage.changeStatus(ValidateUserInput.validateLicenseNumberFromUser() ,ValidateUserInput.statusFromUser());
                    break;
                case AggregateEnumTypes.eMenuType.Four:
                    garage.inflateWheels(ValidateUserInput.validateLicenseNumberFromUser());
                    break;
                case AggregateEnumTypes.eMenuType.Five:
                    garage.refillVehicle(ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateTypeOfFuelFromUser(),ValidateUserInput.validateAmountToRefill());
                    break;
                case AggregateEnumTypes.eMenuType.Six:
                    garage.refillVehicle(ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateAmountToRefill());
                    break;
                case AggregateEnumTypes.eMenuType.Seven:
                    garage.displayVehiclesInformation();
                    break;


            }
        }
    }

}