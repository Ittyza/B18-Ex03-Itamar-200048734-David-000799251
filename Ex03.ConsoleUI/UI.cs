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

            garage.addVehiclesToGarage(ValidateUserInput.validateTypeOfVehicleFromUser(), ValidateUserInput.validateModelName(), ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateOwnerNameFromUser(), ValidateUserInput.validateOwnerPhoneNumberFromUser());
        }

        internal void ManageGarage(Garage garage)
        {
            AggregateConsoleMessages.welcomeMessage(garage);

            int userChosenFuction = int.Parse(Console.ReadLine());
        }
    }
}