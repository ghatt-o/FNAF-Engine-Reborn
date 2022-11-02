using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.IO;
using System.Linq;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class ScriptCondition : BinaryClass
    {
        public string Block = "";
        public ScriptParameter[] Parameters;

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteAscii("SCND");

                Writer.AutoWriteUnicode(Block);
                Writer.WriteUInt8((sbyte)Parameters.Count());

                foreach (ScriptParameter param in Parameters)
                {
                    param.Write(Writer, true, null);
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
                string magic = reader.ReadAscii(4);
                if (magic != "SCND") throw new InvalidDataException("Unknown magic: " + magic + "!");

                Block = reader.AutoReadUnicode();
                var ParamCount = reader.ReadSByte();
                for (int i = 0; i < ParamCount; i++)
                {
                    ScriptParameter param = new ScriptParameter();
                    param.Read(reader, true, null);
                    Parameters.Append(param);
                }
            }
            else
            {
                //todo
            }
        }
    }
}
