using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Classes
{
    class Noncombat
    {


        public static void NonCombat(PlayerShip ship, EnemyShip encounter, string userInput)
        {
            string skill = ship.MyCaptain.Expertise;
            string weakness = encounter.Weakness;

            if (userInput == skill && userInput == weakness)
            {
                //Resolve a lot of good things.
            } else if (userInput == weakness)
            {
                //Some good things here
            } else if (userInput == skill)
            {
                //Random chance, like 1/3
            } else
            {
                //Random chance like 1/10
            }

        }

    }
}
