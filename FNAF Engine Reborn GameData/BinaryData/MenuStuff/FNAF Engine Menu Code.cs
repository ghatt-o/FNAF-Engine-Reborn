using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_GameData.BinaryData.MenuStuff
{
    public class FNAF_Engine_Menu_Code
    {
        //todo: menu code
        public ulong Lines { get; set; }
        public string[] Code { get; set; }

        public void Read(ByteReader reader, bool binary, string project)
        {
            if (binary == true)
            {

            }
            else
            {

            }
        }

        public void Write(ByteWriter Writer, bool binary, string project)
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
