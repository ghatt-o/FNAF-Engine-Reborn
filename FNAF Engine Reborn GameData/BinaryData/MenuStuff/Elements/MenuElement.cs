using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff.Elements
{
    public class MenuElement
    {
        public byte type { get; set; } = 0;
        public string ID { get; set; } = "";
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public bool Hidden { get; set; } = false;
        public bool args { get; set; } = false;

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                type = reader.ReadByte();
                ID = reader.ReadString();
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
                Hidden = reader.ReadBoolean();
                args = reader.ReadBoolean();
            }
            else
            {
                //todo
            }
        }
        public void Write(BinaryWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.Write(type);
                Writer.Write(ID);
                Writer.Write(X);
                Writer.Write(Y);
                Writer.Write(Hidden);
                Writer.Write(args);
            }
            else
            {
                //todo
            }
        }
    }
}
