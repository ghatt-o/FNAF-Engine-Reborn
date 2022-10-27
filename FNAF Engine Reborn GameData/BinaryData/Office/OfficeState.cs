using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class OfficeState
    {
        public Image Image = new Image();

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Write(Writer);
            }
        }

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Read(reader, true, projectpath, null);
            }
        }
    }
}
