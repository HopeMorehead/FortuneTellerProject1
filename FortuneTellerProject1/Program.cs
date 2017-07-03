using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject1
{
    class Program
    {
        static void Main(string[] args)
        {


            string inputFirstNameTxt;
            string inputLastNameTxt;
            string inputUserAgeTxt;
            string inputBirthMonthTxt;
            string inputFavColor;
            string inputSiblingCountTxt;



            int inputFirstNameNum;
            int inputLastNameNum;
            int inputUserAgeNum;
            int inputBirthMonthNum;
            int inputSiblingCountNum;

            //All the variable options that are used in the program


            string textToEnter1 = "Hello, welcome to Fortune Teller. Press enter!";
            string textToEnter2 = "You can continue by pressing the enter key after each question or comment.";
            //  string textToEnter3 = "You can exit anytime by entering the word exit.";
            string textToEnter4 = "Let's Begin!";





            //window with part of the console class that will edit output.Dividing the length of the string and window size will center text.

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
            Console.Read();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
            Console.Read();
            //  Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
            Console.Read();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter4.Length / 2)) + "}", textToEnter4));
            Console.Read();



            //  attempt at a exit statement
            //  string exitStatement = Console.ReadLine().ToLower();
            // while (exitStatement != "exit")

            //in order to get the user to enter correct information questions are looped.
            do
            {
                Console.WriteLine("What is your first name?");
                inputFirstNameTxt = Console.ReadLine().ToLower();

                // If the user enters a number TryParse will try to convert a string to a number
                //It can't be done so it will throw an error.This works because user information is being parsed after it has been entered
                // as opposed to converteng the readline the same time it is being parsed 
                //loop will not break. and if the length is empty user will not exit loop.
                //causing an error to be thrown.Length has to be set to <0 because index based characters start at 0
                if (int.TryParse(inputFirstNameTxt, out inputFirstNameNum) || inputFirstNameTxt.Length < 0)

                {
                    Console.WriteLine("Enter text please!");
                }
                else

                    break;
            }
            while (inputFirstNameTxt != "exit");






            //in order to get the user to enter correct information questions are looped.
            do
            {
                Console.WriteLine("What is your last name");
                inputLastNameTxt = Console.ReadLine().ToLower();
                // If the user enters a number TryParse will try to convert a string to a number
                //It can't be done so it will throw an error.This works because user information is being parsed after it has been entered
                // as opposed to converteng the readline the same time it is being parsed 
                //loop will not break. and if the length is empty user will not exit loop.
                //causing an error to be thrown.Length has to be set to <0 because index based characters start at 0

                if (int.TryParse(inputLastNameTxt, out inputLastNameNum) || inputLastNameTxt.Length < 0)

                {
                    Console.WriteLine("Enter text please");
                }
                else
                    break;
            }

            while (inputLastNameTxt != "exit");



            do
            {

                Console.WriteLine($"Thanks {inputFirstNameTxt} {inputLastNameTxt} what a nice name!! Now what is your age?");
                inputUserAgeTxt = Console.ReadLine();
                //if input cannot be turned into an int the user tried to enter a text for what should of been a numeric value
                //causing an error to be thrown
                if (!int.TryParse(inputUserAgeTxt, out inputUserAgeNum) || inputUserAgeNum < 0)

                {
                    Console.WriteLine("Invaild!");
                }
                else

                    break;
            }
            while (inputUserAgeTxt != "exit");




            do
            {

                Console.WriteLine("What is your birth month.Enter numerics; for example the the month of May is represented as 5 ");
                inputBirthMonthTxt = Console.ReadLine();
                //if input cannot be turned into an int the user tried to enter a numeric value for what should of been a string value
                //causing an error to be thrown
                if (!int.TryParse(inputBirthMonthTxt, out inputBirthMonthNum))
                {
                    Console.WriteLine("A valid Numeric value please!");
                }
                else
                    break;
            }
            while (inputBirthMonthTxt != "exit");


            do
            {
                Console.WriteLine("What is your favorite ROYGBIV color. If you are unsure type \"help\".");
                inputFavColor = Console.ReadLine();
                // inputFavColor = Console.ReadLine().ToUpper();
                //currentcultureIgnoreCase is another way of nullifiying case sensitivity
                if (inputFavColor.Equals("HELP", StringComparison.CurrentCultureIgnoreCase) || inputFavColor.Length == 0)
                {
                    List<string> colors = new List<string>()
                       {
                       "Red","Orange","Yellow","Green","Blue","Indigo","Violet"
                       };
                    foreach (string currentVal in colors)
                    {
                        Console.WriteLine(currentVal);
                    }
                    //Another method that is part of the console class.
                    // ForegroundColor and Background change the colors in the 
                    //console window.

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ROYGBIV");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(" represents the");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" seven");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" primary colors");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(" of the");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" Rainbow ");
                    Console.ResetColor();


                    // Else if is being used to catch an error in case user does not put in ROYGBiV color
                }
                else if
                   (
                   inputFavColor.ToLower() != "red" &&
                   inputFavColor.ToLower() != "orange" &&
                   inputFavColor.ToLower() != "yellow" &&
                   inputFavColor.ToLower() != "green" &&
                   inputFavColor.ToLower() != "blue" &&
                   inputFavColor.ToLower() != "indigo" &&
                   inputFavColor.ToLower() != "violet"
                   )
                {
                    Console.WriteLine("Pick a ROYGBIV color");
                }
                else

                    break;
            }
            while (inputBirthMonthTxt != "exit");




            do
            {
                Console.WriteLine("How Many siblings do you have??");
                inputSiblingCountTxt = Console.ReadLine();

                if (!int.TryParse(inputSiblingCountTxt, out inputSiblingCountNum) || inputUserAgeNum < 0)


                {
                    Console.WriteLine("Numerics Please");
                }
                else
                    break;
            }
            while (inputBirthMonthTxt != "exit");



            //If Statements for the fortunes!!!!
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;


            Console.WriteLine(inputFirstNameTxt + ' ' + inputLastNameTxt + ' ' + "Here is your fortune!");

            Console.Write((inputUserAgeNum % 2 == 0) ? "You will retire in 10 years with " : "You will retire in 100 years. If you don't live that long you will never see retirement with ");






            if (inputBirthMonthNum >= 1 && inputBirthMonthNum <= 4)
            {
                Console.WriteLine("{0:n3} dollars in the bank.", 1000.00);

            }
            else if (inputBirthMonthNum >= 5 && inputBirthMonthNum <= 8)
            {
                Console.WriteLine("{0:n3} dollars in the bank.", 2000.00);
            }
            else if (inputBirthMonthNum >= 5 && inputBirthMonthNum <= 8)
            {
                Console.WriteLine("{0:n3} dollars in the bank.", 3000.00);
            }
            else if (inputBirthMonthNum >= 9 && inputBirthMonthNum <= 12)
            {
                Console.WriteLine("{0:n3} dollars in the bank.", 4000.00);
            }
            else
            {
                Console.WriteLine("0 dollars in the bank");
            }







            if (inputSiblingCountNum == 0)
            {
                Console.WriteLine("You will have a vacation home in like Beverly Hills, California.");

            }
            else if (inputSiblingCountNum == 1)
            {
                Console.WriteLine("You will have a vacation home in Tokyo,Japan.");
            }
            else if (inputSiblingCountNum == 2)
            {
                Console.WriteLine("You will have a vacation home in las vagas, Navada.");
            }
            else if (inputSiblingCountNum >= 3)
            {
                Console.WriteLine("You will have a vacation home in Barcelona, Spain.");
            }
            else
            {
                Console.WriteLine("You will have a vacation home in your backyard.");
            }








            switch (inputFavColor.ToLower())
            {

                case "red":
                    Console.WriteLine("your mode of transportation will be a boat!");
                    break;

                case "orange":
                    Console.WriteLine("your mode of transportation will be a hoverboard!");
                    break;

                case "yellow":
                    Console.WriteLine("your mode of transportation will be a scooter!");
                    break;

                case "green":
                    Console.WriteLine("your mode of transportation will be a beat up bicycle!");
                    break;

                case "blue":
                    Console.WriteLine("your mode of transportation will be a jet!");
                    break;

                case "indigo":
                    Console.WriteLine("your mode of transportation will be a sports car!");
                    break;

                case "violet":
                    Console.WriteLine("your mode of transportation will be Your own two feet!");

                    break;
                default:
                    Console.WriteLine("Have fun riding the bus!");
                    break;
            }
        }
    }
}

 
 







                                