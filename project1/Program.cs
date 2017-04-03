using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Initiate Variables
            int yearsRetire;
            int yearsEven = 20;
            int yearsOdd = 40;
            string vacationHome;
            string vacaton0 = "Hawaii";
            string vacaton1 = "Vermont";
            string vacaton2 = "Florida";
            string vacaton3AndUp = "French Riviera";
            string vacatonNull = "New Jersey";
            string transportation;
            string transR = " Brand New Car";
            string transO = "Hellachopper";
            string transY = "Unicycle";
            string transG = "Skateboard";
            string transB = "SUV";
            string transI = "Paddle Boat";
            string transV = "Jet Ski";
            double bankAccount;
            double bank14 = 5.02;
            double bank58 = 100000.99;
            double bank912 = 3.51;
            double bankNull = 0.00;
            string earlyQuit = "Nobody likes a quitter...";


            // Part 1 - Collect Input
            Console.Write("*** If at any time you would like to quit, enter \"quite\" at the prompt ***" + "\n\nEnter your FIRST name: ");
            string fName = Console.ReadLine();
            if (fName.ToLower() == "quit")
            {
                Console.WriteLine(earlyQuit);
                return;
            }

            Console.Write("Enter your LAST name: ");
            string lName = Console.ReadLine();
            if (lName.ToLower() == "quit")
            {
                Console.WriteLine(earlyQuit);
                return;
            }

            Console.Write("Enter age as a number: ");
            int age;
            string ageIn = Console.ReadLine();
            bool ageQuit = int.TryParse(ageIn, out age);
            if (!ageQuit)
            {
                Console.WriteLine(earlyQuit);
                return;
            }

            Console.Write("Enter birth month as a number: ");
            int birthMonth;
            string birthIn = Console.ReadLine();
            bool birthQuit = int.TryParse(birthIn, out birthMonth);
            if (!birthQuit)
            {
                Console.WriteLine(earlyQuit);
                return;
            }

            Console.Write("Enter your favorite ROYGBIV color: "+ "\n*Enter \"Help\" if you do not knw what ROYGVBIV is* ");
            string color = Console.ReadLine().ToLower();
            if (color == "quit")
            {
                Console.WriteLine(earlyQuit);
                return;
            }
            if (color == "help" )
            {
                Console.WriteLine("R - Red"+ "\nO - Orange" + "\nY - Yellow" + "\nG - Green" 
                            + "\nB - Blue" + "\nI - Indigo" + "\nV - Violet");
                Console.Write("Enter your favorite ROYGBIV color: ");
                color = Console.ReadLine().ToLower();
            }
            if (color == "quit")
            {
                Console.WriteLine(earlyQuit);
                return;
            }

            Console.Write("Enter the number of siblings you have: ");
            int sibNum;
            string sibIn = Console.ReadLine();
            bool sibQuit = int.TryParse(sibIn, out sibNum);
            if (!sibQuit)
            {
                Console.WriteLine(earlyQuit);
                return;
            }


            // Part 2 - Assign Fortunes
            // Years to retirement 
            if (age % 2 == 0)
            {
                yearsRetire = yearsEven;
            }
            else
            {
                yearsRetire = yearsOdd;
            }

            
            // Vacation Home Location
            if (sibNum == 0)
            {
                vacationHome = vacaton0;
            }
            else if (sibNum == 1)
            {
                vacationHome = vacaton1;
            }
            else if(sibNum == 2)
            {
                vacationHome = vacaton2;
            }
            else if (sibNum == 3)
            {
                vacationHome = vacaton3AndUp;
            }
            else
            {
                vacationHome = vacatonNull;
            }


            // Transportation
            switch (color)
            {
                case "red":
                case "r":
                    transportation = transR;
                    break;
                case "orange":
                case "o":
                    transportation = transO;
                    break;
                case "yellow":
                case "y":
                    transportation = transY;
                    break;
                case "green":
                case "g":
                    transportation = transG;
                    break;
                case "blue":
                case "b":
                    transportation = transB;
                    break;
                case "indigo":
                case "i":
                    transportation = transI;
                    break;
                case "violet":
                case "v":
                    transportation = transV;
                    break;
                default:
                    transportation = "You picked an invalid color";
                    break;                
            }


            // Bank Account
            if (birthMonth >=1 && birthMonth <= 4)
            {
                bankAccount = bank14;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankAccount = bank58;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankAccount = bank912;
            }
            else
            {
                bankAccount = bankNull;
            }


            // Output formatting
            Console.WriteLine(fName + " " + lName + " will retire in " + yearsRetire + " years with $" + 
                            bankAccount + " in the bank, \na vacation home in " + vacationHome + 
                            " and a(n) " + transportation + "!");

        }
    }
}
