using System;
using System.Collections.Generic;
using System.Text;

namespace LearningExerciseCSharp
{
    public partial class Program
    {
        /*Create a new method named RunExerciseThree and write the program code inside that prompts the user to
         * input his first and last name like shown below (with correct line breaks). Also, 
         * create two new variables that stores string values and save the input from the user into these 
         * (So that one variable stores the first name and the other stores the last name).
         * Then output the full name to the screen on one line. Inside the switch-statement in the main method, 
         * call you new method (see the calls to the previous methods) after case 3.*/
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

        /* Inside the method body, create a new empty string variable below the variable str. 
         * Use string manipulation methods like SubString, IndexOf, Remove, Replace, Insert to get the string
         * “The brown fox jumped over the lazy dog”, where all characters matches exactly and output these to the screen.
         * String str = "The quick fox Jumped Over the DOG"; 
         * // code here*/
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

        /* Below is a given string. Use string manipulations to get the [1,2,3,4,5] part 
         * from the string and store it into a new string variable.
         * Then remove the values 2 and 3 and insert 6-10 into it in the end,
         * comma separated so that the result is [1,4,5,6,7,8,9,10] and 
         * let your program output that to the console window. 
         * String str = "Arrays are very common in programming, they look something 
         * like: [1,2,3,4,5]"; Console.ReadLine();*/
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

        /* Write the program code that lets the user input 2 integers from the console.
         * Then let the program output the 
         * biggest, smallest, difference ( - ), sum (+), product ( * ) and ratio ( / ) between the two numbers*/
        private static void RunExerciseSix()
        {
            Console.WriteLine("You sucessfully ran exercise six!");
            Console.ResetColor();
            Console.Write("Please enter first integer: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter second integer: ");
            double secondNum = double.Parse(Console.ReadLine());
            if (secondNum != 0)
            {
                if (firstNum > secondNum)
                    Console.Write("\n\tBiggest integer: " + firstNum + "\n\tSmallest integer: " + secondNum + "\n\tSum: " + (firstNum + secondNum) + "\n\tDifference: " + (firstNum - secondNum) + "\n\tProduct: " + (firstNum * secondNum) + "\n\tRatio: " + (firstNum / secondNum));
                else if (secondNum > firstNum)
                    Console.Write("\n\tBiggest integer: " + secondNum + "\n\tSmallest integer: " + firstNum + "\n\tSum: " + (firstNum + secondNum) + "\n\tDifference: " + (secondNum - firstNum) + "\n\tProduct: " + (firstNum * secondNum) + "\n\tRatio: " + (firstNum / secondNum));
                else
                    Console.Write("\n\tBiggest integer: Both are equal\n\tSmallest integer: Both are equal\n\tSum: " + (firstNum + secondNum) + "\n\tDifference: " + (secondNum - firstNum) + "\n\tProduct: " + (firstNum * secondNum) + "\n\tRatio: " + (firstNum / secondNum));
            }
            else
            {
                if (firstNum > secondNum)
                    Console.Write("\n\tBiggest integer: " + firstNum + "\n\tSmallest integer: " + secondNum + "\n\tSum: " + (firstNum + secondNum) + "\n\tDifference: " + (firstNum - secondNum) + "\n\tProduct: " + (firstNum * secondNum) + "\n\tRatio: Inalid not possible ");
                else if (secondNum > firstNum)
                    Console.Write("\n\tBiggest integer: " + secondNum + "\n\tSmallest integer: " + firstNum + "\n\tSum: " + (firstNum + secondNum) + "\n\tDifference: " + (secondNum - firstNum) + "\n\tProduct: " + (firstNum * secondNum) + "\n\tRatio: Inalid not possible ");
                else
                    Console.Write("\n\tBiggest integer: Both are equal\n\tSmallest integer: Both are equal\n\tSum: " + (firstNum + secondNum) + "\n\tDifference: " + (secondNum - firstNum) + "\n\tProduct: " + (firstNum * secondNum) + "\n\tRatio: Inalid not possible");

            }
        }

