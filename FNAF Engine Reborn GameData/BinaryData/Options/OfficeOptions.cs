using FNAF_Engine_Reborn_GameData.BinaryData;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.IO;

namespace FNAF_Engine_GameData.BinaryData.Options
{
    public class OfficeOptions : BinaryClass
    {
        public bool PowerEnabled { get; set; }
        public bool ToxicEnabled { get; set; }
        public bool MaskEnabled { get; set; }
        public bool CameraEnabled { get; set; }
        public bool FlashlightEnabled { get; set; }
        public bool PanoramaEnabled { get; set; }
        public bool PerspectiveEnabled { get; set; }
        public bool UCNStyleEnabled { get; set; }
        public string AnimatronicToKill { get; set; } = "";
        public int Hours { get; set; } = 6;
        public int PowerPercentage { get; set; } = 100;

        public void Read(ByteReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                //holy shit this code is outdated
                PowerEnabled = reader.ReadBoolean();
                ToxicEnabled = reader.ReadBoolean();
                MaskEnabled = reader.ReadBoolean();
                CameraEnabled = reader.ReadBoolean();
                FlashlightEnabled = reader.ReadBoolean();
                PanoramaEnabled = reader.ReadBoolean();
                PerspectiveEnabled = reader.ReadBoolean();
                UCNStyleEnabled = reader.ReadBoolean();
                AnimatronicToKill = reader.AutoReadUnicode();
                Hours = reader.ReadInt32();
            }
            else
            {
                //power=false,toxic=false,mask=false,camera=true,flashlight=false,panorama=false,perspective=false,ucnstyle=false,animatronic=,hours=6,
                foreach (var flag in File.ReadAllText(project + "/offices/default/office.txt").Split(','))
                {
                    if (flag == "power=False") PowerEnabled = false;
                    if (flag == "power=True") PowerEnabled = true;

                    if (flag == "toxic=False") ToxicEnabled = false;
                    if (flag == "toxic=True") ToxicEnabled = true;

                    if (flag == "mask=False") MaskEnabled = false;
                    if (flag == "mask=True") MaskEnabled = true;

                    if (flag == "camera=False") CameraEnabled = false;
                    if (flag == "camera=True") CameraEnabled = true;

                    if (flag == "flashlight=False") FlashlightEnabled = false;
                    if (flag == "flashlight=True") FlashlightEnabled = true;

                    if (flag == "panorama=False") PanoramaEnabled = false;
                    if (flag == "panorama=True") PanoramaEnabled = true;

                    if (flag == "perspective=False") PerspectiveEnabled = false;
                    if (flag == "perspective=True") PerspectiveEnabled = true;

                    if (flag == "ucnstyle=False") UCNStyleEnabled = false;
                    if (flag == "ucnstyle=True") UCNStyleEnabled = true;

                    if (flag.Contains("animatronic="))
                    {
                        AnimatronicToKill = flag.Split('=')[1];
                        Console.WriteLine(flag.Split('=')[1]);
                    }

                    if (flag.Contains("hours="))
                    {
                        Hours = Convert.ToInt32(flag.Split('=')[1]);
                        Console.WriteLine(flag.Split('=')[1]);
                    }

                    if (flag.Contains("powerpercentage="))
                    {
                        PowerPercentage = Convert.ToInt32(flag.Split('=')[1]);
                        Console.WriteLine(flag.Split('=')[1]);
                    }
                }
            }
        }
        public void Write(ByteWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.Write(PowerEnabled);
                Writer.Write(ToxicEnabled);
                Writer.Write(MaskEnabled);
                Writer.Write(CameraEnabled);
                Writer.Write(FlashlightEnabled);
                Writer.Write(PanoramaEnabled);
                Writer.Write(PerspectiveEnabled);
                Writer.Write(UCNStyleEnabled);
                Writer.AutoWriteUnicode(AnimatronicToKill);
                Writer.Write(Hours);
            }
            else
            {
                File.WriteAllText(project + "/offices/default/office.txt", "");
                foreach (var prop in GetType().GetProperties())
                {
                    //todo: clean up
                    if (prop.Name == "PowerEnabled") FileAppend(project + "/offices/default/office.txt", "power=" + PowerEnabled + ",");
                    else if (prop.Name == "ToxicEnabled") FileAppend(project + "/offices/default/office.txt", "toxic=" + ToxicEnabled + ",");
                    else if (prop.Name == "MaskEnabled") FileAppend(project + "/offices/default/office.txt", "mask=" + MaskEnabled + ",");
                    else if (prop.Name == "CameraEnabled") FileAppend(project + "/offices/default/office.txt", "camera=" + CameraEnabled + ",");
                    else if (prop.Name == "FlashlightEnabled") FileAppend(project + "/offices/default/office.txt", "flashlight=" + FlashlightEnabled + ",");
                    else if (prop.Name == "PanoramaEnabled") FileAppend(project + "/offices/default/office.txt", "panorama=" + PanoramaEnabled + ",");
                    else if (prop.Name == "PerspectiveEnabled") FileAppend(project + "/offices/default/office.txt", "perspective=" + PerspectiveEnabled + ",");
                    else if (prop.Name == "UCNStyleEnabled") FileAppend(project + "/offices/default/office.txt", "ucnstyle=" + UCNStyleEnabled + ",");
                    else if (prop.Name == "AnimatronicToKill") FileAppend(project + "/offices/default/office.txt", "animatronic=" + AnimatronicToKill + ",");
                    else if (prop.Name == "Hours") FileAppend(project + "/offices/default/office.txt", "hours=" + Hours + ",");
                    else if (prop.Name == "PowerPercentage") FileAppend(project + "/offices/default/office.txt", "powerpercentage=" + PowerPercentage + ",");
                    else throw new InvalidDataException("Couldn't find property '" + prop.Name + "'!");
                }
                void FileAppend(string path, string contents)
                {
                    File.AppendAllText(path, contents);
                }
                void FileClear(string path)
                {
                    File.Delete(path);
                    File.WriteAllText(path, "");
                }
            }
        }
    }
}
