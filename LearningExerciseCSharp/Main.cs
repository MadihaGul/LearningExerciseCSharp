using System;
using System.Collections.Generic;
using System.Text;
namespace LearningExerciseCSharp
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.WriteLine("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine()??"");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();break;
                        case 2:
                            RunExerciseTwo(); break;
                        case 3:
                            RunExerciseThree(); break;
                        case 4:
                            RunExerciseFour(); break;
                        case 5:
                            RunExerciseFive(); break;
                        case 6:
                            RunExerciseSix();break;
                        case 7:
                            RunExerciseSeven();break;
                        case 8:
                            RunExerciseEight(); break;
                        case 9:
                            RunExerciseNine(); break;
                        case 10:
                            RunExerciseTen(); break;
                        case 11:
                            RunExerciseEleven(); break;
                        case 12:
                            RunExerciseTwelve(); break;
                        case 13:
                            RunExerciseThirteen(); break;
                        case 14:
                            RunExerciseFourteen(); break;
                        case 15:
                            RunExerciseFifteen(); break;
                        case 16:
                            RunExerciseSixteen(); break;
                        case 17:
                            RunExerciseSeventeen(); break;
                        case 18:
                            RunExerciseEighteen(); break;
                        case 19:
                            RunExerciseNineteen(); break;
                        case 20:
                            RunExerciseTwenty(); break;
                        case 21:
                            RunExerciseTwentyone(); break;
                        case 22:
                            RunExerciseTwentytwo(); break;
                        case 23:
                            RunExerciseTwentythree(); break;
                        case 24:
                            RunExerciseTwentyfour(); break;
                        case 25:
                            RunExerciseTwentyfive(); break;
                        case 26:
                            RunExerciseTwentysix(); break;
                        case 27:
                            RunExerciseTwentyseven(); break;
                        case 28:
                            RunExerciseTwentyeight(); break;
                        case -1: 
                            keepAlive=false; break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("This is not a valid assignment number!");
                            break;

                    }
                    Console.ResetColor();
                    if (keepAlive)
                    {
                        Console.WriteLine("\nHit any key to continue!");
                        Console.ReadKey();
                    }
                    Console.Clear();

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
            
        }

        /*Inside the RunExerciseOne method, add two new variables to your program that stores string values.
         * One of them is going to store you first name and the other your last name, so give them informative names.
         * Then let the program output:
         * “Hello <firstname> <lastname>! I’m glad to inform you that you are the test subject of my very first assignment!”*/
        private static void RunExerciseOne()
        {
            Console.WriteLine("You sucessfully ran exercise one!");
            Console.ResetColor();
            Console.WriteLine("Please Enter your first name: ");
            string firstName = ChkUserinput(Console.ReadLine());
            Console.WriteLine("Please Enter your last name: ");
            string lastName = ChkUserinput(Console.ReadLine());
            Console.WriteLine("Hello! "+firstName+" "+lastName+", I am glad to inform that you are the test subject of my first assignment ");
        }

        /*Inside the RunExerciseTwo method, create three new variables of type DateTime and let them store 
         * yesterdays, todays and tomorrows date. Remember to give them informative names.*/
        private static void RunExerciseTwo()
        {
            Console.WriteLine("You sucessfully ran exercise two!");
            Console.ResetColor();
            DateTime dateToday = DateTime.Now;
            DateTime dateYesterday = dateToday.AddDays(-1);
            DateTime dateTomorrow = dateToday.AddDays(1);

            Console.WriteLine("Todays date is "+dateToday.ToShortDateString());
            Console.WriteLine("Tomorrows date is "+dateTomorrow.ToShortDateString());
            Console.WriteLine("Yesterdays date was "+dateYesterday.ToShortDateString());
            Console.WriteLine("Timespan between yesterday and tomorrow is "+(dateTomorrow - dateYesterday).Days+" days");

        }

        public static string ChkUserinput(string Userinput)
        {
            while (Userinput == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid! Try again.");
                Userinput = Console.ReadLine();
            }
            Console.ResetColor();
            return Userinput;
        }
    }
}
