using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Collections.Generic;
using System.Linq;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Binaries
{
    public class Stamp : BinaryClass
    {
        public byte FER_Version { get; set; } = 0;
        public byte FER_PatchVersion { get; set; } = 2;
        public byte FER_MinorVersion { get; set; } = 0;

        public int BinariesCount { get; set; } = 0;
        public ushort MenuCount { get; set; } = 0;
        public List<byte> Chunks { get; set; } = new();

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteInt8((byte)1);
                Writer.WriteInt8((byte)2);
                Writer.WriteInt8((byte)3);

                Writer.WriteInt8(FER_Version);
                Writer.WriteInt8(FER_PatchVersion);
                Writer.WriteInt8(FER_MinorVersion);

                Writer.WriteInt8((byte)1);

                Writer.WriteInt32(BinariesCount);

                Writer.WriteInt8((byte)1);

                Writer.WriteUInt16(MenuCount);

                Writer.WriteInt8((byte)1);
                Writer.WriteInt8((byte)2);

                Writer.WriteInt32(Chunks.Count());
                foreach (byte chunk in Chunks)
                {
                    Writer.WriteInt8(chunk);
                }
            }
            else
            {
                //todo
            }
        }

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                reader.ReadBytes(3);

                FER_Version = reader.ReadByte();
                FER_PatchVersion = reader.ReadByte();
                FER_MinorVersion = reader.ReadByte();

                reader.ReadByte();

                BinariesCount = reader.ReadInt32();

                reader.ReadByte();

                MenuCount = reader.ReadUInt16();

                reader.ReadBytes(2);

                var ChunkCount = reader.ReadInt32();
                for (int i = 0; i < ChunkCount; i++)
                {
                    var Chunk = reader.ReadByte();
                    Chunks.Add(Chunk);
                }
            }
            else
            {
                //todo
            }
        }
    }
}
