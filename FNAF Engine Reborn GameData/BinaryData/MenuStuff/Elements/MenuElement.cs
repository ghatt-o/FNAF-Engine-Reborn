using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff.Elements
{
    public class MenuElement
    {
        public string ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public byte type;

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                type = reader.ReadByte();
                ID = reader.ReadString();
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
            }
        }
        public void Write(BinaryWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.Write(type);
                Writer.Write(ID);
                Writer.Write((byte)X);
                Writer.Write((byte)Y);
            }
        }
    }
}
