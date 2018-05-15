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

        public void ManageGarage(Garage garage)
        {
            AggregateConsoleMessages.MainMenu(garage);

            int userChosenFuction = ValidateUserInput.validateUserMainMenuAction(Console.ReadLine());

            AggregateEnumTypes.eMenuType parsedUserInputAsEnum = (AggregateEnumTypes.eMenuType)Enum.Parse(typeof(AggregateEnumTypes.eMenuType), userChosenFuction.ToString());

            switch (parsedUserInputAsEnum)
            {
                case AggregateEnumTypes.eMenuType.Zero:
                    ValidateUserInput.exit();
                    break;

                case AggregateEnumTypes.eMenuType.One:
                    garage.addVehiclesToGarage(ValidateUserInput.validateTypeOfVehicleFromUser(), ValidateUserInput.validateModelName(), ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateOwnerNameFromUser(), ValidateUserInput.validateOwnerPhoneNumberFromUser());
                    break;
            }
        }
    }

}