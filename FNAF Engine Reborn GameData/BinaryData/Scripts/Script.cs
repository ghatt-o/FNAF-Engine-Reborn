using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class Script : BinaryClass
    {
        public string Name { get; set; } = "Script";
        public ScriptCondition[] Conditions { get; set; }
        public ScriptAction[] Actions { get; set; }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteAscii("FERS");

                Writer.WriteInt32(Conditions.Count());
                Writer.WriteInt32(Actions.Count());

                Writer.WriteInt8(0x80); //-128
                foreach(var C in Conditions)
                {
                    C.Write(Writer, true, null);
                }
                foreach (var A in Actions)
                {
                    A.Write(Writer, true, null);
                }
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
                if (magic != "FERS") throw new InvalidDataException("Invalid magic: " + magic);

                int ConditionCount = reader.ReadInt32();
                int ActionCount = reader.ReadInt32();

                Debug.Assert(reader.ReadByte() == -128);
                for (int i = 0; i < ConditionCount; i++)
                {
                    var Condition = new ScriptCondition();
                    Condition.Read(reader, true, null);
                    Conditions.Append(Condition);
                }
                for (int i = 0; i < ActionCount; i++)
                {
                    var Action = new ScriptAction();
                    Action.Read(reader, true, null);
                    Actions.Append(Action);
                }
            }
            else
            {

            }
        }
    }
}
