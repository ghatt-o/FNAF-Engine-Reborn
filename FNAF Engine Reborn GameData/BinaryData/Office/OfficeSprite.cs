using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class OfficeSprite
    {
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                //Todo
            }
            else
            {
                Directory.CreateDirectory(projectpath + "/offices/default/sprites"); ;
            }
        }

        public void Read(ByteReader reader, bool binary, string projectpath, string statedir)
        {
            if (binary == true)
            {
                //Todo
            }
            else
            {
                //Todo
            }
        }
    }
}
