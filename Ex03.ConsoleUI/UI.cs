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
            garage.addVehiclesToGarage(ValidateUserInput.validateTypeFromUser(), ValidateUserInput.validateModelName(), ValidateUserInput.validateLicenseNumberFromUser(), ValidateUserInput.validateOwnerNameFromUser(), ValidateUserInput.validateOwnerPhoneNumberFromUser());
            garage.displayVehiclesInformation();
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}