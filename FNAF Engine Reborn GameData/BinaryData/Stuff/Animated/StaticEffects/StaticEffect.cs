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
                    frame.Read(reader, true, null);
                    Frames.Add(frame);
                }
            }
            else
            {
                foreach (var file in Directory.GetFiles(projectpath + "/statics/" + Temp))
                {
                    if (file == projectpath + "/statics/" + Temp + "/name.txt") Name = File.ReadAllText(projectpath + "/statics/" + Temp + "/name.txt");
                    StaticEffectFrame frame = new StaticEffectFrame();
                    frame.Read(null, false, file);
                    Frames.Add(frame);
                }
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
                //temp is file path
                Directory.CreateDirectory(Temp);
                File.WriteAllText(Temp + "/name.txt", Name);
                
                foreach (var frame in Frames)
                {
                    frame.Write(null, false, Temp);
                }
            }
        }
    }
}
