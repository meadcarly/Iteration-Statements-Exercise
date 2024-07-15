using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        // Done!  Write a method that will print to the console all numbers 1000 through - 1000
        public static void Numbers()
        {
            for (int i = 1000; i < 1001 && i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }

        /*public static void Numbers(1000)
          for(int i = 1000; i >= -1000; i--)
         {
            Console.WriteLine(i);
         }*/


    // Done!  Write a method that will print to the console numbers 3 through 999 by 3 each time
        
        public static void IncrementNumbersByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }
        
        // Done!  Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void CheckForEquality(int firstChoice, int secondChoice)
        {
            if (firstChoice == secondChoice)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        /*
         Public static void TwoNumbersSame(int numONE, Int numTwo)
         {
            if(numOne == numTwo)
            {
                Console.WriteLine("Same")
            }
            else
            {
            Console.WriteLine("not the same")
            }
         */    
    
        
        // Done! Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int numberOfDogs)
        {
            if (numberOfDogs % 2 == 0)
            {
                Console.WriteLine($"{numberOfDogs} is even");
            }
            else
            {
                Console.WriteLine($"{numberOfDogs} is odd");
            } 
        }
        
        // Done!  Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int peopleAtParty)
        {
            while (peopleAtParty != 0)
            {
                if (peopleAtParty > 0)
                {
                    Console.WriteLine($"{peopleAtParty} is a positive number");
                }
                else
                {
                    Console.WriteLine($"{peopleAtParty} is a negative number");
                }

                break;
            }
        }
        
        // Done!  Write a method to read the age of a candidate and determine whether they can vote.

        public static void CanYouVote()
        {
            Console.WriteLine("Enter your age");
            var canParse = int.TryParse(Console.ReadLine(), out int age);
            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age");
                canParse = int.TryParse(Console.ReadLine(), out age);
            }

            if (age >= 18)
            {
                Console.WriteLine("Congratulations, you can vote!");
            }
            else
            {
                    Console.WriteLine("Sorry, you are not old enough to vote yet.");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IsItInRange()
        {
            Console.WriteLine("Enter a number");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            while (!canParse)
            {
                Console.WriteLine("Please enter a valid number");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber > 10 && userNumber < -10)
            {
                Console.WriteLine($"The number {userNumber} is not in range.");
            }
            else
            {
                Console.WriteLine($"Congratulations! The number {userNumber} is in our range!");
            } 
        }
        
        // Done!  Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int x)
        {
            int[] multiplyMe = {x};
            
            foreach (int digit in multiplyMe)
            {
                for (int i = 1; i <= 12; i++)
                {
                    int result = digit * i;
                    Console.WriteLine($"{x} * {i} = {result}");
                }
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        { 
            Numbers(); 
            IncrementNumbersByThree();
            CheckForEquality(12, -12);
            EvenOrOdd(2);
            PositiveOrNegative(-3);
            CanYouVote();
            IsItInRange();
            MultiplicationTable(2);
        }
    }
}
