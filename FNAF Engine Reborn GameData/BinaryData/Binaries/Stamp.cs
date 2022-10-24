using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Binaries
{
    public class Stamp
    {
        public byte FER_Version { get; set; } = 0;
        public byte FER_PatchVersion { get; set; } = 9;
        public byte FER_MinorVersion { get; set; } = 4;

        public int BinariesCount { get; set; } = 0;
        public int MenuCount { get; set; } = 0;
        public byte[] Chunks { get; set; } = new byte[18];

        public void Write(ByteWriter Writer)
        {
            Writer.Write((byte)1);
            Writer.Write((byte)2);
            Writer.Write((byte)3);

            Writer.Write(FER_Version);
            Writer.Write(FER_PatchVersion);
            Writer.Write(FER_MinorVersion);

            Writer.Write((byte)1);

            Writer.Write(BinariesCount);

            Writer.Write((byte)1);

            Writer.Write(MenuCount);

            Writer.Write((byte)2);

            Writer.Write(Chunks.Count());
            foreach (byte chunk in Chunks)
            {
                Writer.Write(chunk);
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
        }
    }
}
