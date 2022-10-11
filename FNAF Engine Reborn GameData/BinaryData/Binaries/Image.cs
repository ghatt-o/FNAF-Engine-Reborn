using System.IO;

namespace FNAF_Engine_GameData.BinaryData.Binaries
{
    public class Image : BinaryImage
    {
        public ulong Size { get; set; }
        public byte[] Data { get; set; }

        public void Read(BinaryReader reader, bool binary, string project, string name)
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
