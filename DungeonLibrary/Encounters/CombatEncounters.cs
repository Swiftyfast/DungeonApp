using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Encounters
{
    public class CombatEncounters : Encounter
    {

        //fields

        //props

        //ctor
        public CombatEncounters(string name, string description, string baseOption, string secondOptionGetter, string secondOptionText)
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
