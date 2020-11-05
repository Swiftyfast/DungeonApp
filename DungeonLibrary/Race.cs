using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //We cannot add an Enum through Visual Studio's interface. If we want to make an Enum, change the word class below to enum and make it public
    public enum Race
    {
        //single values = No spaces in the value and the values are comma-seperated.
        Orc,
        Human,
        Elf,
        Halfling,
        Dwarf,
        Selkie,
        Kitsune,
        Canadian,
        Jackalope
    }//end enum
}
