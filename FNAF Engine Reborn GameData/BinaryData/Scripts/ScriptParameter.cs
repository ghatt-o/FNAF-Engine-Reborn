using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class ScriptParameter : BinaryClass
    {
        public string Name = "";
        public int Type = 0;
        public object Value;

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.AutoWriteUnicode(Name);
                Writer.WriteInt32(Type);
                switch (Type)
                {
                    case -1: //string
                        Writer.WriteInt32(Value.ToString().Length);
                        Writer.WriteAscii(Value.ToString());
                        break;
                    case 0: //integer
                        Writer.WriteInt64(Convert.ToInt64(Value));
                        break;
                    default:
                        //TODO: Parameters like animatronic, menu, sound etc.
                        break;
                }
            }
            else
            {
                //todo
            }
        }

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Name = reader.AutoReadUnicode();
                Type = reader.ReadInt32();
                switch (Type)
                {
                    case -1: //string
                        var len = reader.ReadInt32();
                        Value = reader.ReadAscii(len);
                        break;
                    case 0: //integer
                        Value = reader.ReadInt64();
                        break;
                    default:
                        //TODO: Parameters like animatronic, menu, sound etc.
                        break;
                }
            }
            else
            {
                //todo
            }
        }
    }
}
