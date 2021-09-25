using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will be executed if no other case is evaluated");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch(today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!");
                    break;
            }

            Console.WriteLine("How are you feeling today? On a scale from 1-5?");
            string feeling = Console.ReadLine();
            //int feelingInt = int.Parse(feeling);
            //change string to int

            switch (feeling) 
            {
                case "1":
                case "0":
                    Console.WriteLine("Why are you not feeling well?");
                    break;
                case "2":
                    Console.WriteLine("How can you get to feeling better?");
                    break;
                case "3":
                    Console.WriteLine("Sorry you aren't feeling better");
                    break;
                case "4":
                    Console.WriteLine("Glad you are feeling good");
                    break;
                case "5":
                    Console.WriteLine("Wow! you are feeling great!");
                    break;
                default:
                    Console.WriteLine("That isn't between 1-5");
                    break;

            }
 

            //Challenge
            //ask user how they are feeling from scale 1-5 run through switch case and get a different statement for each level
            // let user know if they are out of range

            Console.ReadKey();
        }
    }
}
