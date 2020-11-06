using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Classes
{
    public class Captain
    {
        //fields

        //props
        public string Name { get; set; }
        public int Tactics { get; set; }
        public int Engineering { get; set; }
        public int Charisma { get; set; }
        public int Wits { get; set; }
        public string Description { get; set; }


        //ctor
        /// <summary>
        /// This will be your fearless leader as you travel the skies.
        /// </summary>
        /// <param name="name">The Name of the Captain</param>
        /// <param name="tactics">How good they are tactically.</param>
        /// <param name="engineering">How good they are at repairing the ship.</param>
        /// <param name="charisma">How charismatic they are.</param>
        /// <param name="wits">How they can figure something out.</param>
        /// <param name="description">"describe the captain</param>
        public Captain(string name, int tactics, int engineering, int charisma, int wits, string description)
        {
            Name = name;
            Tactics = tactics;
            Engineering = engineering;
            Charisma = charisma;
            Wits = wits;
            Description = description;
        }

        public Captain() { }
        //The idea right now is out of the 4 stats, they get 1 5, 1 1, and 2 3s.



        //methods
        public override string ToString()
        {
            return Name;
        }

    }
}
