using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using FNAF_Engine_Reborn_GameData.BinaryData;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects;
using MenuStuff.Elements;
using System;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu : BinaryClass
    {
        public byte key = 96;

        public string Name { get; set; } = "";
        public Binaries.Image BackgroundImage { get; set; } = new Binaries.Image();
        public Binaries.Audio BackgroundAudio { get; set; } = new Binaries.Audio();
        public StaticEffect StaticEffect { get; set; } = new StaticEffect();

        public FNAF_Engine_Menu_Code OnMenuStart_Code { get; set; } = new FNAF_Engine_Menu_Code();
        public FNAF_Engine_Menu_Code OnGameLoop_Code { get; set; } = new FNAF_Engine_Menu_Code();

        public List<TextElement> TextElements { get; set; } = new List<TextElement>();
        public List<ImageElement> ImageElements { get; set; } = new List<ImageElement>();

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

                Writer.WriteInt32(TextElements.Count);
                Writer.WriteInt32(ImageElements.Count);
                foreach(var e in TextElements)
                {
                    e.Write(Writer, true, null);
                }
                foreach(var e in ImageElements)
                {
                    e.Write(Writer, true, null);
                }
            }
            else
            {
                Directory.CreateDirectory(project + "/menus/" + Name);
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

                var textelementcount = reader.ReadInt32();
                var imageelementcount = reader.ReadInt32();
                for (int i = 0; i < textelementcount; i++)
                {
                    var textelement = new TextElement();
                    textelement.Read(reader, true, null);
                    TextElements.Add(textelement);
                }
                for (int i = 0; i < imageelementcount; i++)
                {
                    var element = new ImageElement();
                    element.Read(reader, true, null);
                    ImageElements.Add(element);
                }
            }
            else
            {
                //Name is already pre-set on reading.
                string path = project + "/menus/" + Name;
                key = 96; //why did i make this?
                
                BackgroundImage = new Binaries.Image();
                string bgName = File.ReadAllText(path + "/bg.txt");
                if (bgName == "") Console.WriteLine("No background image for menu");
                else BackgroundImage.Name = bgName;
                if (bgName != "")
                    BackgroundImage.Read(null, false, project);
                BackgroundAudio = new Binaries.Audio();
                string bgaudio = File.ReadAllText(path + "/audio.txt");
                if (bgaudio == "") Console.WriteLine("No background audio for menu");
                else BackgroundAudio.Name = bgaudio;
                if (bgaudio != "")
                    BackgroundAudio.Read(null, false, project);

                string sename = File.ReadAllText(path + "/static.txt");
                if (sename == "") Console.WriteLine("No static effect for menu");
                else StaticEffect = new StaticEffect();
                if (sename != "") StaticEffect.Read(null, false, project); //Method not done yet

                //Menu code also not done

                //TODO: Element reading
            }
        }
    }
}