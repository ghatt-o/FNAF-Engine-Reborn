using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Values
{
    public class StringVariable : BinaryClass
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                var keyLen = reader.ReadInt32();
                Key = reader.ReadAscii(keyLen);
                Value = reader.AutoReadUnicode();
            }
            else
            {

            }
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.WriteInt32(Key.Length);
                Writer.WriteAscii(Key);
                Writer.AutoWriteUnicode(Value);
            }
            else
            {

            }
        }
    }
}
