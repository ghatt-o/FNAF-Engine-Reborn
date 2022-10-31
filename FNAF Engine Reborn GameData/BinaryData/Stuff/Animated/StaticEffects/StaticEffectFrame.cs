using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects
{
    public class StaticEffectFrame
    {
        public Image Image { get; set; } = new Image();
        public ushort Speed { get; set; } = 0;

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Read(reader, true, "", "");
                Speed = reader.ReadUInt16();
            }
            else
            {
                //todo
            }
        }
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Write(Writer);
                Writer.WriteUInt16(Speed);
            }
            else
            {
                //todo prj writing
            }
        }
    }
}
