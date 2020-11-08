using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Encounter
    {
        //fields
        private int _hull;

        //props
        public string Name { get; set; }
        public string Description { get; set; }
        public string SecondOptionGetter { get; set; }
        public string SecondOptionText { get; set; }
        public int MaxHull { get; set; }
        public int Engines { get; set; }
        public int Weapons { get; set; }
        public int Hull
        {
            get { return _hull; }
            set { _hull = value <= MaxHull ? value : MaxHull; }
        }


        //ctor
        public Encounter (string name, string description, string secondOptionGetter, string secondOptionText, int maxHull, int hull, int engines, int weapons)
        {
            Name = name;
            Description = description;
            SecondOptionGetter = secondOptionGetter;
            SecondOptionText = secondOptionText;
            MaxHull = maxHull;
            Hull = hull;
            Engines = engines;
            Weapons = weapons;
        }
        //methods
        public override string ToString()
        {
            return string.Format(Name + "\n" + Description);
        }

    }
}
