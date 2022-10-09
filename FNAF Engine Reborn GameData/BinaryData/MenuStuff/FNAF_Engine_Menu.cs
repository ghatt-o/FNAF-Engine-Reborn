using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu
    {
        public byte key;

        public string Name { get; set; }
        public Binaries.Image BackgroundImage { get; set; }
        public Binaries.Audio BackgroundAudio { get; set; }
        public List<Binaries.Image> StaticEffect { get; set; }

        public FNAF_Engine_Menu_Code OnMenuStart_Code { get; set; }
        public FNAF_Engine_Menu_Code OnGameLoop_Code { get; set; }

        public List<MenuElement> Elements { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                Name = reader.ReadString();
                key = reader.ReadByte(); //rekt decompilers

                if (key == 51) //always update lmao i'm destroying them
                {

                }
            }
        }
        public async void Write(BinaryWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.Write(Name);
                Writer.Write(key);

                if (key != 51)
                {
                    //goodbye decompilers
                    Writer.Write(1);
                    Writer.Write(new byte[1]);

                    Writer.Write(1);
                    Writer.Write(new byte[1]);

                    Writer.Write((ulong)0);
                    Writer.Write("HI YOU FELLOW DECOMPILER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

                    Writer.Write((ulong)0);
                    Writer.Write("Gonna break your shit right here.");

                    void KillDecompiler()
                    {
                        Writer.Write(0);
                    }

                    while(true)
                    {
                        await Task.Delay(1);
                        KillDecompiler();
                    }
                }

                BackgroundImage.Write(Writer);
                BackgroundAudio.Write(Writer);

                Writer.Write((ulong)StaticEffect.Count);
                foreach (Binaries.Image image in StaticEffect)
                {
                    image.Write(Writer);
                }

                OnMenuStart_Code.Write(Writer, true, null);
                OnGameLoop_Code.Write(Writer, true, null);

                Writer.Write((ulong)Elements.Count);
                foreach (var element in Elements)
                {
                    element.Write(Writer, true, null);
                }
            }
        }
    }
}