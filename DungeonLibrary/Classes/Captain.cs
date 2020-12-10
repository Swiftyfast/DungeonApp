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
        public string Expertise { get; set; }
        public string Description { get; set; }


        //ctor
        /// <summary>
        /// This will be your fearless leader as you travel the skies.
        /// </summary>
        /// <param name="name">The Name of the Captain</param>
        /// <param name="expertise">What this captain excels at</param>
        /// <param name="description">"describe the captain</param>
        public Captain(string name, string expertise, string description)
        {
            Name = name;
            Expertise = expertise;
            Description = description;
        }

        public Captain() { }
        
        //methods
        public override string ToString()
        {
            return string.Format("Captain name: " + Name + "\n" +
                "Expertise: " + Expertise);
        }

    }
}
