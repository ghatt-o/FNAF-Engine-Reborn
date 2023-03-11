using FNAF_Engine_Reborn_GameData.BinaryData;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff.Elements
{
    public class MenuElement : BinaryClass
    {
        public byte type { get; set; } = 0;
        public string ID { get; set; } = "";
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public bool Hidden { get; set; } = false;
        public bool args { get; set; } = false;

        public void Read(ByteReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                type = reader.ReadByte();
                ID = reader.ReadAscii(reader.ReadInt32());
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
                Hidden = reader.ReadBool();
                args = reader.ReadBool();
            }
            else
            {
                //todo
            }
        }
        public void Write(ByteWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.WriteInt8(type);
                Writer.WriteInt32(ID.Length);
                Writer.WriteAscii(ID);
                Writer.WriteInt32(X);
                Writer.WriteInt32(Y);
                Writer.WriteBool(Hidden);
                Writer.WriteBool(args);
            }
            else
            {
                //todo
            }
        }
    }
}
