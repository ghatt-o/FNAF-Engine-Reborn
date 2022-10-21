using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Values
{
    public class StringVariable
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;

        public void Read(BinaryReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Key = reader.ReadString();
                Value = reader.ReadString();
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
