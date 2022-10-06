using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_GameData.BinaryData.Binaries
{
    public class Audio : BinaryImages
    {
        public string? Name { get; set; }
        public ulong? Size { get; set; }
        public byte[]? Data { get; set; }

        public void Read(BinaryReader reader, bool binary, string project, string? name)
        {
            if (binary == false)
            {
                FileInfo audioInfo = new FileInfo(project + "/sounds/" + name);

                Name = audioInfo.Name;
                Size = (ulong)audioInfo.Length;
                Data = File.ReadAllBytes(audioInfo.FullName);
            }
            else if (binary == true)
            {
                Name = reader.ReadString();
                Size = reader.ReadUInt32();
                Data = reader.ReadBytes((int)Size);
            }
        }

        public void Write(BinaryWriter Writer) //TODO: non binary writing
        {
            Writer.Write(Name);
            Writer.Write((long)Size);
            Writer.Write(Data);
        }
    }
}
