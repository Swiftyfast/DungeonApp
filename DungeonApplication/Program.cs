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
            Captain c1 = new Captain("Captain Greybeard", 5, 3, 1, 3, "Grizzled and uncompromising, Captain Greybeard expects perfection from his sailors.");
            Ship monty = new Ship("the Montgomery", c1, 2, 3, 1, "Basic Deckguns. Nothing Special.", true, false);
            //Console.WriteLine(sword);//-commented out after testing ToString() return

            //TODO x1. Create Encounters
            #region Encounters
            WorldEncounters we1 = new WorldEncounters("Heavy Storm", "A storm approaches. You cannot escape it. Consequences happen.");
            CombatEncounters ce1 = new CombatEncounters("Hammerhead Class", "A hammerhead class frigate appears out of the clouds. Good news lads- we're hunting sky pirate today.");
            #endregion
            Encounter[] encounterList = { we1, ce1 };




            //TODONE 2. Create a loop for the room and monster
            bool exit = false;
            do
            {
                //Determine Encounter
                //Room/Encounter Description
                //Make choice
                //Possibly loop if combat.






                //TODO 3. Call a new room 
                Console.WriteLine(GetRoom());
                //TODO 4. Create a monster
                Rabbit r1 = new Rabbit();
                Rabbit r2 = new Rabbit("White Rabbit", 25, 25, 35, 20, 2, 8, "That's no ordinary rabbit. Look at the bones.", true);
                Turtle t1 = new Turtle();
                Turtle t2 = new Turtle("Raphael", 30, 30, 25, 25, 0, 10, "Look at that turtle!", 10, 15);
                //Since Rabbit and other child classes are children of monster, all can be placed into an array of Monsters object.
                Vampire v1 = new Vampire("The Count", 15, 15, 25, 10, 1, 10, "One Vampire...ah, ah, ah!");
                Dragon d1 = new Dragon();
                Dragon d2 = new Dragon("Ancalagon the Black", 25, 25, 40, 10, 1, 12, "This is one fearsome dragon", true);
                Monster[] monsters = { r1, r2, t1, t2, v1, d1, d2 };

                //TODO x create Random for encounter array

                //Randomly select a monster from the array
                Random rand = new Random();
                int randomNumber = rand.Next(monsters.Length);
                Monster monster = monsters[randomNumber];
                Console.WriteLine("A Monster appears! " + monster.Name);
                //TODONE 5. Create a loop for the menu
                bool reload = false;

                do
                {
                    //TODONE 6. Create the menu
                    #region Menu
                    Console.WriteLine(c1);
                    Console.WriteLine(monty);
                    Console.Write("\n\nPlease Choose an Action:\n" +
                        "A) Attack\n" +
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
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                //it's dead - you could put the logic here to get items, get life back, or something simliar due to defeating the monster.
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();
                                //get a new room and monster
                                reload = true;
                                score++;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run for your life!\n");
                            //TODO 11. Build rn away logic and place here
                            Console.WriteLine($"{monster.Name} attacks you as you run away.");
                            Combat.DoAttack(monster, player);
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
                            Console.WriteLine(monster);
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
        //TODONE 15.Create GetRoom() and plug it in to TODO 3.
        //The signature below says that (private) it will only be available in this file,that it is a static method (only referring to itself), and that it returns a string.
        private static string GetRoom()
        {
            string[] rooms =
            {
                //list string descriptions of rooms comma-seperated
                "Red sky at morning. Sailors take warning.",
                "It's quiet. Too quiet.",
                "This short hall leads to another door. On either side of the hall, niches are set into the wall within which stand clay urns. One of the urns has been shattered, and its contents have spilled onto its shelf and the floor. Amid the ash it held, you see blackened chunks of something that might be bone.",
                "A huge stewpot hangs from a thick iron tripod over a crackling fire in the center of this chamber. A hole in the ceiling allows some of the smoke from the fire to escape, but much of it expands across the ceiling and rolls down to fill the room in a dark fog. Other details are difficult to make out, but some creature must be nearby, because it smells like a good soup is cooking.",
                "You find yourself in a room filled with lifelike sculptures. You start to get anxious as you notice the details of terror on each of their faces.",
                "You inhale a briny smell like the sea as you crack open the door to this chamber. Within you spy the source of the scent: a dark and still pool of brackish water within a low circular wall.Above it stands a strange statue of a lobster - headed and clawed woman.The statue is nearly 15 feet tall and holds the lobster claws crossed, covering its body.",
                "Fire crackles and pops in a small cooking fire set in the center of the room. The smoke from a burning rat on a spit curls up through a hole in the ceiling. Around the fire lie several fur blankets and a bag. It looks like someone camped here until not long ago, but then left in a hurry.",
                "The door creaks open, which somewhat overshadows the sound of bubbling liquid. Before you is a room about which alchemists dream. Three tables bend beneath a clutter of bottles of liquid and connected glass piping. Several bookshelves stand nearby stuffed to overfilling with a jumble of books, jars, bottles, bags, and boxes. The alchemist who set this all up doesn't seem to be present, but a beaker of green fluid boils over a burner on one of the tables.",
                " This room smells strange, no doubt due to the weird sheets of black slime that drip from cracks in the ceiling and spread across the floor. The slime seeps from the shattered stone of the ceiling at a snails crawl, forming a mess of dangling walls of gook. As you watch, a bit of the stuff separates from a sheet and drops to the ground with a wet plop.",
                "Thick cobwebs fill the corners of the room, and wisps of webbing hang from the ceiling and waver in a wind you can barely feel. One corner of the ceiling has a particularly large clot of webbing within which a goblin's bones are tangled."
            };

            Random rand = new Random();
            //since the maxValue is exclusive, we can just use the length to include all indeces from the array above.
            int indexNbr = rand.Next(rooms.Length);
            string room = "***** New Room *******\n" + rooms[indexNbr] + "\n";
            return room;
        }
    }
}
