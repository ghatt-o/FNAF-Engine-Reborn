using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class AnimPathNode
    {
        public int Type = -1;
        //Blank = -1
        //Camera = 0
        //Door = 1
        //Flashlight = 3
        //Light = 4
        //Music Box (Start of path if puppet-style animatronic) = 5 
        //Alternate path = 6
        //Office state = 7 (?)
        //Office (end of path) = 8
    }
}
