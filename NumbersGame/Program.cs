using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
/* NumbersGame
 * This program asks the user whether they want to play a game, and if so, asks them to provide a number between 1 and 10. Switch statements are then used to check
 * whether the user is a "winner" or not.
 */
            {
                UserPrompt1();
            }

            static void UserPrompt1()
            {
// Ask the user if they want to play the numbers game, storing answer in variable Input1.
                Console.WriteLine("$Let's play the numbers game. Answering Yes or No, do you want to play?");
                string Input1 = Console.ReadLine();

// Convert user input Input1 to lower case variable Answer1 (to account for "NO/No/no" etc).                
                string Answer1 = Input1.ToLower();
// Switch statements to check whether yes/no/other was submitted 
                switch (Answer1)
                {
                    case "yes":
                        Console.WriteLine($"Glad you want to play. Now, pick a number between 1 and 10");
                        string Input2 = Console.ReadLine();
                        break;
                    case "no":
                        Console.WriteLine($"I'm sad that you don't want to play. However, I will in time accept" +
                            $" your decision. Goodbye!");
                        break;
                    default:
                        Console.WriteLine($"'{Input1}' is not a Yes or No answer. You'll have to run this whole program again, and put in the correct" +
                        $" answer, because I haven't learnt how to do loops.");
                        break;
                }
// Convert Input2 from string to integer
                

            }
        } 
    }
}
