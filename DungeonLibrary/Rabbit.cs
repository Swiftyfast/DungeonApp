using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rabbit : Monster
    {
        //We have created a child monster with at least one unique property

        //fields N/A

        //props
        public bool IsFluffy { get; set; }

        //ctors - create a FQ ctor that we can use to make a superbad monster, then create a default ctor.
        public Rabbit(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isFluffy) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsFluffy = isFluffy;
            //Just handle the unique props that don't come from the base class when you have set up a FQ CTOR in the base class.
        }

        public Rabbit()
        {
            //SET DEFAULT RABBIT VALUES
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Rabbit";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "It's just a cute bunny...Why would you want to fight it?";
            IsFluffy = false;
        }

        //methods()
        //override the block to say if they are fluffy they get a 50% bonus to their block value
        public override int CalcBlock()
        {
            //typically when dealing with a method that has a return type, you create a variable of the type you need to return. Then write the return line and then write the code in between the declaration of the variable and the return.
            int calculatedBlock = Block;

            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
