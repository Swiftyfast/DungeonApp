using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //field
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //properties - props w/ business rules should be listed last in list of properties.
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        //Business rules for MinDamage - cannot be more than maxDamage and cannot be less than 1.
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
                    //Tried to set the value outside of our range
                    _minDamage = 1;
                } //end else
            }// end set
        }//end MinDamage

        //ctors
        public Weapon() { }

        //FQ CTOR
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            //Assign proptery values to param values - if you have any properties that have biz rules based on other properties, set the other props first and then set you prop with the biz rule.
            MaxDamage = maxDamage;
            MinDamage = minDamage;//Set minDamage here after maxDamage because minDamage relies on the value for maxDamage when being set.
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }//end of FQ CTOR

        //methods
        //ToString() override
        public override string ToString()
        {
            //return base.ToString(); - Namespace.Classname
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}", Name, MinDamage, MaxDamage, BonusHitChance, IsTwoHanded ? "Two-Handed" : "One-Handed");
        }
}
