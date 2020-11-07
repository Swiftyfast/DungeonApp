using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Encounters
{
    public class WorldEncounters : Encounter
    {
        //fields

        //props
        //base option
        //public string BaseOption { get; set; }
        //public ConsequenceHandler BaseConsequences { get; set; }

        //ctor
        public WorldEncounters(string name, string description, string baseOption, string secondOptionGetter, string secondOptionText)
        {
            Name = name;
            Description = description;
            BaseOption = baseOption;
            SecondOptionGetter = secondOptionGetter;
            SecondOptionText = secondOptionText;
        }
        //methods

    }
}
