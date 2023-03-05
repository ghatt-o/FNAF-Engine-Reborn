using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects
{
    public class StaticEffectFrame : BinaryClass
    {
        public int ImageHandle = 0;
        public ushort Speed { get; set; } = 0;

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                ImageHandle = reader.ReadInt32();
                Speed = reader.ReadUInt16();
            }
            else
            {
                //projectpath is the file path here
                var stuff = File.ReadAllText(projectpath).Split(',');
                ImageHandle = Convert.ToInt32(stuff[0]);
                Speed = Convert.ToUInt16(stuff[1]);
            }
        }
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteInt32(ImageHandle);
                Writer.WriteUInt16(Speed);
            }
            else
            {
                //projectpath is file path
                File.WriteAllText(projectpath, ImageHandle + "," + Speed);
            }
        }
    }
}
