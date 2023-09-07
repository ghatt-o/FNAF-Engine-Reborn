using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class OfficeSprite
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public int Layer { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Deleted { get; set; } //Also referred to as "args".

        public string SortData()
        {
            return $"name=~{Name}~,image=~{Image.Name}~,layer=~{Layer}~,X=~{X}~,Y=~{Y}~";
        }
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.AutoWriteUnicode(Name);
                Image.Write(Writer, true, null);
                Writer.WriteInt32(Layer);
                Writer.WriteInt32(X);
                Writer.WriteInt32(Y);
                Writer.WriteBool(Deleted);
            }
            else
            {
                Directory.CreateDirectory(projectpath + "/offices/default/sprites");
                Directory.CreateDirectory(projectpath + "/offices/default/sprites/" + Name);
                File.WriteAllText(projectpath + "/offices/default/sprites/" + Name + "/data.txt", SortData());
            }
        }

        public void Read(ByteReader reader, bool binary, string projectpath, string spritedir)
        {
            Name = null;
            if (binary == true)
            {
                Name = reader.AutoReadUnicode();
                Image.Read(reader, true, null);
                Layer = reader.ReadInt32();
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
                var int8bool = reader.ReadInt8();
                if (int8bool == 0) Deleted = false;
                else Deleted = true;
                //this should work
            }
            else
            {
                string SpritePropertiesText = File.ReadAllText(spritedir + "/data.txt");
                string[] SpriteProperties = SpritePropertiesText.Split('~');
                if (SpritePropertiesText.Contains("[ptp]")) // if deleted
                {
                    Deleted = true;
                }
                else
                {
                    Name = SpriteProperties[1];
                    var ImagePath = SpriteProperties[3];
                    var img = System.Drawing.Image.FromFile(projectpath + "/images/" + ImagePath + "");
                    Image = new();
                    Image.Size = File.ReadAllBytes(projectpath + "/images/" + ImagePath + "").LongLength;
                    Image.Data = File.ReadAllBytes(projectpath + "/images/" + ImagePath + "");
                    Image.Name = Path.GetFileNameWithoutExtension(projectpath + "/images/" + ImagePath + "");
                    Layer = Convert.ToInt32(SpriteProperties[5]);
                    X = Convert.ToInt32(SpriteProperties[7]);
                    Y = Convert.ToInt32(SpriteProperties[9]);
                }
            }
        }
    }
}
