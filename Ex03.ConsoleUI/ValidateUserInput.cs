﻿using System;
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
                        Console.WriteLine("Wrong input, please try again.");
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
                        Console.WriteLine("Wrong input, please try again.");
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
                    if (!char.IsLetter(letter))
                    {
                        Console.WriteLine("Wrong input, please try again.");
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
                        Console.WriteLine("Wrong input, please try again.");
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
                    Console.WriteLine("The input must be of a number, please try again {0}", Environment.NewLine);
                    continue;
                }
                if (result == 6 || result == 8 || result == 10)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("The input must be of a a 6, 8 or 10, please try again {0}", Environment.NewLine);
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
                        Console.WriteLine("Make sure the number is between 0 and 7");
                        continue;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("The input must be a number between 0 and 7");
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
            throw new NotImplementedException();
        }

        internal static AggregateEnumTypes.eTypeOfFuel validateTypeOfFuelFromUser()
        {
            throw new NotImplementedException();
        }

        internal static string statusFromUser()
        {
            throw new NotImplementedException();
        }
    }
}

