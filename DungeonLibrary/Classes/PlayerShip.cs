using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Classes
{
    public class PlayerShip : Ship
    {
        //fields

        //props
        public Captain MyCaptain { get; set; }
        public bool ScienceLab { get; set; }
        public bool RecRoom { get; set; }
        //ctors
        public PlayerShip(string name, Captain myCaptain, int engines, int maxHull, int hull, int weapons, bool scienceLab, bool recRoom) : base (name, engines, maxHull, hull, weapons)
        {
            MaxHull = Hull;
            MyCaptain = myCaptain;
            Name = name;
            Engines = engines;
        }

        //methods

        public override string ToString()
        {
            //NEED TO ADD SCIENCE LAB AND REC ROOM
            return string.Format("Vessel Name: " + Name + "\n" +
                MyCaptain + "\n" +
                "Hull: " + Hull + "\n" +
                "Engines: " + Engines + "\n" +
                "Weapons: " + Weapons);
        }

    }
}
