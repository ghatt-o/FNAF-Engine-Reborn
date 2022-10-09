using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu_Code
    {
        public ulong Lines { get; set; }
        public string[] Code { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {

            }
        }

        public void Write(BinaryWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.Write(Lines);
                foreach (string CodeLine in Code)
                {
                    Writer.Write(CodeLine);
                }
            }
        }
    }
}
