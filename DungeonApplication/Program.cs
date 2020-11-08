using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Added the following for access to our classes.
using DungeonLibrary;
using DungeonLibrary.Classes;

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
            //Weapon sword = new Weapon(1, 8, "Long Sword", 10, false);
            //Player player = new Player("Sir Arthur", 70, 2, 40, 40, Race.Elf, sword);
            Captain c1 = new Captain("Captain Greybeard", "Tactics", "Grizzled and uncompromising, Captain Greybeard expects perfection from his sailors.");
            PlayerShip monty = new PlayerShip("the Montgomery", c1, 7, 10, 10, 5, true, false);
           
            //TODO x1. Create Encounters
            #region Encounters
            //WorldEncounters we1 = new WorldEncounters("world", "Heavy Storm", "A storm approaches. You cannot escape it. Consequences happen.", "The only way out is through. Baton down the hatches.", "Wits", "You've never felt more alive then flying in storms. You can handle this.", "Engines", 5);
            EnemyShip hammerHead = new EnemyShip("Hammerhead Class Frigate", "A hammerhead class frigate appears out of the clouds. Good news lads- we're hunting sky pirate today.", 3, 3, 3, 8, "Engineering", "Our hull can take a glancing blow, and we can follow that up with a point blank shot.");
            EnemyShip scorpion = new EnemyShip("Scorpion Class Gunship", "Scorpion class gunship following behind us, Captain. Not responding to communications. Looks like she's waiting for a chance to attack.", 3, 5, 5, 7, "Tactics", "Keep it moving- they're not a mobile vessel. And don't stay in front of that tail cannon for too long.");
            EnemyShip voidSquid = new EnemyShip("Voidsquid light crusior", "Voidsquid light crusior. I didn't know that they could get into our territory with those things. We can't let it escape.", 4, 6, 6, 5, "Wits", "Try and tangle it's arms. It'll be less effective that way.");
            EnemyShip distressSignalOne = new EnemyShip("Scuttled Altaris Heavy Crusior", "One of the old ships, Captain, looks like an Altaris Heavy Crusior. And it looks dead in the water. Metaphorically, of course. Only pirates use these things anymore, what should we do?", 1, 2, 2, 7, "Charisma", "Let's hail them. Get them to surrender without bloodshed.");
            #endregion
            //Encounter[] worldEncounterArray = { we1 };
            //Encounter[] combatEncounterArray = { ce1 };
            //Encounter[] encounterArray = { hammerHead };
            EnemyShip[] enemyShipArray = { hammerHead, scorpion, voidSquid, distressSignalOne };

            //TODONE 2. Create a loop for the room and monster
            bool exit = false;
            do
            {
                //TODONE 3. Call a new room 
                Console.WriteLine(GetRoom());

                Random rand = new Random();
                int encounterNumber = rand.Next(enemyShipArray.Length);
                EnemyShip encounter = enemyShipArray[encounterNumber];

                Console.WriteLine("Captain, we have a ship on sensors!");
                Console.WriteLine(encounter.Description);
               
                bool reload = false;

                ////TO DO FOR SUNDAY
                ///////TO DO FOR SUNDAY
                ///////TO DO FOR SUNDAY
                ///////TO DO FOR SUNDAY
                ///////TO DO FOR SUNDAY
                //do combat

                //if time
                //let players choose captain
                //let players choose ship

                do
                {
                    //TODONE 6. Create the menu
                    #region Menu
                    //Check potential other options.
                    string secondOption = CheckSecondOption(encounter.Weakness, encounter.WeaknessText, c1);
                   
                    Console.Write("\n\nPlease Choose an Action:\n" +
                        "A) Attack!\n" +
                        secondOption +
                        "R) Run Away\n" +
                        "S) Player Ship Info\n" +
                        "Z) Encounter Info\n" +
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
                            Console.WriteLine("\n");
                            
                            break;
                        case ConsoleKey.B:
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run for your life!\n");
                            //TODO 11. Build rn away logic and place here
                            Console.WriteLine($"{encounter.Name} attacks you as you run away.");
                            //Combat.DoAttack(monster, player);
                            reload = true;
                            break;
                        case ConsoleKey.S:
                            Console.WriteLine("Player Ship info\n");
                            //TODONE 12. Add player info
                            Console.WriteLine(monty);
                            break;
                        case ConsoleKey.Z:
                            Console.WriteLine("Encounter info\n");
                            //TODO 13. Add Monster info
                            Console.WriteLine(encounter);
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
                    if (monty.Hull <= 0)
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
