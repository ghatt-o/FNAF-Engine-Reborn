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
        public string Layer { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Deleted { get; set; } //Also referred to as "args".

        public string SortData()
        {
            return $"name=~{Name}~,image=~{Image}~,layer=~{Layer}~,X=~{X}~,Y=~{Y}~";
        }
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                //Todo
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
                //Todo
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
                    var img = System.Drawing.Image.FromFile(ImagePath);
                    Image = new();
                    Image.Size = Convert.ToInt64(img.Size);
                    Image.Data = File.ReadAllBytes(ImagePath);
                    Image.Name = Path.GetFileNameWithoutExtension(ImagePath);
                    Layer = SpriteProperties[5];
                    X = Convert.ToInt32(SpriteProperties[7]);
                    Y = Convert.ToInt32(SpriteProperties[9]);
                }
            }
        }
    }
}
