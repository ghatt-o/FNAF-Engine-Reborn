using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff.Elements
{
    public class MenuElement
    {
        public byte type { get; set; }
        public string ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool args { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                type = reader.ReadByte();
                ID = reader.ReadString();
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
                args = reader.ReadBoolean();
            }
            else
            {
                //uhhh what do i do here????todo????
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
                Writer.Write(args);
            }
            else
            {
                //todo i guess
            }
        }
    }
}
