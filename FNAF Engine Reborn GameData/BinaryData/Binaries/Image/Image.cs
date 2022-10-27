using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.Binaries
{
    public class Image : BinaryImage
    {
        public ulong Size { get; set; } = 0;
        public byte[] Data { get; set; } = new byte[0];

        public void Read(ByteReader reader, bool binary, string project, string name)
        {
            if (binary == false)
            {
                FileInfo imageInfo = new FileInfo(project + "/images/" + name);

                Name = imageInfo.Name;
                Size = (ulong)imageInfo.Length;
                Data = File.ReadAllBytes(imageInfo.FullName);
            }
            else if (binary == true)
            {
                Name = reader.AutoReadUnicode();
                Size = reader.ReadUInt64();
                Data = reader.ReadBytes((int)Size);
            }
        }

        public void Write(ByteWriter Writer) //TODO: non binary writing
        {
            Writer.AutoWriteUnicode(Name);
            Writer.WriteUInt64(Size);
            Writer.WriteBytes(Data);
        }
    }
}
