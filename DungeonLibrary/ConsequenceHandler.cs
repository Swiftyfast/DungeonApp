using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class ConsequenceHandler
    {
        //fields

        //props
        public string Type { get; set; }
        public string SecondDescription { get; set; }

        //ctor
        public ConsequenceHandler(string type, string secondDescription)
        {
            Type = type;
            SecondDescription = secondDescription;
        }

        //methods
    }
}
