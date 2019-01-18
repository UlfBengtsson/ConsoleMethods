using System;

namespace ConsoleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            double birthYear;
            int age;

            Console.WriteLine("Hello user!");
            firstName = AskUserForXText("First name");
            lastName = AskUserForXText("Last name");
            birthYear = AskUserForXNumber("Birth year");

            age = CalculateAge(birthYear);

            Console.WriteLine("\nSo " + firstName + " " + lastName + "\nYou are " + age + " years old.");   // I have added 2 other ways to use the Console.WriteLine method
            //Console.WriteLine("\nSo [0] [1]\nYou are [2] years old.", firstName, lastName, age);          // [0] will be replaced by a verible in acordense with the 0-based index number inside it, so the order you place the veribles after the string is important!
            //Console.WriteLine("\nSo {firstName} {lastName}\nYou are {age} years old.");                   // Inside the {} in the string you simpley need to writh the verible name, Intellisence works and your not limited to just using a verible but you can do calculations too. Ex. "{number1 + number2}"

            Console.WriteLine("\nPress any key to terminate the program");
            Console.ReadKey();
        }

        /// <summary>
        /// Will ask the user to input a text(string).
        /// </summary>
        /// <param name="name">A string that will be used to tell the user what text(string) to input.</param>
        static string AskUserForXText(string name)
        {
            Console.Write("Pleace input your " + name + ": ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Will ask the user to input a number and loop if it was not a number.
        /// </summary>
        /// <param name="name">A string that will be used to tell the user what number to input.</param>
        static double AskUserForXNumber(string name)
        {
            bool noNumber = true;
            double number = 0;

            do
            {
                Console.Write("Pleace input " + name + " number: ");
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());      // If you hover over the "ToDouble" method with the mouse, you will see that it can throw two types of exception (FormatException, OverflowException)
                    noNumber = false;                                   // This line of code will only be able to run if we don't get a exception when we try to convert the user input to a number(double).
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry but that dosent look like a number, Pleace try once more.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Sorry but that number is too big, Pleace try once more with a smaller number.");
                }

            } while (noNumber);

            return number;
        }

        /// <summary>
        /// Calculates how old someone is based on there birth year.
        /// </summary>
        static int CalculateAge(double birthYear)
        {
            int thisYear = DateTime.Now.Year;   // Gets the current year (according to the system clock).
            return thisYear - (int)birthYear;   // Here im forced to Type-cast the double birthYear into a int to make this work.
        }
    }
}
