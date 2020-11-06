using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //This class will serve as a base class that Monster and Player (derived classes) will inherit from in our overall program. Inheritance allows for maximum reuse of functionality in our code.

        //In this class, we name all of the shared fields between the player and monster.
        //ABstract below keeps us from being able to create a new object of this type in the program.
        //We are only using this class as a base and will never create an object of this specific type.
    public class Character
    {
        //fields
        private int _life; //We do not want life to be below 0 or more than maxlife

        //props
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }
            //set
            //{
            //    //biz rule - life should not be below 0 and should not exceed maxLife
            //    if (value >= 0 && value <= MaxLife)
            //    {
            //        //good to go
            //        _life = value;
            //    }
            //    else
            //    {
            //        _life = MaxLife;
            //    } //end else
            //}//end set
        }//end int Life


        //ctors
        //Since we don't inherit constructors, we will define the CTORS in the other classes. We will still get the default ctor but will be unable to use it since this class is abstract.

        //methods - Below are methods we want to be inherited by the Player and Monster classes. So, we are creating default versions of each method here, which the child classes will use if they do not override these default methods.

        public virtual int CalcBlock()
        {
            //VIRTUAL - allows us to override in derived classes
            //This basic version just returns Block, but this will give us the option to do something different in child classes.
            return Block;
        }//end CalcBlock();

        //MINILAB Make a method() called CalcHitChance() that simply returns HitChance. Make it overridable

        public virtual int CalcHitChance()
        {
            return HitChance;
        } //end CalcHitChance()

        //make CalcDamage() and return 0 for the base version

        public virtual int CalcDamage()
        {
            return 0;
            //starting with 0...we will override this in Player and Monster
        }

    }
}
