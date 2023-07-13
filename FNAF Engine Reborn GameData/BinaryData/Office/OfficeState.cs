using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class OfficeState
    {
        public string Name { get; set; } //lets null these out so we can identify errors easily
        public Image Image { get; set; }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Image.Write(Writer, true, null);
            }
            else
            {
                Directory.CreateDirectory(projectpath + "/offices/default/office_states/" + Name);
                File.WriteAllText(projectpath + "/offices/default/office_states/" + Name + "/name.txt", Name);
                Directory.CreateDirectory(projectpath + "/offices/default/office_states/" + Name);
                if (Image != null)
                    File.WriteAllText(projectpath + "/offices/default/office_states/" + Name + "/mainsprite.txt", Image.Name);
                else
                    File.WriteAllText(projectpath + "/offices/default/office_states/" + Name + "/mainsprite.txt", "");
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
                Name = File.ReadAllText(statedir + "/name.txt");
                var imageName = File.ReadAllText(statedir + "/mainsprite.txt");
                Image = new Image();
                if (imageName != "")
                {
                    Image.Name = imageName;
                    Image.Read(null, false, projectpath);
                }
            }
        }
    }
}
