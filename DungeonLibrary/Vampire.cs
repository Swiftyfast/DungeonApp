using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Vampire : Monster
    {
        //fields - N/A

        //props
        public DateTime HourChangeBack { get; set; }

        //ctor
        public Vampire(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base (name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            HourChangeBack = DateTime.Now;

            //if you play this at night, the Vampire class will be over-powered.
            if (HourChangeBack.Hour < 6 || HourChangeBack.Hour >= 18)
            {
                HitChance += 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }
        }//end FQ cTor

        //methods()
        public override string ToString()
        {
            return string.Format("{0}\n{1}", base.ToString(), HourChangeBack.Hour < 6 || HourChangeBack.Hour >= 18 ? "It looks a little string and angry..." : "In the daylight, it's looking a little weak.");
        }
    }
}
