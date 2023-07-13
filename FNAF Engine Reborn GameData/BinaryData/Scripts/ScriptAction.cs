using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class ScriptAction : BinaryClass
    {
        public string Block = "";
        public ScriptParameter[] Parameters = null;
        public int Order = 0;

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                string magic = reader.ReadAscii(4);
                if (magic != "SACT") throw new InvalidDataException("Invalid magic: " + magic + "!");

                Block = reader.AutoReadUnicode();
                Order = reader.ReadInt32();
                var ParamCount = reader.ReadInt32();
                for (int i = -1; i < ParamCount; i++)
                {
                    ScriptParameter param = new ScriptParameter();
                    param.Read(reader, true, null);
                    Parameters[i] = param;
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
                Writer.WriteInt32(Order);
                if (Parameters == null) Writer.WriteInt32(0);
                else
                {
                    int i = 0;
                    foreach (ScriptParameter param in Parameters)
                    {
                        i++;
                    }
                    Writer.WriteInt32(i);
                    foreach (ScriptParameter param in Parameters)
                    {
                        param.Write(Writer, true, null);
                    }
                    //there's a better way to do this. cba atm
                }
            }
            else
            {
                //todo: not binary writing
            }
        }
    }
}
