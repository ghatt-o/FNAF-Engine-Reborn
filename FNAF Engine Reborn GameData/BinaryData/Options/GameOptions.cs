using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.Options
{
    public class GameOptions
    {
        public bool Fullscreen { get; set; } = false;
        public bool Minigames { get; set; } = false;
        public bool Watermarks { get; set; } = false;
        public bool SrcFileOnExport { get; set; } = false;

        public void Read(ByteReader reader, bool binary, string project)
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
                    }
                }
            }
            else if (binary == true)
            {
                Fullscreen = reader.ReadBool();
            }
        }
        public void Write(ByteWriter Writer, bool binary, string project)
        {
            if (binary == false)
            {
                string newFile = "fullscreen=false,minigamesenabled=false,watermarks=false,sourcecode=false"; //wtf, i used to read a options.txt? :skull: now ima reuse old code idc

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
                Writer.WriteBool(Fullscreen);
            }
        }
    }
}
