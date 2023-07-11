using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class Animatronic : BinaryClass
    {
        public Audio Jumpscare_Sound = new();
        public Animation Jumpscare_Animation = new();
        public string Name = "";
        public bool IsPhantom = false;
        public bool IgnoresMask = false;
        public bool AudioLured = false;
        public bool LikeBalloonBoy;
        public List<AnimPathNode> Path = new();
        public int[] AILevels = { 0, 0, 0, 0, 0, 0 };

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Name = reader.AutoReadUnicode();
                IsPhantom = reader.ReadBool();
                IgnoresMask = reader.ReadBool();
                AudioLured = reader.ReadBool();
                LikeBalloonBoy = reader.ReadBool();
                AILevels[0] = reader.ReadInt32();
                AILevels[1] = reader.ReadInt32();
                AILevels[2] = reader.ReadInt32();
                AILevels[3] = reader.ReadInt32();
                AILevels[4] = reader.ReadInt32();
                AILevels[5] = reader.ReadInt32();
            }
            else
            {
                //name has to be set before
                Name = File.ReadAllText(projectpath + "/animatronics/" + Name + "/name.txt");
                File.ReadAllText(projectpath + "/animatronics/" + Name + "/phantom.txt", IsPhantom + "");
                File.ReadAllText(projectpath + "/animatronics/" + Name + "/ignoresmask.txt", IgnoresMask + "");
                File.ReadAllText(projectpath + "/animatronics/" + Name + "/audiolured.txt", AudioLured + "");
                File.ReadAllText(projectpath + "/animatronics/" + Name + "/bb.txt", LikeBalloonBoy + "");
                File.ReadAllText(projectpath + "/animatronics/" + Name + "/ai.txt", AILevels[0] + "," + AILevels[1] + "," + AILevels[2] + "," + AILevels[3] + "," + AILevels[4] + "," + AILevels[5]);
                Jumpscare_Animation.Write(null, false, projectpath);
                Jumpscare_Sound.Write(null, false, projectpath);
                Directory.CreateDirectory(projectpath + "/animatronics/path");
                foreach (var pathnode in Path)
                {
                    pathnode.Write(null, false, projectpath, projectpath + "/animatronics/path");
                }
            }
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.AutoWriteUnicode(Name);
                Writer.Write(IsPhantom);
                Writer.Write(IgnoresMask);
                Writer.Write(AudioLured);
                Writer.Write(LikeBalloonBoy);
                Writer.WriteInt32(AILevels[0]);
                Writer.WriteInt32(AILevels[1]);
                Writer.WriteInt32(AILevels[2]);
                Writer.WriteInt32(AILevels[3]);
                Writer.WriteInt32(AILevels[4]);
                Writer.WriteInt32(AILevels[5]);
                Jumpscare_Animation.Write(null, false, projectpath);
                Jumpscare_Sound.Write(null, false, projectpath);
            }
            else
            {
                File.WriteAllText(projectpath + "/animatronics/" + Name + "/name.txt", Name);
                File.WriteAllText(projectpath + "/animatronics/" + Name + "/phantom.txt", IsPhantom + "");
                File.WriteAllText(projectpath + "/animatronics/" + Name + "/ignoresmask.txt", IgnoresMask + "");
                File.WriteAllText(projectpath + "/animatronics/" + Name + "/audiolured.txt", AudioLured + "");
                File.WriteAllText(projectpath + "/animatronics/" + Name + "/bb.txt", LikeBalloonBoy + "");
                File.WriteAllText(projectpath + "/animatronics/" + Name + "/ai.txt", AILevels[0] + "," + AILevels[1] + "," + AILevels[2] + "," + AILevels[3] + "," + AILevels[4] + "," + AILevels[5]);
                Jumpscare_Animation.Write(null, false, projectpath);
                Jumpscare_Sound.Write(null, false, projectpath);
                Directory.CreateDirectory(projectpath + "/animatronics/path");
                foreach (var pathnode in Path)
                {
                    pathnode.Write(null, false, projectpath, projectpath + "/animatronics/path");
                }
            }
        }
    }
}