using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary.Classes;

namespace DungeonLibrary.Classes
{
    public class Ship
    {
        //fields
        private int _hull;

        //props

        public string Name { get; set; }
        public int Engines { get; set; }
        public int MaxHull { get; set; }
        
        public int Weapons { get; set; }
        
        //public bool MyProperty { get; set; }
        public int Hull
        {
            get { return _hull; }
            set { _hull = value <= MaxHull ? value : MaxHull; }
        }
        //ctor
        public Ship(string name, int engines, int maxHull, int hull, int weapons)
        {
            MaxHull = maxHull;
            Name = name;
            Engines = engines;
            Hull = hull;
            Weapons = weapons;

        }

        public Ship() { }
        
    }
}
