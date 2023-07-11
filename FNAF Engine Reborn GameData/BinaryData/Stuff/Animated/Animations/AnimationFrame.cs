using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations
{
    public class AnimationFrame : BinaryClass
    {
        public Image Image { get; set; } = new Image();
        public uint Speed { get; set; } = 0;
        public int Order = -1;

        //the image is written on an Images folder..
        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Read(reader, true, "");
                Speed = reader.ReadUInt16();
            }
            else
            {
                Speed = (uint)Convert.ToInt32(File.ReadAllText(projectpath + "/speed.txt"));
                foreach (var file in Directory.GetFiles(projectpath))
                {
                    if (!file.EndsWith(".txt")) Image.Read(null, false, file); ;
                }
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
                File.WriteAllText(projectpath + "/speed.txt", Convert.ToString(Speed));
                Image.Write(null, false, projectpath);
            }
        }
    }
}
