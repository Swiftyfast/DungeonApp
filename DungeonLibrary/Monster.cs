using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //fields - we are going to have a biz rule on minDamage -cannot be more than max damage and cannot be less then zero.
        private int _minDamage;

        //props
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end minDamage

        //ctors
        public Monster() { }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            //Set maxlife and maxdamage first bc other properties rely on them
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;
        }

        //methods - ToString() and CalcDamage()
        public override string ToString()
        {
            return string.Format("\n-=-=- MONSTER -=-=-\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} of {4}\nBlock: {5}\nDescription:\n{6}",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }//End ToString()

        //We are overriding the CalcDamage to use properties MinDamage and MaxDamage
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
            //We added 1 above because upper bound for .Next() is exclusive. To include all of the maxDamage, we add 1.
        }//end calc damage

    }//end class
}//end Namespace
