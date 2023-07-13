using FNAF_Engine_GameData.BinaryData.MenuStuff.Elements;
using FNAF_Engine_Reborn_GameData.BinaryData;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using FNAF_Engine_Reborn_GameData.BinaryData.Scripts;
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
        public Binaries.Image BackgroundImage { get; set; }
        public Binaries.Audio BackgroundAudio { get; set; }
        public StaticEffect StaticEffect { get; set; }

        public Script MenuScript { get; set; } = new Script();

        public List<TextElement> TextElements { get; set; } = new List<TextElement>();
        public List<ImageElement> ImageElements { get; set; } = new List<ImageElement>();

        public void Write(ByteWriter Writer, bool binary, string project)
        {
            if (binary)
            {
                Writer.AutoWriteUnicode(Name);
                Writer.WriteInt8(key);

                if (BackgroundAudio == null) Writer.WriteInt8(0);
                else Writer.WriteInt8(1);
                if (BackgroundImage == null) Writer.WriteInt8(0);
                else Writer.WriteInt8(1);
                if (StaticEffect == null) Writer.WriteInt8(0);
                else Writer.WriteInt8(1);

                if (BackgroundAudio != null) BackgroundAudio.Write(Writer, true, null);
                if (BackgroundImage != null) BackgroundImage.Write(Writer, true, null);

                if (StaticEffect != null) StaticEffect.Write(Writer, true, null);

                MenuScript.Write(Writer, true, null);

                Writer.WriteInt32(TextElements.Count);
                Writer.WriteInt32(ImageElements.Count);
                foreach (var e in TextElements)
                {
                    e.Write(Writer, true, null);
                }
                foreach (var e in ImageElements)
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
                else
                {
                    File.WriteAllText(project + "/menus/" + Name + "/bg.txt", "");
                }
                if (BackgroundAudio != null)
                {
                    File.WriteAllText(project + "/menus/" + Name + "/audio.txt", BackgroundAudio.Name);
                }
                else
                {
                    File.WriteAllText(project + "/menus/" + Name + "/audio.txt", "");
                }
                if (StaticEffect != null)
                {
                    StaticEffect.Temp = project + "/statics/" + StaticEffect.Name; //n
                    StaticEffect.Write(null, false, null);
                    File.WriteAllText(project + "/menus/" + Name + "/static.txt", StaticEffect.Name);
                }
                else
                {
                    File.WriteAllText(project + "/menus/" + Name + "/static.txt", "");
                }
                foreach (var ele in TextElements)
                {
                    ele.Write(null, false, project + "/menus/" + Name);
                }
            }
        }
        public void Read(ByteReader reader, bool binary, string project)
        {
            if (binary)
            {
                Name = reader.AutoReadUnicode();
                key = reader.ReadByte();

                var hasaudio = reader.ReadByte();
                var hasimg = reader.ReadByte();
                var hasstatic = reader.ReadByte();
                BackgroundImage.Read(reader, true, null);
                BackgroundAudio.Read(reader, true, null);
                StaticEffect.Read(reader, true, null);

                MenuScript.Read(reader, true, null, null);

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

                /*/string sename = File.ReadAllText(path + "/static.txt");
                if (sename == "") Console.WriteLine("No static effect for menu");
                else StaticEffect = new StaticEffect();
                if (sename != "")
                {
                    StaticEffect.Temp = sename;
                    StaticEffect.Read(null, false, project);
                }/*/

                //TODO: Element reading
            }
        }
    }
}