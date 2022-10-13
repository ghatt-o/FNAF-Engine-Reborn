using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu
    {
        public byte key;

        public string Name { get; set; }
        public Binaries.Image BackgroundImage { get; set; }
        public Binaries.Audio BackgroundAudio { get; set; }
        public StaticEffect StaticEffect { get; set; }

        public FNAF_Engine_Menu_Code OnMenuStart_Code { get; set; }
        public FNAF_Engine_Menu_Code OnGameLoop_Code { get; set; }

        public List<MenuElement> Elements { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
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
                for(int i = 0; i< ec; i++)
                {
                    MenuElement ele = new MenuElement();
                    ele.Read(reader, true, null);
                    Elements.Add(ele);
                }
            }
        }
            public async void Write(BinaryWriter Writer, bool binary, string project)
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
        }
    }
}