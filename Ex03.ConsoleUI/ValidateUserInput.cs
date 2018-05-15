using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    class ValidateUserInput : UI
    {
        internal static string inputFromUserAsString = string.Empty;

        internal static string validateModelName()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the vehicle model name");

                userInputNumberAsString = Console.ReadLine();

                foreach (char letter in userInputNumberAsString)
                {
                    if (!char.IsLetter(letter))
                    {
                        Console.WriteLine("Wrong input, please try again");
                        break;
                    }
                    if (char.IsLetter(userInputNumberAsString[userInputNumberAsString.Length - 1]))
                    {
                        userInputIsGood = true;
                    }
                }
            }
            return userInputNumberAsString;
        }

        internal static string validateOwnerPhoneNumberFromUser()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the owner number");

                userInputNumberAsString = Console.ReadLine();

                foreach (char number in userInputNumberAsString)
                {
                    if (!char.IsNumber(number))
                    {
                        Console.WriteLine("The input must be a number, please try again");
                        break;
                    }
                    if (char.IsNumber(userInputNumberAsString[userInputNumberAsString.Length - 1]))
                    {
                        userInputIsGood = true;
                    }
                }
            }
            return userInputNumberAsString;
        }

        internal static string validateOwnerNameFromUser()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the owner name");

                userInputNumberAsString = Console.ReadLine();

                foreach (char letter in userInputNumberAsString)
                {
                    if (!char.IsLetter(letter) || letter != ' ')
                    {
                        Console.WriteLine("The input must only be letters and spaces, please try again");
                        break;
                    }
                    if (char.IsLetter(userInputNumberAsString[userInputNumberAsString.Length - 1]))
                    {
                        userInputIsGood = true;
                    }
                }
            }
            return userInputNumberAsString;
        }

        internal static string validateLicenseNumberFromUser()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the vehicle license number");

                userInputNumberAsString = Console.ReadLine();

                foreach (char letter in userInputNumberAsString)
                {
                    if (!char.IsDigit(letter))
                    {
                        Console.WriteLine("The input must be a number, please try again");
                        break;
                    }
                    if (char.IsDigit(userInputNumberAsString[userInputNumberAsString.Length - 1]))
                    {
                        userInputIsGood = true;
                    }
                }
            }
            return userInputNumberAsString;
        }

        internal static AggregateEnumTypes.eNumOfDoors validateNumberOfDoors()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;
            AggregateEnumTypes.eNumOfDoors eNumOfDoors = new AggregateEnumTypes.eNumOfDoors();

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the number of doors");

                userInputNumberAsString = Console.ReadLine();

                if (!Enum.IsDefined(typeof(AggregateEnumTypes.eNumOfDoors), userInputNumberAsString))
                {
                    Console.WriteLine("The input must be between 2 and 5, please try again");
                    break;
                }
                try
                {
                    eNumOfDoors = (AggregateEnumTypes.eNumOfDoors)Enum.Parse(typeof(AggregateEnumTypes.eNumOfDoors), userInputNumberAsString);
                }
                catch (ArgumentException)
                {
                }
            }

            return eNumOfDoors;
        }

        internal static AggregateEnumTypes.eTypeColor validateTypeOfColor()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;
            AggregateEnumTypes.eTypeColor eTypeColor = new AggregateEnumTypes.eTypeColor();

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the number of doors");

                userInputNumberAsString = Console.ReadLine();

                if (!Enum.IsDefined(typeof(AggregateEnumTypes.eNumOfDoors), userInputNumberAsString))
                {
                    Console.WriteLine("The input must be between 1 and 4, please try again");
                    break;
                }
                try
                {
                    eTypeColor = (AggregateEnumTypes.eTypeColor)Enum.Parse(typeof(AggregateEnumTypes.eTypeColor), userInputNumberAsString);
                }
                catch (ArgumentException)
                {
                }
            }

            return eTypeColor;
        }

        internal static int validateEngineVolume()
        {
            bool isValid = false;
            int result = 0;

            while (!isValid)
            {
                bool booleanToTry = int.TryParse(Console.ReadLine(), out result);
                if (!booleanToTry)
                {
                    Console.WriteLine("The input must a number, please try again");
                    continue;
                }
                if (result < 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("The number must be positive");
                    continue;
                }
            }

            return result;
        }

        internal static AggregateEnumTypes.eIsCooled validateIsCooled()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;
            AggregateEnumTypes.eIsCooled eIsCooled = new AggregateEnumTypes.eIsCooled();

            while (!userInputIsGood)
            {
                Console.WriteLine("Is the truck cooled? 0 for no 1 for yes");

                userInputNumberAsString = Console.ReadLine();

                if (!Enum.IsDefined(typeof(AggregateEnumTypes.eIsCooled), userInputNumberAsString))
                {
                    Console.WriteLine("The input must be between 0 and 1, please try again");
                    break;
                }
                try
                {
                    eIsCooled = (AggregateEnumTypes.eIsCooled)Enum.Parse(typeof(AggregateEnumTypes.eIsCooled), userInputNumberAsString);
                }
                catch (ArgumentException)
                {
                }
            }

            return eIsCooled;
        }

        internal static object validateVolumeOfCargo()
        {
            // TODO
            throw new NotImplementedException();
        }

        internal static object validateLicenseTypeFromUser()
        {
            // TODO
            throw new NotImplementedException();
        }

        internal static AggregateEnumTypes.eTypeOfVehicles validateTypeOfVehicleFromUser()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;
            AggregateEnumTypes.eTypeOfVehicles eTypeOfVehicles = new AggregateEnumTypes.eTypeOfVehicles();

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the vehicle model name");

                userInputNumberAsString = Console.ReadLine();


                if (!Enum.IsDefined(typeof(AggregateEnumTypes.eTypeOfVehicles), userInputNumberAsString))
                {
                    Console.WriteLine("Wrong input, please try again.");
                    break;
                }
                try
                {
                    eTypeOfVehicles = (AggregateEnumTypes.eTypeOfVehicles)Enum.Parse(typeof(AggregateEnumTypes.eTypeOfVehicles), userInputNumberAsString);
                }
                catch (ArgumentException)
                {
                }
            }

            return eTypeOfVehicles;
        }

        internal static int validateInputFromUserAsInt6or8or10()
        {
            bool isValid = false;
            int result = 0;

            while (!isValid)
            {
                bool booleanToTry = int.TryParse(Console.ReadLine(), out result);
                if (!booleanToTry)
                {
                    Console.WriteLine("The input must be of a number, please try again");
                    continue;
                }
                if (result == 6 || result == 8 || result == 10)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("The input must be 6, 8 or 10, please try again");
                    continue;
                }
            }

            return result;
        }

        internal static int validateUserMainMenuAction()
        {
            int result = 0;
            bool isValid = false;
            string userActionChoise;
            while(!isValid)
            {
                userActionChoise = Console.ReadLine();
                if (int.TryParse(userActionChoise, out result))
                {
                    if (result < 0 || result > 7)
                    {
                        Console.WriteLine("Make sure the number is between 0 and 7, please try again");
                        continue;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("The input must be a number, please try again");
                    continue;
                }
            }
            return result;
        }

        internal static void exit()
        {
            Console.WriteLine("Thank you, have a good day");
            Console.ReadLine();
            Environment.Exit(200);
        }
        internal static float validateAmountToRefill()
        {
            float result = 0;
            bool isValid = false;
            string amountToRefill;
            while (!isValid)
            {
                amountToRefill = Console.ReadLine();
                if (float.TryParse(amountToRefill, out result))
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Make sure the number is positive, please try again");
                        continue;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("The input must be a number, please try again");
                    continue;
                }
            }
            return result;
        }

        internal static AggregateEnumTypes.eTypeOfFuel validateTypeOfFuelFromUser()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;
            AggregateEnumTypes.eTypeOfFuel eTypeOfFuel = new AggregateEnumTypes.eTypeOfFuel();

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the type of fuel");

                userInputNumberAsString = Console.ReadLine();


                if (!Enum.IsDefined(typeof(AggregateEnumTypes.eTypeOfFuel), userInputNumberAsString))
                {
                    Console.WriteLine("Ensure that is either 0 (Soler), 1 (Octane 95), 2 (Octane 96) or 3 (Octane 98), please try again");
                    break;
                }
                try
                {
                    eTypeOfFuel = (AggregateEnumTypes.eTypeOfFuel)Enum.Parse(typeof(AggregateEnumTypes.eTypeOfFuel), userInputNumberAsString);
                }
                catch (ArgumentException)
                {
                }
            }
 
            return eTypeOfFuel;
        }

        internal static AggregateEnumTypes.eStatus statusFromUser()
        {
            bool userInputIsGood = false;
            string userInputNumberAsString = null;
            AggregateEnumTypes.eStatus eStatus = new AggregateEnumTypes.eStatus();

            while (!userInputIsGood)
            {
                Console.WriteLine("Please insert the new status");

                userInputNumberAsString = Console.ReadLine();

                if (!Enum.IsDefined(typeof(AggregateEnumTypes.eStatus), userInputNumberAsString))
                {
                    Console.WriteLine("Ensure that is either 0 (In Repair), 1 (Repaired) or 2 (Payed For), please try again");
                    break;
                }
                try
                {
                    eStatus = (AggregateEnumTypes.eStatus)Enum.Parse(typeof(AggregateEnumTypes.eStatus), userInputNumberAsString);
                }
                catch (ArgumentException)
                {
                }
            }

            return eStatus;
        }
    }
}

