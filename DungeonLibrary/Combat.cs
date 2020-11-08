using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary.Classes;

namespace DungeonLibrary
{
    public class Combat
    {
        //This class will not have fields, props, or any custom constructors as it is just a "warehouse" for different methods.
        //public static void DoAttack(Character attacker, Character defender)
        public static void DoAttack(Ship attacker, Ship defender)
        {
            //check if special

            //get random number area stuff
            int thisNumberOrBelow = defender.Engines;
            int attackerWeapons = attacker.Weapons;

            Random rand = new Random();
            int randomNumber = rand.Next(thisNumberOrBelow + attackerWeapons);
            
            //apply if special
            
            
            //return results
            if (randomNumber <= thisNumberOrBelow)
            {
                defender.Hull--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1}! {1}'s hull is down to {2} strength!\n", attacker.Name, defender.Name, defender.Hull);
                defender.Hull--;
                Console.ResetColor();
            } else
            {
                Console.WriteLine("{0} missed!\n", attacker.Name);
            }
            
            
            
           // //get a random number between 1-100 as our dice roll
           // Random rand = new Random();
           // int diceRoll = rand.Next(1, 101);
           // System.Threading.Thread.Sleep(30);
           //// if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
           //  if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
           //  {
           //     //if the attacker hit, calc damage
           //     int damageDealt = attacker.CalcDamage();

           //     //assign the damage
           //     defender.Life -= damageDealt;

           //     //Write the result to the screen
           //     Console.ForegroundColor = ConsoleColor.Red;
           //     Console.WriteLine("{0} hit {1} for {2} damage!\n", attacker.Name, defender.Name, damageDealt);
           //     Console.ResetColor();
           // }//end if
           // else
           // {
           //     //The attacker missed
           //     Console.WriteLine("{0} missed!\n", attacker.Name);
           // }//end else
        }//end DoAttack()

        public static void DoBattle(PlayerShip player, EnemyShip monster)
        {
            //Player attacks
            DoAttack(player, monster);

            //If the monster is still alive, it attacks
            if (monster.Hull > 0)
            {
                DoAttack(monster, player);
            }

        }
    }
}
