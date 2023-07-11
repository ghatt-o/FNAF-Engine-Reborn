using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations
{
    public class Animation
    {
        public string Name { get; set; } = "Animation";
        public List<AnimationFrame> Frames { get; set; } = new List<AnimationFrame>();

        public void Read(ByteReader reader, bool binary, string projectpath, string path)
        {
            if (binary == true)
            {
                Name = reader.AutoReadUnicode();
                uint frameCount = reader.ReadUInt32();
                for (int i = 0; i < frameCount; i++)
                {
                    AnimationFrame frame = new AnimationFrame();
                    frame.Read(reader, binary, projectpath);
                    Frames.Add(frame);
                }
            }
            else
            {
                Name = File.ReadAllText(path + "/name.txt");
                foreach (var dir in Directory.GetDirectories(path + "/animation"))
                {
                    AnimationFrame frame = new();
                    frame.Read(null, false, dir);
                }
            }
        }
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.AutoWriteUnicode(Name);
                Writer.WriteUInt32((uint)Frames.Count);
                foreach (var frame in Frames)
                {
                    frame.Write(Writer, binary, projectpath);
                }
            }
            else
            {
                File.WriteAllText(projectpath + "/animations/" + Name + "/name.txt", Name);
                Directory.CreateDirectory(projectpath + "/animations/" + Name + "/animation");
                foreach (var frame in Frames)
                {
                    Directory.CreateDirectory(projectpath + "/animations/" + Name + "/animation/" + frame.Order); ;
                    frame.Write(null, false, projectpath + "/animations/" + Name + "/animation/" + frame.Order);
                }
            }
        }
    }
}