        /* Write the program code that lets the user input the radius (as a double).
         * Then calculate the area and volume of a circle respective sphere with the given radius.
         * (area = 2 πr 2 , volume = (𝟒 × 𝛑 ×𝐫𝟑)𝟑 ). Output the result to the screen.       
         */
        private static void RunExerciseSeven()
        {
            Console.WriteLine("You sucessfully ran exercise seven!");
            Console.ResetColor();
            Console.Write("Please enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("\n\tArea: "+(2*Math.PI*Math.Pow(radius,2))+ "\n\tVolume: "+ Math.Pow(4*Math.PI*Math.Pow(radius,3),3));
        }

        /*
         Let the user input a decimal number. Then output square root of the number and
        the number raised to the power of 2 and 10. That is √n ,n2,n10.
         */
        private static void RunExerciseEight()
        {
            Console.WriteLine("You sucessfully ran exercise eight!");
            Console.ResetColor();
            Console.Write("Please enter a decimal number: ");
            double num = double.Parse(Console.ReadLine());
            Console.Write("\n\tSquare root: " +Math.Sqrt(num)+ "\n\tn raised to 2: " + Math.Pow(num,2) + "\n\tn raised to 10: " + Math.Pow(num, 10));
        }

        private static void RunExerciseNine()
        {
            Console.WriteLine("You sucessfully ran exercise nine!");
            Console.ResetColor();
        }

        /*  Write the program code that will ask to user to choose between 3 different options using a switch-statement.
        1. Let the first option invoke a method that let the user input two numbers (a and b). 
        Check that b is not equal to zero and then output a divided by b to the screen.
        If b is equal to zero, display an error message to the user.
        2. Let the second option invoke the method used in exercise 4 (The quick fox jumped over the lazy dog).
        3. Let the third option toggle the foreground colour between two different colours each time you choose it. 
        (Use an if-statement to check the current colour)  */
        private static void RunExerciseTen()
        {
            Console.WriteLine("You sucessfully ran exercise ten!");
            Console.ResetColor();
        }
        /* In the exercise method, write the code that lets the user input an integer number. Check that the given number
         * is greater than 0. If not display an error message.
           Then write two for-loops, where one start from zero and counts up to the given number
           (0,1,2,3,4…, n) and another for-loop that starts counting from the given number down to zero (n,…,3,2,1,0).
            In both loops, check each number if it’s evenly divisible by 2. If it is, change the console colour to red,
            else to green. */
        private static void RunExerciseEleven()
        {
            Console.WriteLine("You sucessfully ran exercise eleven!");
            Console.ResetColor();
        }


        /*Write a program that output the multiplication table for 1 to 10 using nested for-loops. 
         *The format is not of great important but to make the code readably, add a tab after each number using the escape
         *character \t.*/
        private static void RunExerciseTwelve()
        {
            Console.WriteLine("You sucessfully ran exercise twelve!");
            Console.ResetColor();
        }
        /*Write a program that first generates a random number between 1 and 500 and stores it into a variable 
         * (see the Random class). Then let the user make a guess for which number it is. If the user types the 
         * correct number, he should be presented with a message (including the number of guesses he has made). 
         * If he types a number that is greater or smaller than the given number, display either “Your guess was
           too small” or “Your guess was too big”. The program should keep executing until the user input the correct guess.*/
        private static void RunExerciseThirteen()
        {
            Console.WriteLine("You sucessfully ran exercise thirteen!");
            Console.ResetColor();
        }

        /*Write a program that keeps asking the user for input numbers, until he enters -1. Store the 
         * amount of numbers the user have entered and the sum of the numbers added together. When the user types -1,
         * the program should display the sum and the average of the numbers.*/
        private static void RunExerciseFourteen()
        {
            Console.WriteLine("You sucessfully ran exercise fourteen!");
            Console.ResetColor();
        }

        /*code that asks the user for a number. Then display all numbers that the number is divisible by.
         * Example entering 12, should output 6, 4, 3, 2 and 1. Tip: use modulo and a loop.
           Write the program code that outputs the 3 first perfect numbers. A perfect number is a number where all
           its positive divisors sums up to the actual number. The first number is 6, where 3 + 2 + 1 = 6 and the 
           second is 28, where 14 + 7 + 4 + 2 + 1 = 28.*/
        private static void RunExerciseFifteen()
        {
            Console.WriteLine("You sucessfully ran exercise fifteen!");
            Console.ResetColor();
        }

        /*Write a program that asks the user for a number. Use this number to output the Fibonacci series
         * up until that number. Entering 10 should then output: 0, 1, 1, 2, 3, 5, 8, 13, 21 and 34.*/
        private static void RunExerciseSixteen()
        {
            Console.WriteLine("You sucessfully ran exercise sixteen!");
            Console.ResetColor();
        }

        /*Let the user input a string, then check if the string is a palindrome sentence. A palindrome is a word or sentence
         * that reads the same in both directions. Example of palindrome sentences are Loops at a spool, wet stew and level. 
         * However, the spaces might look different depending on which direction you read it, so these should be excluded
         * in your calculations, and a tip is to use some string manipulation to remove them.*/
        private static void RunExerciseSeventeen()
        {
            Console.WriteLine("You sucessfully ran exercise seventeen!");
            Console.ResetColor();
        }

        /*Create a new empty integer array of 10 elements. Loop through the array and assign each element to a new random value.
        Create a new empty array of doubles, having the same size as the previous array. Loop through that array and 
        assign the values to 1 divided by the value on the same position of the previous array. So if the first array
        has the value 42 on position 3, the second array should hold the double value 1 / 42.
        Finally, loop through both arrays and output the values to the screen using a foreach-loop.*/
        private static void RunExerciseEighteen()
        {
            Console.WriteLine("You sucessfully ran exercise eighteen!");
            Console.ResetColor();
        }

        /*a program that outputs a price that the customer (user) needs to pay. This should be an integer value. 
         * Then let the user input the sum he hands the cashier.
           Let your program then calculate the change that the customer should get back in different coin unit. For example, 
           if the user hands the cashier 500 kr. and the price is 376 kr., the change will be 124. 
           This can be divided up into 100x1 kr. + 20x1 kr. + 4x1 kr.
           The goal here is to get as few coins as possible.*/
        private static void RunExerciseNineteen()
        {
            Console.WriteLine("You sucessfully ran exercise nineteen!");
            Console.ResetColor();
        }

        /*Create two arrays with arbitrary size and fill one with random numbers. Then copy over the numbers from
         * the array with random numbers so that the even numbers are located in the rear (the right side) part of
         * the array and the odd numbers are located in the front part (the left side).*/
        private static void RunExerciseTwenty()
        {
            Console.WriteLine("You sucessfully ran exercise twenty!");
            Console.ResetColor();
        }

        /*Let the user input a string with numbers comma separated like “1,2,34,83,19,45”. 
         * Create the code to separate the numbers in the string into an array and find the 
         * min, max and average value. Print these out to the screen.*/
        private static void RunExerciseTwentyone()
        {
            Console.WriteLine("You sucessfully ran exercise twentyone!");
            Console.ResetColor();
        }

        /*
         The company See sharp AB  have asked you to write a swear word filter to censor harsh occurring words.
         Before implementing this filter on their website, they want a demonstration in form of a console program.
         The program should ask the user for a textual input. Then it should check for all occurrences of swear words.
         Store the swear words in an array and check the textual input against the array and use string manipulation to
         replace all swear words with something more appropriate.
         */
        private static void RunExerciseTwentytwo()
        {
            Console.WriteLine("You sucessfully ran exercise twentytwo!");
            Console.ResetColor();
        }

        /*Create a program that generates 7 unique numbers into an array. The numbers should be between 1 and 40. 
         * Each of the numbers may only appear once in the array! The numbers should be generated using the
         * Random-class, and should be different each time you run the program.*/
        private static void RunExerciseTwentythree()
        {
            Console.WriteLine("You sucessfully ran exercise twentythree!");
            Console.ResetColor();
        }

        private static void RunExerciseTwentyfour()
        {
            Console.WriteLine("You sucessfully ran exercise twentyfour!");
            Console.ResetColor();
        }

        private static void RunExerciseTwentyfive()
        {
            Console.WriteLine("You sucessfully ran exercise twentyfive!");
            Console.ResetColor();
        }

        private static void RunExerciseTwentysix()
        {
            Console.WriteLine("You sucessfully ran exercise twentysix!");
            Console.ResetColor();
        }

        private static void RunExerciseTwentyseven()
        {
            Console.WriteLine("You sucessfully ran exercise twentyseven!");
            Console.ResetColor();
        }

        private static void RunExerciseTwentyeight()
        {
            Console.WriteLine("You sucessfully ran exercise twentyeight!");
            Console.ResetColor();
        }

    }
}
