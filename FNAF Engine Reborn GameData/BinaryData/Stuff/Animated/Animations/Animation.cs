using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Collections.Generic;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations
{
    public class Animation
    {
        public List<AnimationFrame> Frames { get; set; } = new List<AnimationFrame>();

        public void Read(ByteReader reader, bool binary, string projectpath)
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
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteUInt32((uint)Frames.Count);
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
