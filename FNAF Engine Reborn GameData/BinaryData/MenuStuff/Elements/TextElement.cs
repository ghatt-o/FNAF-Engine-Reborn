using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using FNAF_Engine_Reborn_GameData.BinaryData.Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace MenuStuff.Elements
{
    public class TextElement : MenuElement
    {
        public string Text { get; set; } = "Unknown-TextElement";
        public string Fontname { get; set; } = "Consolas";
        public string Fontsize { get; set; } = "9";
        public Color Rgb { get; set; }
        public byte ButtonStyle { get; set; } = 0; //fnaf

        public List<Script> ClickFunctions { get; set; } = new();

        public new void Read(ByteReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                base.Read(reader, true, null);
                Text = reader.AutoReadUnicode();
                Fontname = reader.AutoReadUnicode();
                Fontsize = reader.AutoReadUnicode();
                #region Reading RGB Values
                int r = reader.ReadByte();
                int g = reader.ReadByte();
                int b = reader.ReadByte();
                #endregion
                Rgb = Color.FromArgb(r, g, b);
                ButtonStyle = reader.ReadByte();

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
            else
            {
                //Project is the textelement path
                ID = File.ReadAllText(project + "/id.txt");
                Text = File.ReadAllText(project + "/text.txt");
                Fontname = File.ReadAllText(project + "/font.txt");
                Fontsize = File.ReadAllText(project + "/fontsize.txt");
                string args = File.ReadAllText(project + "/args.txt");
                if (args == "False") this.args = false;
                else this.args = true;
                X = Convert.ToInt32(File.ReadAllText(project + "/x.txt"));
                Y = Convert.ToInt32(File.ReadAllText(project + "/y.txt"));
                //TODO: Element code
                ButtonStyle = Convert.ToByte(File.ReadAllText(project + "/style.txt"));
                if (ButtonStyle != 1) this.Rgb = Color.FromArgb(Convert.ToInt32(File.ReadAllText(project + "/color.txt").Split(',')[0], Convert.ToInt32(File.ReadAllText(project + "/color.txt").Split(',')[1], Convert.ToInt32(File.ReadAllText(project + "/color.txt").Split(',')[2]))));
                else this.Rgb = Color.FromArgb(0, 0, 0);
            }
        }
        public new void Write(ByteWriter Writer, bool binary, string menupath)
        {
            if (binary == true)
            {
                base.Write(Writer, true, null);
                Writer.AutoWriteUnicode(Text);
                Writer.AutoWriteUnicode(Fontname);
                Writer.AutoWriteUnicode(Fontsize);
                #region Writing Colors
                if (ButtonStyle != 1) //FNAF Styled Button
                {
                    Writer.Write(Rgb.R);
                    Writer.Write(Rgb.G);
                    Writer.Write(Rgb.B);
                }
                else //It's a system button
                {
                    //Text must be black
                    Writer.Write(0);
                    Writer.Write(0);
                    Writer.Write(0);
                }
                #endregion
                Writer.Write(ButtonStyle);
            }
            else
            {
                _ = Directory.CreateDirectory(menupath + "/text_elements/" + ID);
                string NewPath = menupath + "/text_elements/" + ID;
                File.WriteAllText(NewPath + "/id.txt", $"{ID}");
                File.WriteAllText(NewPath + "/text.txt", $"{Text}");
                File.WriteAllText(NewPath + "/font.txt", $"{Fontname}");
                File.WriteAllText(NewPath + "/fontsize.txt", $"{Fontsize}");
                File.WriteAllText(NewPath + "/args.txt", $"{args}");
                File.WriteAllText(NewPath + "/x.txt", $"{X}");
                File.WriteAllText(NewPath + "/y.txt", $"{Y}");
                File.WriteAllText(NewPath + "/functions.txt", "");
                File.WriteAllText(NewPath + "/functionshover.txt", "");
                File.WriteAllText(NewPath + "/functionsunhover.txt", "");
                File.WriteAllText(NewPath + "/functionshold.txt", "");
                if (ButtonStyle != 1) File.WriteAllText(NewPath + "/color.txt", $"{Rgb.R},{Rgb.G},{Rgb.B}");
                else File.WriteAllText(NewPath + "/color.txt", $"0,0,0");
                File.WriteAllText(NewPath + "/style.txt", $"{ButtonStyle}");
            }
        }
    }
}
