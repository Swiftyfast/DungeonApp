using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {

        //fields

        //props
        public bool IsScaly { get; set; }

        //ctor
        public Dragon(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaly) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsScaly = isScaly;
        }//end FQ ctor

        public Dragon()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Dragon";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "A freshly-hatched baby dragon. It still looks dangerous though...";
            IsScaly = false;
        }//end default ctor

        //methods

        public override string ToString()
        {
            return base.ToString() + (IsScaly ? "It has thick scales" : "Not so well armored.");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsScaly)
            {
                calculatedBlock += calculatedBlock / 4;
            }

            return calculatedBlock;
        }
    }
}
