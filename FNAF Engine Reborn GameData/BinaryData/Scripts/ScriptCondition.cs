using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class ScriptCondition
    {
        public short Identifier = 9; //so it doesnt break

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteAscii("CND");
                Writer.Write(Identifier);
            }
            else
            {
                //todo
            }
        }
    }
}
