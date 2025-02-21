using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mycode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Random dice = new Random();
            Console.WriteLine("Welcome to the 16 game: ");
            Console.WriteLine("The goal of this game is to get as close as possible to the number 16 in 3 dice rolls\nYou mustn't go over 16 else you lose and die\nIf you get 16 you win automatically");
            Console.WriteLine("You'll be up against an AI");
            Console.WriteLine("To begin type \'roll\': ");
            int total = 0;
            int aitotal = 0;
            
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "roll")
                {
                    int roll = card.Hit();
                    int airoll = dice.Next(1, 7);
                    Console.WriteLine($"You: {roll}");
                    Console.WriteLine($"AI: {airoll}");
                    total += roll;
                    aitotal += airoll;
                }
                else
                {
                    Console.WriteLine("Please type \'roll\'");
                    continue;
                }
            }

            if (total > 16 && aitotal > 16)
            {
                Console.WriteLine($"You and the AI lost you had {total} and AI had {aitotal}");
            }
            else if (total > 16 && aitotal < 16)
            {
                Console.WriteLine($"AI wins, you had {total} and AI had {aitotal}");
            }
            else if (aitotal < 16 && aitotal > total)
            {
                Console.WriteLine($"AI wins, you had {total} and AI had {aitotal}");
            }
            else if (total < 16 && total > aitotal)
            {
                Console.WriteLine($"You win, you had {total} and AI had {aitotal}");
            }
            else if (total < 16 && total == aitotal)
            {
                Console.WriteLine($"It's a tie, you had {total} and AI had {aitotal}");
            }

            Console.ReadLine();
            
        }
    }
    

    class Card
    {
        public int Hit()
        {
            Random dice = new Random();
            int role1 = dice.Next(1, 7);
            return role1;
        }

    }
}
