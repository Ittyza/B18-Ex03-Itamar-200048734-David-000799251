using System;

namespace Ex03.ConsoleUI
{
    internal class ValidateUserInput : UI
    {
        private static string userinputFromUserAsString = string.Empty;
        private static string userInputNumberAsString = string.Empty;
        internal static string C_addVehicleModel = "Please insert the vehicle model name";
        internal static string C_addLicenseNumber = "Please insert the license number";
        internal static string C_addOwnerName = "Please insert the owner name";
        internal static string C_addOwnerNumber = "Please insert the owner phone number";

        internal static string validateStringFromUser()
        {
            bool userInputIsGood = false;
            
            while (!userInputIsGood)
            {
                userinputFromUserAsString = Console.ReadLine();

                foreach (char letter in userinputFromUserAsString)
                {
                    if (!char.IsLetter(letter) && letter != ' ')
                    {
                        Console.WriteLine("Wrong input, please try again");
                        break;
                    }

                    if (char.IsLetter(userinputFromUserAsString[userinputFromUserAsString.Length - 1]))
                    {
                        userInputIsGood = true;
                    }
                }
            }

            return userinputFromUserAsString;
        }

        internal static string validateStringAsNumberFromUser()
        {
            bool userInputIsGood = false;
            while (!userInputIsGood)
            {
                userInputNumberAsString = Console.ReadLine();

                foreach (char letter in userInputNumberAsString)
                {
                    if (!char.IsNumber(letter))
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

        internal static T validateVolume<T>()
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

                if (result > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("The number must be positive");
                    continue;
                }
            }

            return (T)Convert.ChangeType(result, typeof(T));
        }

        internal static int validateTypeFromUser<T>()
        {
            bool userInputIsGood = false;
            int userInputNumberAsString = 0;
            T eTypeOfVehicles = default(T);

            while (!userInputIsGood)
            {
                printEnum(eTypeOfVehicles);

                userInputNumberAsString = validateUserMainMenuAction(Enum.GetNames(typeof(T)).Length);
                if (Enum.IsDefined(typeof(T), userInputNumberAsString))
                {
                    userInputIsGood = true;
                }
                else
                {
                    Console.WriteLine("Please choose a value in the menu.");
                    break;
                }
            }

            return userInputNumberAsString;
        }

        internal static void printEnum<T>(T eEnumToPrint)
        {
            Console.WriteLine("Choose between:");
            foreach (T eTypeInT in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine("{1:D}. {0}", eTypeInT, Enum.Parse(typeof(T), eTypeInT.ToString()));
            }
        }

        internal static int validateUserMainMenuAction(int i_ValidateUpToNumber)
        {
            int result = 0;
            bool isValid = false;
            string userActionChoise;
            while (!isValid)
            {
                userActionChoise = Console.ReadLine();
                if (int.TryParse(userActionChoise, out result))
                {
                    if (result < 0 || result > i_ValidateUpToNumber)
                    {
                        Console.WriteLine("Make sure the number is between 0 and {0}, please try again", i_ValidateUpToNumber);
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
    }
}