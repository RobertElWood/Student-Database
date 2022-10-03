
using System;

namespace Student_Database_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Alexander", "Amanda", "Brittany", "Christina", "David",
            "Jessica", "McKayla", "Noah", "Logan", "William" };

            string[] favFoods = { "Pizza", "Cheeseburgers", "Lamb Madras", "Eggplant Parmagiana", "Sushi",
            "Falafel", "Crab Rangoon", "Mac 'n' Cheese", "Ribeye Steak", "Bibimbap"};

            string[] homeTown = { "Stockholm, Sweden", "Allentown, PA", "McComb, MS", "Saint Louis, MO", "Bathgate, UK",
            "Pomona, CA", "Aliso Viejo, CA", "Kalamazoo, MI", "London, KY", "Marshall, MI"};

            bool goAgain = true;

            Console.WriteLine("\nHello! Welcome to the Anytown University database!\n");
            Console.WriteLine("Here you can get up-to-date demographic information on all of our totally real students. Totally.\n");
            Console.WriteLine("Unfortunately, as an intern *cough* Kevin *cough* spilled copious amounts of soft drink on our server rack...\n");
            Console.WriteLine("We can only provide a fraction of our usual information.\n");
            Console.WriteLine("We can currently provide you with information on our students' favorite foods and their hometowns.");

            while (goAgain)
            {
                Console.WriteLine("\nPlease enter a number, one through ten, to look up your student.\n");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input > students.Length)
                {
                    Console.WriteLine("\nI'm sorry, that number is too high. Please enter another to look up your student!\n");
                    continue;
                }

                int indexStudent = input - 1;

                Console.WriteLine("\nYou have selected student: " + students[indexStudent] + "\n");


                bool runAgain = true;

                while (runAgain)
                {
                   
                    Console.WriteLine("Please enter 'Hometown' or 'Favorite Food' to look up information on " + students[indexStudent] + ".\n");
                    Console.WriteLine("If you wanted more information than that...Well, blame Kevin.\n");

                    string choice = Console.ReadLine();
                    Console.WriteLine();

                    if (choice == "Hometown" || choice == "hometown" || choice == "town" || choice == "home" || choice == "Town" || choice == "Home") 
                    {
                        Console.WriteLine( students[indexStudent] + "'" + "s home town is: " + homeTown[indexStudent] + "." );
                        runAgain = false;
                    } 
                    else if (choice == "Favorite Food" || choice == "Food" || choice == "favorite" || choice == "food" || choice == "Favorite" || choice == "favorite food") 
                    {
                        Console.WriteLine(students[indexStudent] + "'" + "s favorite food is: " + favFoods[indexStudent] + ".");
                        runAgain = false;
                    } 
                    else 
                    {
                        Console.WriteLine("I'm sorry. Kevin's errant Mountain Dew may have erased that category, or that may be invalid information\n");
                        Console.WriteLine("Please re-enter either 'Hometown' or 'Favorite Foods' to view info for " + students[indexStudent] + ".\n");
                    }
                   
                }

                goAgain = askAgain();

            }

        }
        public static bool askAgain()
        {
            Console.WriteLine("\nWould you like to view information on another student? Y/N?\n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("\nThank you for using our database! And if you see Kevin...Tell him to stay off of the Mountain Dew...");
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't understand that. Please try again!");
                return askAgain();
            }
        }

    }
}