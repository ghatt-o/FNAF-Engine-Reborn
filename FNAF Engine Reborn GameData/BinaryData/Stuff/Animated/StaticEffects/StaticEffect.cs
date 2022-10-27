using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects
{
    public class StaticEffect
    {
        public List<StaticEffectFrame> Frames { get; set; } = new List<StaticEffectFrame>();

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                uint frameCount = reader.ReadUInt32();
                for (int i = 0; i < frameCount; i++)
                {
                    StaticEffectFrame frame = new StaticEffectFrame();
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
