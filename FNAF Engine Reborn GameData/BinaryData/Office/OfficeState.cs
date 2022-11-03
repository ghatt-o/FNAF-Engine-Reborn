using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class OfficeState
    {
        public string Name { get; set; } = "Default";
        public Image Image { get; set; } = new Image();

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Write(Writer, true, null);
            }
            else
            {
                File.WriteAllText(projectpath + "/offices/default/office_states/mainsprite.txt", Image.Name);
            }
        }

        public void Read(ByteReader reader, bool binary, string projectpath, string statedir)
        {
            if (binary == true)
            {
                Image.Read(reader, true, null);
            }
            else
            {
                var imageName = File.ReadAllText(statedir + "/mainsprite.txt");
                Image img = new Image();
                img.Name = imageName;
                img.Read(null, false, projectpath);
            }
        }
    }
}
