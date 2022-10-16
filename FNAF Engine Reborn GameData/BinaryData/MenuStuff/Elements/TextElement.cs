using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using System.Drawing;
using System.IO;

namespace MenuStuff.Elements
{
    public class TextElement : MenuElement
    {
        public string Text { get; set; }
        public string Fontname { get; set; }
        public string Fontsize { get; set; }
        public Color Rgb { get; set; }

        /*
        public string[] Funcs { get; set; }
        public string[] Funcshover { get; set; }
        public string[] Funcsunhover { get; set; }
        public string[] Funcshold { get; set; }
        */ //fix everything commented

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                Text = reader.ReadString();
                Fontname = reader.ReadString();
                Fontsize = reader.ReadString();
                #region
                int r = reader.ReadByte();
                int g = reader.ReadByte();
                int b = reader.ReadByte();
                #endregion
                Rgb = Color.FromArgb(r, g, b);

                /*
                int funcslen = reader.ReadInt32();
                int funcshoverlen = reader.ReadInt32();
                int funcsunhoverlen = reader.ReadInt32();
                int funcsholdlen = reader.ReadInt32();
                */

                /*
                for (int i = 0; i < funcslen; i++)
                {
                    string[] strings = { };
                    Funcs = strings;
                    Funcs.Append(reader.ReadString());
                }

                for (int i = 0; i < funcshoverlen; i++)
                {
                    string[] strings = { };
                    Funcshover = strings;
                    Funcshover.Append(reader.ReadString());
                }

                for (int i = 0; i < funcsunhoverlen; i++)
                {
                    string[] strings = { };
                    Funcsunhover = strings;
                    Funcsunhover.Append(reader.ReadString());
                }

                for (int i = 0; i < funcsholdlen; i++)
                {
                    string[] strings = { };
                    Funcshold = strings;
                    Funcshold.Append(reader.ReadString());
                }
                */
            }
        }
    }
}
