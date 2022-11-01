using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects;
using MenuStuff.Elements;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu
    {
        public byte key;

        public string Name { get; set; } = "";
        public Binaries.Image BackgroundImage { get; set; } = new Binaries.Image();
        public Binaries.Audio BackgroundAudio { get; set; } = new Binaries.Audio();
        public StaticEffect StaticEffect { get; set; } = new StaticEffect();

        public FNAF_Engine_Menu_Code OnMenuStart_Code { get; set; } = new FNAF_Engine_Menu_Code();
        public FNAF_Engine_Menu_Code OnGameLoop_Code { get; set; } = new FNAF_Engine_Menu_Code();

        public List<TextElement> Elements { get; set; } = new List<TextElement>();

        public void Write(ByteWriter Writer, bool binary, string menupath, string project)
        {
            if (binary == true)
            {
                Writer.AutoWriteUnicode(Name);
                Writer.WriteInt8(key);

                BackgroundImage.Write(Writer, true, null, null);
                BackgroundAudio.Write(Writer, true, null, null);

                StaticEffect.Write(Writer, true, null);

                OnMenuStart_Code.Write(Writer, true, null);
                OnGameLoop_Code.Write(Writer, true, null);

                Writer.Write(Elements.Count);
                foreach (var element in Elements)
                {
                    element.Write(Writer, true, null);
                }
            }
            else
            {
                //Start working on menu writing
                File.WriteAllText(menupath + "/name.txt", Name);
                if (BackgroundImage != null)
                {
                    File.WriteAllText(menupath + "/bg.txt", BackgroundImage.Name);
                }
                if (BackgroundAudio != null)
                {
                    File.WriteAllText(menupath + "/audio.txt", project + "/sounds/" + BackgroundAudio.Name);
                }
            }
        }
        public void Read(ByteReader reader, bool binary, string menupath, string project)
        {
            if (binary == true)
            {
                Name = reader.AutoReadUnicode();
                key = reader.ReadByte();

                BackgroundImage.Read(reader, true, null, null);
                BackgroundAudio.Read(reader, true, null, null);

                StaticEffect.Read(reader, true, null);

                OnMenuStart_Code.Read(reader, false, null);
                OnGameLoop_Code.Read(reader, false, null);

                var ec = reader.ReadInt32();
                for (int i = 0; i < ec; i++)
                {
                    MenuElement ele = new MenuElement();
                    ele.Read(reader, true, null);
                    //Elements.Add(ele);
                }
            }
            else
            {
                //Start working on menu reading
                Name = File.ReadAllText(menupath + "/name.txt");

                //TODO: Background Image and Audio
            }
        }
    }
}