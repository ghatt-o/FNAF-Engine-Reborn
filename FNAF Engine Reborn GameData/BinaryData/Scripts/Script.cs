using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class Script : BinaryClass
    {
        public ScriptCondition[] Conditions;
        public ScriptAction[] Actions;

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteAscii("SRPC");


            }
            else
            {

            }
        }

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                string magic = reader.ReadAscii(4);
                if (magic != "SRPC") throw new InvalidDataException("Invalid magic: " + magic);


            }
            else
            {

            }
        }
    }
}
