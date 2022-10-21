using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects;
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

        public List<MenuElement> Elements { get; set; } = new List<MenuElement>();

        public void Write(BinaryWriter Writer, bool binary, string menupath, string project)
        {
            if (binary == true)
            {
                Writer.Write(Name);
                Writer.Write(key);

                BackgroundImage.Write(Writer);
                BackgroundAudio.Write(Writer);

                StaticEffect.Write(Writer, true, null);

                //OnMenuStart_Code.Write(Writer, true, null);
                //OnGameLoop_Code.Write(Writer, true, null);
                //for now 0
                Writer.Write(0);
                Writer.Write(0);

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
        public void Read(BinaryReader reader, bool binary, string menupath, string project)
        {
            if (binary == true)
            {
                Name = reader.ReadString();
                key = reader.ReadByte();

                BackgroundImage.Read(reader, true, null, null);
                BackgroundAudio.Read(reader, true, null, null);

                StaticEffect.Read(reader, true, null);

                reader.ReadInt32();
                reader.ReadInt32();

                var ec = reader.ReadInt32();
                for (int i = 0; i < ec; i++)
                {
                    MenuElement ele = new MenuElement();
                    ele.Read(reader, true, null);
                    Elements.Add(ele);
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