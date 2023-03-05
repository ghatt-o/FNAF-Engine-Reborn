using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class ScriptAction : BinaryClass
    {
        public string Block = "";
        public List<ScriptParameter> Parameters = new();

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                string magic = reader.ReadAscii(4);
                if (magic != "SACT") throw new InvalidDataException("Invalid magic: " + magic + "!");

                Block = reader.AutoReadUnicode();
                var paramCount = reader.ReadSByte();
                for (int i = 0; i < paramCount; i++)
                {
                    ScriptParameter parameter = new ScriptParameter();
                    parameter.Read(reader, true, null);
                    Parameters.Add(parameter);
                }
            }
            else
            {
                //todo: reading from non binary project
            }
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteAscii("SACT");

                Writer.AutoWriteUnicode(Block);
                Writer.WriteUInt8((sbyte)Parameters.Count);
                foreach (ScriptParameter parameter in Parameters)
                {
                    parameter.Write(Writer, true, null);
                }
            }
            else
            {
                //todo: not binary writing
            }
        }
    }
}
