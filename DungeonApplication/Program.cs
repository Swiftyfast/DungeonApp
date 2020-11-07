using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Added the following for access to our classes.
using DungeonLibrary;
using DungeonLibrary.Classes;
using DungeonLibrary.Encounters;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the program that will control the flow of the overall program (the experience of the user). All classes will be built in seperate files and referred to in this program to allow us to use instances of the objects.
            Console.Title = "Hunting Skyship Pirates";
            Console.WriteLine("Your journey begins...\n");
            //Keep a running total variable for the user's score.
            int score = 0;
            int crewMorale = 50;
            //TODO 1. Create a Weapon and a Player
            Weapon sword = new Weapon(1, 8, "Long Sword", 10, false);
            Player player = new Player("Sir Arthur", 70, 2, 40, 40, Race.Elf, sword);
            Captain c1 = new Captain("Captain Greybeard", "Wits", "Grizzled and uncompromising, Captain Greybeard expects perfection from his sailors.");
            Ship monty = new Ship("the Montgomery", c1, 2, 3, 1, "Basic Deckguns. Nothing Special.", true, false);
            //Console.WriteLine(sword);//-commented out after testing ToString() return


            //TODO x1. Create Encounters
            #region Encounters
            WorldEncounters we1 = new WorldEncounters("Heavy Storm", "A storm approaches. You cannot escape it. Consequences happen.", "The only way out is through. Baton down the hatches.", "Wits", "You've never felt more alive then flying in storms. You can handle this.");
            CombatEncounters ce1 = new CombatEncounters("Hammerhead Class", "A hammerhead class frigate appears out of the clouds. Good news lads- we're hunting sky pirate today.", "Attack!", "Tactics", "Our hull can take a glancing blow, and we can follow that up with a point blank shot.");
            #endregion
            Encounter[] worldEncounterArray = { we1 };
            Encounter[] combatEncounterArray = { ce1 };

            //TODONE 2. Create a loop for the room and monster
            bool exit = false;
            do
            {
                //TODONE 3. Call a new room 
                Console.WriteLine(GetRoom());

                Random rand = new Random();
                int coinFlip = rand.Next(1, 3);
                Encounter encounter;
                if (coinFlip == 1)
                {
                    int randomEncounter = rand.Next(worldEncounterArray.Length);
                    encounter = worldEncounterArray[randomEncounter];
                } else
                {
                    int randomEncounter = rand.Next(combatEncounterArray.Length);
                    encounter = combatEncounterArray[randomEncounter];
                }
               
                
                Console.WriteLine(encounter.Description);
               
                bool reload = false;

                do
                {
                    //TODONE 6. Create the menu
                    #region Menu
                    //Check potential other options.
                    string secondOption = CheckSecondOption(encounter.SecondOptionGetter, encounter.SecondOptionText, c1);
                   // string hopeThisWorks = wit3.ConType;
                    //if (hopeThisWorks == "Engineering")
                    //{

                    //} else if (hopeThisWorks == "Tactics")
                    //{

                    //} else if (hopeThisWorks == "Charisma")
                    //{

                    //} else if (hopeThisWorks == "Wits" && w)
                    //{
                    //    secondOption= wit3.
                    //}
                    Console.Write("\n\nPlease Choose an Action:\n" +
                        //"A) Attack\n" +
                        "A) " + encounter.BaseOption + "\n" +
                        secondOption +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit the application\n\n" +
                        $"Score: {score}\n\n");
                    #endregion
                    //TODONE: get user choice
                    #region UserChoice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    #endregion

                    //TODO 8. Clear the console after we get input from the user
                    Console.Clear();

                    //TODO 9. Build out the switch for userChoice
                    #region Game Experience - Switch
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack\n");
                            //TODO 10. Build attack logic and place here.
                            //Combat.DoBattle(player, monster);
                            //if (monster.Life <= 0)
                            //{
                            //    //it's dead - you could put the logic here to get items, get life back, or something simliar due to defeating the monster.
                            //    Console.ForegroundColor = ConsoleColor.Green;
                            //    Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                            //    Console.ResetColor();
                            //    //get a new room and monster
                            //    reload = true;
                            //    score++;
                            //}
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run for your life!\n");
                            //TODO 11. Build rn away logic and place here
                            //Console.WriteLine($"{monster.Name} attacks you as you run away.");
                            //Combat.DoAttack(monster, player);
                            reload = true;
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player info\n");
                            //TODONE 12. Add player info
                            Console.WriteLine(player);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster info\n");
                            //TODO 13. Add Monster info
                            //Console.WriteLine(monster);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("No one likes a quitter...Be gone!\n");
                            exit = true;//Upate exit
                            break;
                        default:
                            Console.WriteLine("Thou hast chosen an improper action. Choose a key from the menu or suffer in purgatory!\n");
                            break;
                    }//end switch
                    #endregion
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude...you died\n");
                        exit = true;
                    }
                    //TODO 14. Handle player life
                } while (!reload && !exit);
            } while (!exit);//while exit is NOT TRUE keep in the loop

        } //end Main()

        private static string GetRoom()
        {
            //locations must have a space after the period for formatting reasons.
            string[] locations = { "Surveying the minefield near the neutral zone. ", "Patroling shipping lanes outside capital skyspace. ", "Executing training drills above the fog swamp. ", "Transporting medical supplies to a nearby military port. ", "Investigating pirate rumors near the port of South Harbor. ", "Approaching the capital to do a fly over. Useless political theater. "};
            string[] daytimes = { "Red sky at morning. Sailors take warning.", "Mid mourning. My gut tells me it's too quiet.", "Clocks say high noon. Tough to tell with the clouds we have. ", "Dusk. Perfect time for a sky pirate to ambush us. ", "Just after sunset. Wish I could get some sleep, but not tonight. ", "Just after midnight." };
            
            Random rand = new Random();
            int indexNbr = rand.Next(locations.Length);
            int indexNbr2 = rand.Next(daytimes.Length);
            string combo = "***** Captain's Log *******\n" + locations[indexNbr] + daytimes[indexNbr2] + "\n";

            return combo;
        }

        private static string CheckSecondOption(string input, string text, Captain capn)
        {
            if (input == capn.Expertise)
            {
                return "B) " + text + "\n";
            }
            return "";
        }
    }
}
