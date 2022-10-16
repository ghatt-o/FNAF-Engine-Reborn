using System.IO;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu_Code
    {
        //todo: menu code
        public ulong Lines { get; set; }
        public string[] Code { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {

            }
            else
            {

            }
        }

        public void Write(BinaryWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                //Writer.Write(Lines);
                //foreach (string CodeLine in Code)
                //{
                //Writer.Write(CodeLine);
                //}
            }
            else
            {

            }
        }
    }
}
