using FNAF_Engine_Reborn_GameData.BinaryData;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_GameData.BinaryData.Binaries
{
    public interface BinaryImage
    {
        void Write(ByteWriter Writer, bool binary, string project, string name);
        void Read(ByteReader reader, bool binary, string project, string name);
    }
}
