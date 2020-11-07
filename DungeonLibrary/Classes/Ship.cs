﻿using System;
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
        //Ships can have beneficial properties such as extra speed (luck), hull (hp), weapons(attack), has science, has rec, has *Third Room*

        public string Name { get; set; }
        public Captain MyCaptain { get; set; }
        public int Engines { get; set; }
        public int MaxHull { get; set; }
        
        public int WeaponsInt { get; set; }
        public string WeaponsWords { get; set; }
        public bool ScienceLab { get; set; }
        public bool RecRoom { get; set; }
        //public bool MyProperty { get; set; }
        public int Hull
        {
            get { return _hull; }
            set { _hull = value <= MaxHull ? value : MaxHull; }
        }
        //ctor
        public Ship(string name, Captain myCaptain, int engines, int hull, int weaponsInt, string weaponsWords, bool scienceLab, bool recRoom)
        {
            Name = name;
            MyCaptain = myCaptain;
            Engines = engines;
            Hull = hull;
            WeaponsInt = weaponsInt;
            WeaponsWords = weaponsWords;
            ScienceLab = scienceLab;
            RecRoom = recRoom;

        }

        //methods

        public override string ToString()
        {
            return Name;
        }
    }
}
