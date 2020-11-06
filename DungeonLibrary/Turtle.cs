using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Turtle : Monster
    {
        //fields N/A

        //props
        public int BonusBlock { get; set; }
        public int HidePercent { get; set; }

        //ctors
        public Turtle(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, int bonusBlock, int hidePercent) : base (name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            BonusBlock = bonusBlock;
            HidePercent = hidePercent;
        }

        public Turtle ()
        {
            //Set default Turtle values
            MaxLife = 6;
            MaxDamage = 3;
            Life = 6;
            MinDamage = 0;
            HitChance = 10;
            Block = 10;
            Name = "Baby Turtle";
            Description = "It's a cute baby turtle...keep it away from the ooze.";
            BonusBlock = 5;
            HidePercent = 10;
        }//end of the default

        //methods
        public override string ToString()
        {
            return String.Format("{0}\nChance it'll hide: {1}% and then it has a bonus block of {2}", base.ToString(), HidePercent, BonusBlock);
        }//end of toString() method

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            //get a random number between 1 and 100
            Random rand = new Random();
            int percent = rand.Next(101);
            //To see if percent if less then or equal to hidepercent
            if (percent <= HidePercent)
            {
                calculatedBlock += BonusBlock;
            }
            return calculatedBlock;
        }//end CalcBlock()

    }
}
