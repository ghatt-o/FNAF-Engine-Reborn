using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Linq;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Binaries
{
    public class Stamp
    {
        public byte FER_Version { get; set; } = 0;
        public byte FER_PatchVersion { get; set; } = 9;
        public byte FER_MinorVersion { get; set; } = 4;

        public int BinariesCount { get; set; } = 0;
        public ushort MenuCount { get; set; } = 0;
        public byte[] Chunks { get; set; } = new byte[18];

        public void Write(ByteWriter Writer)
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

        public void Read(ByteReader reader)
        {
            reader.ReadBytes(3);

            FER_Version = reader.ReadByte();
            FER_PatchVersion = reader.ReadByte();
            FER_MinorVersion = reader.ReadByte();

            reader.ReadByte();

            BinariesCount = reader.ReadInt32();

            reader.ReadByte();

            MenuCount = reader.ReadUInt16();

            reader.ReadByte();
            reader.ReadByte();

            var ChunkCount = reader.ReadInt32();
            for (int i = 0; i < ChunkCount; i++)
            {
                var Chunk = reader.ReadByte();
                Chunks.Append(Chunk);
            }
        }
    }
}
