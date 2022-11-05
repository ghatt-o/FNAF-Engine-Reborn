using FNAF_Engine_Reborn_GameData.BinaryData;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace FNAF_Engine_GameData.BinaryData.Options
{
    public class OfficeOptions : BinaryClass
    {
        public bool PowerEnabled { get; set; } = false;
        public bool ToxicEnabled { get; set; } = false;
        public bool MaskEnabled { get; set; } = false;
        public bool CameraEnabled { get; set; } = false;
        public bool FlashlightEnabled { get; set; } = false;
        public bool PanoramaEnabled { get; set; } = false;
        public bool PerspectiveEnabled { get; set; } = false;
        public bool UCNStyleEnabled { get; set; } = false;
        public string AnimatronicToKill { get; set; } = "";
        public int Hours { get; set; } = 6;

        public void Read(ByteReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                PowerEnabled = reader.ReadBoolean();
                ToxicEnabled = reader.ReadBoolean();
                MaskEnabled = reader.ReadBoolean();
                CameraEnabled = reader.ReadBoolean();
                FlashlightEnabled = reader.ReadBoolean();
                PanoramaEnabled = reader.ReadBoolean();
                PerspectiveEnabled = reader.ReadBoolean();
                UCNStyleEnabled = reader.ReadBoolean();
                AnimatronicToKill = reader.ReadString();
                Hours = reader.ReadInt32();
            }
            else
            {
                //power=false,toxic=false,mask=false,camera=true,flashlight=false,panorama=false,perspective=false,ucnstyle=false,animatronic=,hours=6,
                foreach (var flag in File.ReadAllText(project + "/offices/default/office.txt").Split(','))
                {
                    if (flag == "power=false") PowerEnabled = false;
                    if (flag == "power=true") PowerEnabled = true;

                    if (flag == "toxic=false") ToxicEnabled = false;
                    if (flag == "toxic=true") ToxicEnabled = true;

                    if (flag == "mask=false") MaskEnabled = false;
                    if (flag == "mask=true") MaskEnabled = true;

                    if (flag == "camera=false") CameraEnabled = false;
                    if (flag == "camera=true") CameraEnabled = true;

                    if (flag == "flashlight=false") FlashlightEnabled = false;
                    if (flag == "flashlight=true") FlashlightEnabled = true;

                    if (flag == "panorama=false") PanoramaEnabled = false;
                    if (flag == "panorama=true") PanoramaEnabled = true;

                    if (flag == "perspective=false") PerspectiveEnabled = false;
                    if (flag == "perspective=true") PerspectiveEnabled = true;

                    if (flag == "ucnstyle=false") UCNStyleEnabled = false;
                    if (flag == "ucnstyle=true") UCNStyleEnabled = true;

                    if (flag.Contains("animatronic="))
                    {
                        AnimatronicToKill = flag.Split('=')[1];
                    }

                    if (flag.Contains("hours="))
                    {
                        Hours = Convert.ToInt32(flag.Split('=')[1]);
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
                Writer.Write(AnimatronicToKill);
                Writer.Write(Hours);
            }
            else
            {
                File.WriteAllText(project + "/offices/default/office.txt", "power=false,toxic=false,mask=false,camera=true,flashlight=false,panorama=false,perspective=false,ucnstyle=false,animatronic=,hours=6,"); //what the fuck its still reading from existing file
                foreach (var prop in GetType().GetProperties())
                {
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
                    else throw new InvalidDataException("Couldn't find property '" + prop.Name + "'! (At line 109, Office Settings Read()!)");
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
