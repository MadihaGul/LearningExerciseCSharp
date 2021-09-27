using System;
using System.Collections.Generic;
using System.Text;

namespace LearningExerciseCSharp
{
    public partial class Program
    {
        private static void RunExerciseThree()
        {
            Console.WriteLine("You sucessfully ran exercise three!");
            Console.ResetColor();
            Console.Write("Please Enter your first name: ");
            string firstName = ChkUserinput(Console.ReadLine());
            Console.Write("\nPlease Enter your last name: ");
            string lastName = ChkUserinput(Console.ReadLine());
            Console.WriteLine("\nYour name is " + firstName + " " + lastName + ".");

        }
        private static void RunExerciseFour()
        {
            String str1 = "";
            //Output: “The brown fox jumped over the lazy dog”
            String str = "The quick fox Jumped Over the DOG"; // String before string manipulation            
            Console.WriteLine("You sucessfully ran exercise four!");
            Console.ResetColor(); 
            Console.WriteLine("Orignal string: "+str);
            str1 = str;

            str1=str1.Replace("DOG", "dog");
            str1 = str1.Replace("J", "j");

            str1 = str1.Remove(str1.IndexOf(" ")+1, 5);
            str1 = str1.Insert(str1.IndexOf(" ")+1, "brown");

            str1 = str1.Remove(str1.IndexOf("dog") - 9,1);
            str1 = str1.Insert(str1.IndexOf("dog") - 8, "o");
            str1 =str1.Insert(str1.IndexOf("dog"), "lazy ");
                                   
            Console.WriteLine("\nMamipulated String: "+str1);
            //SubString
        }

        private static void RunExerciseFive()
        {
            Console.WriteLine("You sucessfully ran exercise five!");
            Console.ResetColor(); 
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            int position = str.IndexOf(":");

            string str1 = str.Substring(position + 2);
            str1=str1.Remove(str1.IndexOf("2"),4);
            position = str1.IndexOf("5")+1;
            for (int i = 6; i <= 10; i++)
            {
                str1 = str1.Insert(position, $",{i}");
                position = position + 2;
            }
            Console.WriteLine("\nOrignal string: "+str+ "\nManipulated string: " + str1);
        }
    }
}
