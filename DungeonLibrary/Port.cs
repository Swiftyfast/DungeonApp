using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary.Classes;

namespace DungeonLibrary
{
    public class Port
    {

        //methods

        public static void GoToPort(int score, PlayerShip ship)
        {
            Console.Clear();
            Console.WriteLine("Your score is " + score + "\n\n");
            Console.WriteLine("What would you like to do?\n" +
                "A) Repair 3 hull for 2 score\n" +
                "B) Increase Weapons for 4 score\n" +
                "C) Increase Engines for 4 score\n" +
                "Any other key: return to the skys");
            ConsoleKey portChoice = Console.ReadKey(true).Key;

            switch (portChoice)
            {
                case ConsoleKey.A:
                    if (score >= 2)
                    //if (score >= 2 && ship.Hull -3 <= ship.MaxHull)
                    //Add in later if the ship max hull cant take another 3
                    {
                        ship.Hull = ship.Hull + 3;
                        score--;
                        score--;
                        Console.WriteLine("Hull repaired by 3.");
                    } else if (score < 2)
                    {
                        Console.WriteLine("Not high enough score to do this option.");
                    }
                    break;
                case ConsoleKey.B:
                    if (score >= 4)
                    {
                        ship.Weapons++;
                        score--;
                        score--;
                        score--;
                        score--;
                        Console.WriteLine("Ship weapons increase by 1. They are now " + ship.Weapons);
                    }
                    break;
                case ConsoleKey.C:
                    if (score >= 4)
                    {
                        ship.Engines++;
                        score--;
                        score--;
                        score--;
                        score--;
                        Console.WriteLine("Ship engines increase by 1. They are now " + ship.Engines);
                    }
                    break;
                default:
                    Console.WriteLine("Until next time, good port");
                    break;
            }
        }
    }   
}
