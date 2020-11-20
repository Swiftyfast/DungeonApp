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
            Console.Title = "Hunting Skyship Pirates";
            Console.WriteLine("Your journey begins...\n");
            int score = 0;
            #region Captains
                Captain greybeard = new Captain("Captain Greybeard", "Tactics", "Grizzled and uncompromising, Captain Greybeard expects perfection from his sailors.");
            Captain rahvenzwood = new Captain("Captain Rahvenzwood", "Wits", "Always looking for a turn of phrase and with a smirk seemingly stuck on their mouth, Captain Rahvenzwood doesn't just want to defeat the enemy- they want to outsmart them.");
            Captain valdarion = new Captain("Captain Valdarion", "Charisma", "A well kept ship and crew is a priority for Captain Valdarion, who is always drawing stares wether at a government function, the military academy, or about in civilian life.");
            Captain arja = new Captain("Captain Arja", "Engineering", "Short in stature but tall in legend, Captain Arja makes sure to know the equipment that they are sailing to battle with exceptionally well.");
            #endregion
            #region Ships

            #endregion
            #region Choosing a Captain
            Captain playerCaptain = new Captain();
            //Console.WriteLine("Please choose a Captain: +\n" +
            //    "A) Captain Greybeard - Tactics\n" +
            //    "B) Captain Rahvenzwood - Wits\n" +
            //    "C) Captain Valdarion - Charisma\n" +
            //    "D) Captain Arja - Engineering\n" +
            //    "S) Descriptions of the Captains\n" +
            //    "X) Exit the Application");

            ////Some Logic
            //ConsoleKey captainChoice = Console.ReadKey(true).Key;
            //switch (captainChoice)
            //{
            //    case ConsoleKey.A:
            //        playerCaptain = greybeard;
            //        break;
            //    case ConsoleKey.B:
            //        playerCaptain = rahvenzwood;
            //        break;
            //    case ConsoleKey.C:
            //        playerCaptain = valdarion;
            //        break;
            //    case ConsoleKey.D:
            //        playerCaptain = arja;
            //        break;
            //    case ConsoleKey.S:
            //        break;
            //    case ConsoleKey.E:
            //    case ConsoleKey.X:
            //        break;
            //    default:
            //        Console.WriteLine("That was not a valid key. Goodbye");
            //        //Change this to nothing after getting a do-while for Captains made.
            //        break;
            //}
            #endregion
            //Console.WriteLine("Please choose a Ship: \n" +
            //    "A) the Montgomery\n" +
            //    "B) the Excalibur\n" +
            //    "C) the Tempest\n" +
            //    "D) the White Rose\n" +
            //    "S) Show stats for each ship\n" +
            //    "X) Exit the Application");

            ////Some Logic

            //Below are the captain and ship that are for testing
            Captain c1 = new Captain("Captain Greybeard", "Tactics", "Grizzled and uncompromising, Captain Greybeard expects perfection from his sailors.");
            PlayerShip monty = new PlayerShip("the Montgomery", c1, 7, 12, 12, 5, true, false);
            //Additional Ships 
            PlayerShip excalibur = new PlayerShip("the Excalibur", c1, 5, 12, 12, 9, false, false);
            PlayerShip tempest = new PlayerShip("the Tempest", c1, 7, 10, 10, 7, false, true);
            PlayerShip rose = new PlayerShip("the White Rose", c1, 5, 12, 12, 5, true, true);

            bool exit = false;
            do
            {
                #region Encounter List
                EnemyShip hammerHead = new EnemyShip("Hammerhead Class Frigate", "A hammerhead class frigate appears out of the clouds. Good news lads- we're hunting sky pirate today.", 3, 3, 3, 8, "Engineering", "Our hull can take a glancing blow, and we can follow that up with a point blank shot.");
                EnemyShip scorpion = new EnemyShip("Scorpion Class Gunship", "Scorpion class gunship following behind us, Captain. Not responding to communications. Looks like she's waiting for a chance to attack.", 3, 5, 5, 7, "Tactics", "Keep it moving- they're not a mobile vessel. And don't stay in front of that tail cannon for too long.");
                EnemyShip voidSquid = new EnemyShip("Voidsquid light crusior", "Voidsquid light crusior. I didn't know that they could get into our territory with those things. We can't let it escape.", 4, 6, 6, 5, "Wits", "Try and tangle it's arms. It'll be less effective that way.");
                EnemyShip loneFighter = new EnemyShip("A single pirate fighter", "Small personal craft dead ahead, Captain! Looks like it's a pirate and looks like it's alone", 1, 1, 1, 1, "Tactics", "Cut them off at the pass");
                EnemyShip fighterSquadron = new EnemyShip("Four pirate fighters", "Four unidentified fighters heading this way Captain. Not responding to communications.", 4, 4, 4, 4, "Engineering", "Show them the thick part of our hull as they advance. They won't be able to pierce our metal hide.");
                SittingDuck distressSignalOne = new SittingDuck("Scuttled Altaris Heavy Crusior", "One of the old ships, Captain, looks like an Altaris Heavy Crusior. And it looks dead in the water. Metaphorically, of course. Only pirates use these things anymore, what should we do?", 1, 2, 2, 7, "Charisma", "Let's hail them. Get them to surrender without bloodshed.");
                SittingDuck distressSignalTwo = new SittingDuck("Broken Cruise ship", "Captain, there is a heavily damaged passenger ship, barely in the sky and headed for a crash landing in populated area. We think there are still survivors aboard. What should we do?", 1, 2, 2, 7, "Engineering", "Try and nudge them out of the way. I know just the spot along the hull.");
                SittingDuck distressSignalThree = new SittingDuck("Betelguese Light crusior", "An old fleet ship, Captain. They are communicating with us, and are saying that there is some strange gas leak that's affecting the crew. They are requesting assistance", 1, 2, 2, 7, "Wits", "Let's hail them. Ask them if the gas sinks or raises to the ceiling...");
                SittingDuck distressSignalFour = new SittingDuck("Mirror ship", "Two enemy ships heading for a trade caravan sir. We can take them, but if we engage one the other one will make a break for it.", 1, 2, 2, 7, "Tactics", "Let's hail them. Get them to surrender without bloodshed.");
                #endregion
                EnemyShip[] enemyShipArray = { hammerHead, scorpion, voidSquid, fighterSquadron, loneFighter, distressSignalOne, distressSignalTwo, distressSignalThree, distressSignalFour };
                //Test Array below, real one above
                //EnemyShip[] enemyShipArray = { distressSignalOne, distressSignalTwo, distressSignalThree, distressSignalFour };
                //*******************************
                //*******Call a new room*********
                //******************************
                Console.WriteLine(GetRoom());

                Random rand = new Random();
                int encounterNumber = rand.Next(enemyShipArray.Length);
                EnemyShip encounter = enemyShipArray[encounterNumber];

                Console.WriteLine("Captain, we have a ship on sensors!");
                Console.WriteLine(encounter.Description);

                //Console.WriteLine(encounter.GetType());
                //string getTypeCheck = encounter.GetType();
                bool reload = false;
                if (encounter.GetType() == hammerHead.GetType())
                {
                    //Console.WriteLine("It's a enemyShip, and this worked");
                    do
                    {
                        //TODONE 6. Create the menu
                        #region Menu
                        //Check potential other options.
                        string secondOption = CheckSecondOption(encounter.Weakness, encounter.WeaknessText, c1);
                        Console.Write("\n\nPlease Choose an Action:\n" +
                            "A) Attack!\n" +
                            secondOption +
                            "P) Run Away, but return to port\n" +
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

                        #region Game Experience - Switch

                        switch (userChoice)
                        {
                            case ConsoleKey.A:
                                Console.WriteLine("\n");
                                Combat.DoBattle(monty, encounter);
                                if (encounter.Hull <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Sir, we shot them out of the sky!\n");
                                    score++;
                                    Console.ResetColor();
                                    reload = true;
                                }
                                break;
                            #region Special Trait logic
                            case ConsoleKey.B:
                                Combat.DoAttack(monty, encounter);
                                if (encounter.Hull > 0)
                                {
                                    Combat.DoBattle(monty, encounter);
                                }
                                if (encounter.Hull <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Sir, we shot them out of the sky!\n");
                                    score++;
                                    score++;
                                    Console.ResetColor();
                                    reload = true;
                                }

                                break;
                            #endregion
                            case ConsoleKey.P:
                                //Console.WriteLine("Return to Port");
                                Combat.DoAttack(encounter, monty);
                                Port.GoToPort(score, monty);
                                reload = true;
                                break;
                            case ConsoleKey.R:
                                Console.WriteLine("Run for your life!\n");
                                //TODO 11. Build rn away logic and place here
                                Console.WriteLine($"{encounter.Name} attacks you as you run away.");
                                Combat.DoAttack(encounter, monty);
                                reload = true;
                                break;
                            case ConsoleKey.S:
                                Console.WriteLine("Player Ship info\n");
                                //TODONE 12. Add player info
                                Console.WriteLine(monty);
                                break;
                            case ConsoleKey.Z:
                                Console.WriteLine("Encounter info\n");
                                //TODONE 13. Add Monster info
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
                } else if (encounter.GetType() == distressSignalOne.GetType())
                {
                    #region SittingDucks Menu
                    //User menu
                    Console.WriteLine("A) Use your engineering knowledge\n" +
                        "B) Use your tactical knowledge\n" +
                        "C) Use your charisma\n" +
                        "D) Use your wits\n" +
                        "P) Return to port\n" +
                        "R) Run away\n" +
                        "X) Exit the Application\n\n" +
                            $"Score: {score}\n\n");
                    #endregion
                    //TODONE: get user choice
                    #region UserChoice
                    ConsoleKey sittingDuckChoice = Console.ReadKey(true).Key;
                    #endregion

                    //TODO 8. Clear the console after we get input from the user
                    Console.Clear();

                    switch (sittingDuckChoice)
                    {
                        case ConsoleKey.A:
                            //Engineering
                            if (encounter.Weakness == "Engineering")
                            {
                                Console.WriteLine("Complete success, Captain! Your engineering knowledge proves itself invaluable yet again.");
                                score++;
                                score++;
                                reload = true;
                            } else if (monty.MyCaptain.Expertise == "Engineering")
                            {
                                Console.WriteLine("Well that didn't go perfect...but we made it.");
                                score++;
                                reload = true;
                            } else
                            {
                                Console.WriteLine("Sir, not sure how your Engineering expertise was supposed to help there. We have taken damage...");
                                monty.Hull--;
                                reload = true;
                            }
                            break;
                        case ConsoleKey.B:
                            //Tactics
                            if (encounter.Weakness == "Tactics")
                            {
                                Console.WriteLine("Complete success, Captain! Your tactics were impeccable");
                                score++;
                                score++;
                                reload = true;
                            }
                            else if (monty.MyCaptain.Expertise == "Tactics")
                            {
                                Console.WriteLine("Well that didn't go perfect...but we made it.");
                                score++;
                                reload = true;
                            }
                            else
                            {
                                Console.WriteLine("A little too much bravado with the aggressive tactics, Captain. We have taken damage...");
                                monty.Hull--;
                                reload = true;
                            }
                            break;
                        case ConsoleKey.C:
                            //Charisma
                            if (encounter.Weakness == "Captain, that was a complete success! You may be the most charismatic sailor in the fleet!")
                            {
                                Console.WriteLine("Complete success, Captain!");
                                score++;
                                score++;
                                reload = true;
                            }
                            else if (monty.MyCaptain.Expertise == "Charisma")
                            {
                                Console.WriteLine("Well that didn't go perfect...but we made it.");
                                score++;
                                reload = true;
                            }
                            else
                            {
                                Console.WriteLine("Guess they didn't want to talk after all! We have taken damage...");
                                monty.Hull--;
                                reload = true;
                            }
                            break;
                        case ConsoleKey.D:
                            //Wits
                            if (encounter.Weakness == "Wits")
                            {
                                Console.WriteLine("We didn't know where you were going, Captain, but your wits have been proven second to none.");
                                score++;
                                score++;
                                reload = true;
                            }
                            else if (monty.MyCaptain.Expertise == "Wits")
                            {
                                Console.WriteLine("Well that didn't go perfect...but we made it.");
                                score++;
                                reload = true;
                            }
                            else
                            {
                                Console.WriteLine("Can't think your way out of every situation, Captain. We have taken damage...");
                                monty.Hull--;
                                reload = true;
                            }
                            break;
                        default:
                            break;
                    }


                }
                //Might need to make this code fore everything or put it right here.
                //if (monty.Hull <= 0)
                //{
                //    Console.WriteLine("Dude...you died\n");
                //    exit = true;
                //}
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
