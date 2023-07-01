using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class Animatronic : BinaryClass
    {
        public Audio Jumpscare_Sound = new();
        public Animation Jumpscare_Animation = new();
        public string Name = "";
        public bool IsPhantom = false;
        public AnimPathNode[] Path;

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            //TODO: Animatronic Reading
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            //TODO: Animatronic Writing
        }
    }
}