using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Classes
{
    public class EnemyShip : Ship
    {
        //fields

        //props
        public string Description { get; set; }
        public string Weakness { get; set; }
        public string WeaknessText { get; set; }

        //ctors
        public EnemyShip(string name, string description, int engines, int maxHull, int hull, int weapons, string weakness, string weaknessText) : base(name, engines, maxHull, hull, weapons)
        {
            Description = description;
            Weakness = weakness;
            WeaknessText = weaknessText;
        }

        //methods
        public override string ToString()
        {
            string returnString = string.Format("Vessel Type: " + Name + "\n" +
                "Description: " + Description + "\n" +
                "Hull: " + Hull + "\n");

            return returnString;
        }

    }
}
