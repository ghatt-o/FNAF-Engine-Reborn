using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Values
{
    public class Variable
    {
        public string Key { get; set; } = "";
        public long Value { get; set; } = 0;

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                var keyLen = reader.ReadInt32();
                Key = reader.ReadAscii(keyLen);
                Value = reader.ReadInt64();
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
                Writer.WriteInt64(Value);
            }
            else
            {

            }
        }
    }
}
