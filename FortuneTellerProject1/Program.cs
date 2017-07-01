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


            /*Ask the user for the user’s first name
             Ask the user for the user’s last name
             Ask the user for the user’s age
             Ask the user for the user’s birth month(as an 'int')
             Ask the user for the user’s favorite ROYGBIV color
             If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
             Ask the user for the number of siblings the user has
             Part 2

         If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
         If the user’s number of siblings is 0, then they will have a vacation home in ____(location), or 1 then they will have a vacation home in ____(location), or 2 then they will have a vacation home in ____(location), or 3 then they will have a vacation home in ____(location), or more than 3 then they will have a vacation home in ____(location).If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!
         Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation(i.e.car, boat, plane, etc.)
         If the user’s birth month is 1 - 4, they will have $____ in the bank; if the user's birth month is 5-8, they will have $____ in the bank; and if it is 9-12, then they will have $____ in the bank. If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.
         Part 3

         The user’s fortune should be written as such:
         [First Name]
         [Last Name]
         will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
         Program should be able to handle whether or not a user inputs capital or lowercase letters.*/



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



            Console.WriteLine("Hello, welcome to Fortune Teller.");
            Console.WriteLine("You can continue by pressing the enter key after each question or comment.");


            //do
            Console.WriteLine("You can exit anytime by entering the word exit.");
            Console.WriteLine("Lets begin!");


            Console.WriteLine("What is your first name?");
            inputFirstNameTxt = Console.ReadLine().ToLower();
            //if input cannot be turned into an int the user tried to enter a numeric value for what should of been a string value
            //causing an error to be thrown
            if (!int.TryParse(inputFirstNameTxt, out inputFirstNameNum))

            {
                Console.WriteLine("Got it!");
            }
            else
            {
                Console.WriteLine("Text Please!");
            };




            Console.WriteLine("What is your last name");
            inputLastNameTxt = Console.ReadLine().ToLower();

            //if input cannot be turned into an int the user tried to enter a numeric value for what should of been a string value
            //causing an error to be thrown
            if (!int.TryParse(inputLastNameTxt, out inputLastNameNum))

            {
                Console.WriteLine("Got it!");
            }
            else
            {
                Console.WriteLine("Text Please!");
            };







            Console.WriteLine($"Thanks {inputFirstNameTxt} {inputLastNameTxt} what a nice name!! Now what is your age?");
            inputUserAgeTxt = Console.ReadLine();
            //if input cannot be turned into an int the user tried to enter a numeric value for what should of been a string value
            //causing an error to be thrown
            if (!int.TryParse(inputUserAgeTxt, out inputUserAgeNum))

            {
                Console.WriteLine("In numbers Please!");
            }
            else
            {
                Console.WriteLine("Great Age");
            };







            Console.WriteLine("What is your birth month.Enter numerics; for example the the month of May is represented as 5 ");
            inputBirthMonthTxt = Console.ReadLine();
            //if input cannot be turned into an int the user tried to enter a numeric value for what should of been a string value
            //causing an error to be thrown
            if (!int.TryParse(inputBirthMonthTxt, out inputBirthMonthNum))
            {
                Console.WriteLine("A Numeric value please!");
            }
            else
            {
                Console.WriteLine($"{ inputBirthMonthTxt} That's a great month to be born!");
            }





            Console.WriteLine(@"What is your favorite ROYGBIV color. If you are unsure type \""help"".");
            inputFavColor = Console.ReadLine();
            // inputFavColor = Console.ReadLine().ToUpper();
            if(inputFavColor.Equals("HELP", StringComparison.CurrentCultureIgnoreCase))

            {
                List<string> colors = new List<string>()
                {
                    "Red","Orange","Yellow","Green","Blue","Indigo","Violet"
                };


                    foreach( string currentVal in colors)
                {
                    Console.WriteLine(currentVal);
                
                }

            }


          /*  else
            {
                Console.WriteLine("dashfkashf");
            }

        */



            switch (inputFavColor)
            {

                case "Red":
                    break;

                case "Orange":
                    break;

                case "Yellow":
                    break;

                case "green":
                    break;

                case "Blue":
                    break;

                case "Indigo":
                    break;

                case "Violet":
                    break;
            }
            Console.WriteLine("How Many siblings do you have??");
            inputSiblingCountTxt = Console.ReadLine();

            if (!int.TryParse(inputSiblingCountTxt, out  inputSiblingCountNum))
 

            {
                Console.WriteLine("Numerics Please");
            }
            else
            {
                Console.WriteLine(" Wow!");
            };


            //If Statements for the fortunes!!!!



            Console.WriteLine(inputFirstNameTxt + ' ' + inputLastNameTxt + ' ' + "Here is your fortune!");

            Console.WriteLine((inputUserAgeNum % 2 == 0) ? "You will retire in 10 years" : "You will retire in 100 years. If you don't live that long you will never see retirement!");

            if ( inputSiblingCountNum == 0)
            {
                Console.WriteLine("You will have a vacation home in LA");

            }
            else if(inputSiblingCountNum == 2)
            {
                Console.WriteLine("You will have a vacation home in Tokyo,Japan");
            }

            
           /* If the user’s number of siblings is 0, then they will have a vacation home in ____(location), or 1 then 
            they will have a vacation home in ____(location), or 2 then they will have a vacation home in ____(location), 
            or 3 then they will have a vacation home in ____(location),
            or more than 3 then they will have a vacation home in ____(location).If
            the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!*/




        }
    }
}
