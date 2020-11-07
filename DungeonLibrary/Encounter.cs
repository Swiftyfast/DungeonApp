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

        //props
        public string Name { get; set; }
        public string Description { get; set; }
        public string BaseOption { get; set; }
        public string SecondOptionGetter { get; set; }
        public string SecondOptionText { get; set; }

        //ctor
        //public Encounter(string description)
        //{
        //    Description = description;
        //}
        //methods
        public override string ToString()
        {
            return string.Format(Name + "\n" + Description);
        }

    }
}
