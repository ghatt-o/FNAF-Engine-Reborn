using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects
{
    public class StaticEffectFrame
    {
        public Image Image = new();
        public uint Speed { get; set; } = 1;
        public int FrameOrder = 0;

        public void Read(ByteReader reader, bool binary, string projectpath, string actualproject)
        {
            if (binary == true)
            {
                Image.Read(reader, true, null);
                Speed = reader.ReadUInt32();
            }
            else
            {
                //projectpath is the file path here
                var stuff = File.ReadAllText(projectpath).Split(',');
                Image = new();
                Image.Name = stuff[0];
                Image.Read(null, false, projectpath);
                Speed = Convert.ToUInt16(stuff[1]);
            }
        }
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Write(Writer, true, null);
                Writer.WriteUInt32(Speed);
            }
            else
            {
                //projectpath is file path
                File.WriteAllText(projectpath, Image.Name + "," + Speed);
            }
        }
    }
}
