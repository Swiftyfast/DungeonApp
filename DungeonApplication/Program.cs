using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Added the following for access to our classes.
using DungeonLibrary;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the program that will control the flow of the overall program (the experience of the user). All classes will be built in seperate files and referred to in this program to allow us to use instances of the objects.
            Console.Title = "Dungeon of Doom";
            Console.WriteLine("Your journey begins...\n");
            //Keep a running total variable for the user's score.
            int score = 0;

            //TODO 1. Create a Weapon and a Player
            Weapon sword = new Weapon(1, 8, "Long Sword", 10, false);
            //Console.WriteLine(sword);//-commented out after testing ToString() return



            //TODONE 2. Create a loop for the room and monster
            bool exit = false;
            do
            {
                //TODO 3. Call a new room 
                Console.WriteLine(GetRoom());
                //TODO 4. Create a monster
                //TODONE 5. Create a loop for the menu
                bool reload = false;

                do
                {
                    //TODONE 6. Create the menu
                    #region Menu
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
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run for your life!\n");
                            //TODO 11. Build rn away logic and place here
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player info\n");
                            //TODO 12. Add player info
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster info\n");
                            //TODO 13. Add Monster info
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("No one likes a quitter...Be gone!\n");
                            exit = true;//Upate exit
                            break;
                        default:
                            Console.WriteLine("Thou hast chosen an improper action. Choose a key from the menu or suffer in purgatory!\n");
                            break;
                    }
                    #endregion
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
                "The room is dark and musty with the smell of lost souls.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
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
