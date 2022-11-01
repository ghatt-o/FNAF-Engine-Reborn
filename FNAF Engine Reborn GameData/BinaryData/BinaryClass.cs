using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_Reborn_GameData.BinaryData
{
    public interface BinaryClass
    {
        void Write(ByteWriter Writer, bool binary, string projectpath);
        void Read(ByteReader reader, bool binary, string projectpath);
    }
}
