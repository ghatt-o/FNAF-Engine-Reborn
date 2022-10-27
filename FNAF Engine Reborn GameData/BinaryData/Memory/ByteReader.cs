using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Memory
{
    public class ByteReader : BinaryReader
    {
        public ByteReader(Stream input) : base(input)
        {
        }

        public string AutoReadUnicode()
        {
            var len = ReadByte();
            short check = ReadInt16();
            return ReadWideString(len);
        }

        public void Seek(Int64 offset, SeekOrigin seekOrigin = SeekOrigin.Begin)
        {
            BaseStream.Seek(offset, seekOrigin);
        }

        public void Skip(Int64 count)
        {
            BaseStream.Seek(count, SeekOrigin.Current);
        }
        public byte[] ReadFourCc()
        {
            return Encoding.UTF8.GetBytes(ReadAscii(4));
        }

        public Int64 Tell()
        {
            return BaseStream.Position;
        }

        public Int64 Size()
        {
            return BaseStream.Length;
        }

        public bool Check(int size)
        {
            return Size() - Tell() >= size;
        }

        public bool Eof()
        {
            return BaseStream.Position < BaseStream.Length;
        }

        public UInt16 PeekUInt16()
        {
            UInt16 value = ReadUInt16();
            Seek(-2, SeekOrigin.Current);
            return value;
        }
        public byte PeekByte()
        {
            byte value = ReadByte();
            Seek(-1, SeekOrigin.Current);
            return value;
        }
        public Int16 PeekInt16()
        {
            Int16 value = ReadInt16();
            Seek(-2, SeekOrigin.Current);
            return value;
        }


        public Int32 PeekInt32()
        {
            Int32 value = ReadInt32();
            Seek(-4, SeekOrigin.Current);
            return value;
        }


        public string ReadAscii(int length = -1)
        {
            string str = "";
            if (length >= 0)
            {
                for (int i = 0; i < length; i++)
                {
                    str += Convert.ToChar(ReadByte());
                }
            }
            else
            {
                byte b = ReadByte();
                while (b != 0)
                {
                    str += Convert.ToChar(b);
                    b = ReadByte();
                }
            }

            return str;
        }



        public string ReadWideString(int length = -1)
        {

            String str = "";
            if (length >= 0)
            {
                for (int i = 0; i < length; i++)
                {
                    str += Convert.ToChar(ReadUInt16());
                }
            }
            else
            {
                var b = ReadUInt16();
                while (b != 0)
                {
                    str += Convert.ToChar(b);
                    b = ReadUInt16();
                }
            }

            return str;
        }

        public string ReadUniversal(int len = -1)
        {
            return ReadAscii(len);
        }
        public Color ReadColor()
        {

            var r = ReadByte();
            var g = ReadByte();
            var b = ReadByte();
            var a = ReadByte();

            return Color.FromArgb(a, r, g, b);

        }

        public override byte[] ReadBytes(int count = -1)
        {
            if (count == -1) return base.ReadBytes((int)this.Size());
            return base.ReadBytes(count);
        }

        public byte ReadInt8()
        {
            return ReadByte();
        }

        public bool ReadBool()
        {
            return ReadBoolean();
        }
    }
}
