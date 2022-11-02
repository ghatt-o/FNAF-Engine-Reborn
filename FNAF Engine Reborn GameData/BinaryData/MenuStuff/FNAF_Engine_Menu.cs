using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using FNAF_Engine_Reborn_GameData.BinaryData;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects;
using MenuStuff.Elements;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu : BinaryClass
    {
        public byte key;

        public string Name { get; set; } = "";
        public Binaries.Image BackgroundImage { get; set; } = new Binaries.Image();
        public Binaries.Audio BackgroundAudio { get; set; } = new Binaries.Audio();
        public StaticEffect StaticEffect { get; set; } = new StaticEffect();

        public FNAF_Engine_Menu_Code OnMenuStart_Code { get; set; } = new FNAF_Engine_Menu_Code();
        public FNAF_Engine_Menu_Code OnGameLoop_Code { get; set; } = new FNAF_Engine_Menu_Code();

        public List<TextElement> Elements { get; set; } = new List<TextElement>();

        public void Write(ByteWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.AutoWriteUnicode(Name);
                Writer.WriteInt8(key);

                BackgroundImage.Write(Writer, true, null);
                BackgroundAudio.Write(Writer, true, null);

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
                File.WriteAllText(project + "/menus/" + Name + "/name.txt", Name);
                if (BackgroundImage != null)
                {
                    File.WriteAllText(project + "/menus/" + Name + "/bg.txt", BackgroundImage.Name);
                }
                if (BackgroundAudio != null)
                {
                    File.WriteAllText(project + "/menus/" + Name + "/audio.txt", project + "/sounds/" + BackgroundAudio.Name);
                }
            }
        }
        public void Read(ByteReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                Name = reader.AutoReadUnicode();
                key = reader.ReadByte();

                BackgroundImage.Read(reader, true, null);
                BackgroundAudio.Read(reader, true, null);

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
                //Name is already pre-set on reading;

                //TODO: Background Image and Audio
            }
        }
    }
}