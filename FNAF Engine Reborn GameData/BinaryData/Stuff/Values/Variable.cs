using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Values
{
    public class Variable
    {
        public string Key { get; set; }
        public long Value { get; set; }

        public void Read(BinaryReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Key = reader.ReadString();
                Value = reader.ReadInt64();
            }
            else
            {

            }
        }

        public void Write(BinaryWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.Write(Key);
                Writer.Write(Value);
            }
            else
            {

            }
        }
    }
}
