using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.Options
{
    public class GameOptions
    {
        public bool Fullscreen { get; set; }
        public bool Minigames { get; set; }
        public bool Watermarks { get; set; }
        public bool SrcFileOnExport { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == false)
            {
                string[] options = { "fullscreen", "minigamesenabled", "watermarks", "sourcecode" };

                foreach (string str in options)
                {
                    switch (str)
                    {
                        case "fullscreen":
                            if (File.ReadAllText(project + "/options.txt").Contains(str + "=true")) Fullscreen = true;
                            else Fullscreen = false;
                            break;
                        case "minigames":
                            if (File.ReadAllText(project + "/options.txt").Contains(str + "=true")) Minigames = true;
                            else Minigames = false;
                            break;
                        case "watermarks":
                            if (File.ReadAllText(project + "/options.txt").Contains(str + "=true")) Watermarks = true;
                            else Watermarks = false;
                            break;
                        case "sourcecode":
                            if (File.ReadAllText(project + "/options.txt").Contains(str + "=true")) SrcFileOnExport = true;
                            else SrcFileOnExport = false;
                            break;
                        default:
                            throw new KeyNotFoundException(str);
                            break;
                    }
                }
            }
            else if (binary == true)
            {
                Fullscreen = reader.ReadBoolean();
            }
        }
        public void Write(BinaryWriter Writer, bool binary, string project)
        {
            if (binary == false)
            {
                string newFile = File.ReadAllText(project + "/options.txt");


                if (Fullscreen == false) newFile.Replace("fullscreen=true", "fullscreen=false");
                else if (Fullscreen == true) newFile.Replace("fullscreen=false", "fullscreen=true");

                if (Minigames == false) newFile.Replace("minigamesenabled=true", "minigamesenabled=false");
                else if (Minigames == true) newFile.Replace("minigamesenabled=false", "minigamesenabled=true");

                if (Watermarks == false) newFile.Replace("watermarks=true", "watermarks=false");
                else if (Watermarks == true) newFile.Replace("watermarks=false", "watermarks=true");

                if (SrcFileOnExport == false) newFile.Replace("sourcecode=true", "sourcecode=false");
                else if (SrcFileOnExport == true) newFile.Replace("sourcecode=false", "sourcecode=true");


                File.WriteAllText(project + "/options.txt", newFile);
            }
            else if (binary == true)
            {
                Writer.Write(Fullscreen);
            }
        }
    }
}
