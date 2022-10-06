using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff.Elements
{
    public class MenuElement
    {
        public string? ID { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public byte key;

        public void Read(BinaryReader reader, bool binary, string? project)
        {
            if (binary == true)
            {
                key = reader.ReadByte(); //51
                ID = reader.ReadString();
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
            }
        }
        public void Write(BinaryWriter Writer, bool binary, string? project)
        {
            if (binary == true)
            {
                Writer.Write(key);
            }
        }
    }
}
