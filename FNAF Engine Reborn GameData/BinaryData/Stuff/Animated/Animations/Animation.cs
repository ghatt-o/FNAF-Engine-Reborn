using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations
{
    public class Animation
    {
        public List<AnimationFrame> Frames { get; set; } = new List<AnimationFrame>();

        public void Read(BinaryReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
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
                //todo
            }
        }
        public void Write(BinaryWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.Write((uint)Frames.Count);
                foreach (var frame in Frames)
                {
                    frame.Write(Writer, binary, projectpath);
                }
            }
            else
            {
                //todo
            }
        }
    }
}
