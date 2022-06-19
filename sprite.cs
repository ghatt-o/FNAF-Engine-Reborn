namespace FNAF_Engine_Reborn
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class Sprite
    {
        private reborn reborn;

        public Sprite(reborn reborn)
        {
            this.reborn = reborn;
        }

        public string project { get; set; }
        public string Name { get; private set; }
        public string Image { get; set; }
        public string Layer { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Deleted { get; set; }
        public string SortData()
        {
            return $"name=~{Name}~,image=~{Image}~,layer=~{Layer}~,X=~{X}~,Y=~{Y}~";
        }
        public void Add(string FileName, string Path)
        {
            if (Directory.Exists(project + "/office/default/sprites/" + FileName))
            {
                //we won't add anything because it already exists
            }
            else
            {
                //vars
                string FilePath = Path;
                //code
                Sprite sprite = new Sprite(reborn);
                sprite.Name = FileName;
                sprite.Image = FilePath;
                //Console.WriteLine(FileName);
                //Console.WriteLine(FilePath);
                sprite.Layer = "1";
                sprite.X = "0";
                sprite.Y = "0";
                string SpriteData = sprite.SortData();
                //create sprite
                Directory.CreateDirectory(project + "/offices/default/sprites/" + FileName);
                File.WriteAllText(project + "/offices/default/sprites/" + FileName + "/data.txt", SpriteData);
                File.Copy(FilePath, project + "/offices/default/sprites/" + FileName + "/" + FileName);
            }
        }
        public void Intiate()
        {
            reborn.officePreview.Controls.Clear();
            var AllSprites = Directory.GetDirectories(project + "/offices/default/sprites/");
            foreach (string Sprite in AllSprites) // for each sprite found
            {
                //setting vars
                string SpritePropertiesText = File.ReadAllText(Sprite + "/data.txt");
                var SpriteProperties = SpritePropertiesText.Split('~');
                string Name = SpriteProperties[1];
                string Image = SpriteProperties[3];
                string Layer = SpriteProperties[5];
                string X = SpriteProperties[7];
                string Y = SpriteProperties[9];
                Image img = System.Drawing.Image.FromFile(Image);
                //code
                var NewSprite = new Sprite(reborn);
                NewSprite.Name = Name;
                NewSprite.Image = Image;
                NewSprite.Layer = Layer;
                NewSprite.X = X;
                NewSprite.Y = Y;
                int PicBoxX = Convert.ToInt32(NewSprite.X);
                int PicBoxY = Convert.ToInt32(NewSprite.Y);
                //setting up the image preview
                PictureBox sprite = new PictureBox();
                sprite.Name = NewSprite.Name;
                sprite.MinimumSize = new Size(0, 0);
                sprite.MaximumSize = new Size(581, 342);
                sprite.BackgroundImageLayout = ImageLayout.Stretch;
                sprite.Size = img.Size;
                sprite.BackColor = Color.Transparent;
                Console.WriteLine();
                sprite.BackgroundImage = System.Drawing.Image.FromFile(project + "/offices/default/sprites/" + NewSprite.Name + "/" + NewSprite.Name);
                Console.WriteLine();
                sprite.Location = new Point(PicBoxX, PicBoxY);
                sprite.Move += Sprite_Move;
                sprite.Draggable(true);
                sprite.MouseEnter += Sprite_MouseEnter;
                sprite.MouseClick += Sprite_MouseClick;
                sprite.MouseDoubleClick += Sprite_Delete;
                void Sprite_MouseClick(object sender, MouseEventArgs e)
                {
                    if (e.Button == MouseButtons.Middle)
                    {
                        if (NewSprite.Layer == "1")
                        {
                            NewSprite.Layer = "0";
                            string txt = NewSprite.SortData();
                            File.WriteAllText(project + "/offices/default/sprites/" + NewSprite.Name + "/data.txt", txt);
                            sprite.SendToBack();
                        }
                        else
                        {
                            NewSprite.Layer = "1";
                            string txt = NewSprite.SortData();
                            File.WriteAllText(project + "/offices/default/sprites/" + NewSprite.Name + "/data.txt", txt);
                            sprite.BringToFront();
                        }
                    }
                }
                void Sprite_MouseEnter(object sender, EventArgs e)
                {
                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(sprite, "Left Click to drag, Middle Click to layer, Double Right Click to delete");
                }
                void Sprite_Delete(object sender, MouseEventArgs e)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        NewSprite.Deleted = "true";
                        string txt = NewSprite.SortData();
                        File.WriteAllText(project + "/offices/default/sprites/" + NewSprite.Name + "/data.txt", txt + "[ptp]");
                        sprite.Visible = false;
                    }
                }
                void Sprite_Move(object sender, EventArgs e)
                {
                    NewSprite.X = Convert.ToString(sprite.Location.X);
                    NewSprite.Y = Convert.ToString(sprite.Location.Y);
                    string txt = NewSprite.SortData();
                    File.WriteAllText(project + "/offices/default/sprites/" + NewSprite.Name + "/data.txt", txt);
                }
                if (SpritePropertiesText.Contains("[ptp]"))
                {
                    sprite.Visible = false;
                }
                reborn.officePreview.Controls.Add(sprite);
                if (NewSprite.Layer == "1")
                {
                    sprite.BringToFront();
                    sprite.BringToFront();
                    sprite.BringToFront();
                }
                else
                {
                    sprite.SendToBack();
                    sprite.SendToBack();
                    sprite.SendToBack();
                }
            }
        }
    }
}
