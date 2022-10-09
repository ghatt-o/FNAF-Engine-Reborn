using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_GameData.BinaryData.Options
{
    public class OfficeOptions
    {
        public bool PowerEnabled { get; set; }
        public bool ToxicEnabled { get; set; }
        public bool MaskEnabled { get; set; }
        public bool CameraEnabled { get; set; }
        public bool FlashlightEnabled { get; set; }
        public bool PanoramaEnabled { get; set; }
        public bool PerspectiveEnabled { get; set; }
        public bool UCNStyleEnabled { get; set; }
        public string AnimatronicToKill { get; set; }

        public void Read(BinaryReader reader, bool binary, string project)
        {
            if (binary == true)
            {
                if (reader.ReadInt32() == 510)
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
                } //get rekt decompilers lol ~wait i am one myself uhhh i mean just a protection so decompilers can spend alot of time on it (random useless int lo)
            }
            else
            {

            }
        }
        public void Write(BinaryWriter Writer, bool binary, string project)
        {
            if (binary == true)
            {
                Writer.Write(510); //useless int just to mess decompilers

                Writer.Write(PowerEnabled);
                Writer.Write(ToxicEnabled);
                Writer.Write(MaskEnabled);
                Writer.Write(CameraEnabled);
                Writer.Write(FlashlightEnabled);
                Writer.Write(PanoramaEnabled);
                Writer.Write(PerspectiveEnabled);
                Writer.Write(UCNStyleEnabled);
                Writer.Write(AnimatronicToKill);
            }
        }
    }
}
