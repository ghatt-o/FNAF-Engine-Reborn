using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuStuff.Elements
{
    public class TextElement : MenuElement
    {
        public string text { get; set; }
        public string fontname { get; set; }
        public string fontsize { get; set; }
        public Color rgb { get; set; }

        public string[] funcs { get; set; }
        public string[] funcshover { get; set; }
        public string[] funcsunhover { get; set; }
        public string[] funcshold { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
        {
            text = reader.ReadString();
            fontname = reader.ReadString();
            fontsize = reader.ReadString();
            #region
            int r = reader.ReadByte();
            int g = reader.ReadByte();
            int b = reader.ReadByte();
            #endregion
            rgb = Color.FromArgb(r, g, b);

            int funcslen = reader.ReadInt32();
            int funcshoverlen = reader.ReadInt32();
            int funcsunhoverlen = reader.ReadInt32();
            int funcsholdlen = reader.ReadInt32();

            for (int i = 0; i < funcslen; i++)
            {
                string[] strings = { };
                funcs = strings;
                funcs.Append(reader.ReadString());
            }

            for (int i = 0; i < funcshoverlen; i++)
            {
                string[] strings = { };
                funcshover = strings;
                funcshover.Append(reader.ReadString());
            }

            for (int i = 0; i < funcsunhoverlen; i++)
            {
                string[] strings = { };
                funcsunhover = strings;
                funcsunhover.Append(reader.ReadString());
            }

            for (int i = 0; i < funcsholdlen; i++)
            {
                string[] strings = { };
                funcshold = strings;
                funcshold.Append(reader.ReadString());
            }
        }
    }
}
