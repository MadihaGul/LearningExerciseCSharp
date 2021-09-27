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
