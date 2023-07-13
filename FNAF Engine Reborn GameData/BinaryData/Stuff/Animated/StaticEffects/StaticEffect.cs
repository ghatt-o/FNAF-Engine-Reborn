using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects
{
    public class StaticEffect : BinaryClass
    {
        public string Name { get; set; } = "Static Effect";
        public List<StaticEffectFrame> Frames { get; set; } = new List<StaticEffectFrame>();
        public string Temp = "Static Effect"; //I hope this works

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                uint frameCount = reader.ReadUInt32();
                for (int i = 0; i < frameCount; i++)
                {
                    StaticEffectFrame frame = new StaticEffectFrame();
                    frame.Read(reader, true, null, null);
                    Frames.Add(frame);
                }
            }
            else
            {
                Name = File.ReadAllText(Temp + "/name.txt");

                StaticEffectFrame frame = new StaticEffectFrame();
                frame.Read(null, false, Temp, projectpath);
                Frames.Add(frame);
            }
        }
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary)
            {
                Writer.WriteUInt32((uint)Frames.Count);
                foreach (var frame in Frames)
                {
                    frame.Write(Writer, binary, projectpath);
                }
            }
            else
            {
                File.WriteAllText(projectpath + "/statics/" + Name + "/name.txt", Name);
                Directory.CreateDirectory(projectpath + "/statics/" + Name + "/frames");
                foreach (var frame in Frames)
                {
                    Directory.CreateDirectory(projectpath + "/statics/" + Name + "/frames/" + frame.FrameOrder);
                    frame.Write(null, false, projectpath + "/statics/" + Name + "/frames/" + frame.FrameOrder);
                }
            }
        }
    }
}
