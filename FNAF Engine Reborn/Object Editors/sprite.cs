using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public class Sprite
    {
        private readonly reborn reborn;

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
                Sprite sprite = new Sprite(reborn)
                {
                    Name = FileName,
                    Image = FilePath,
                    Layer = "1",
                    X = "0",
                    Y = "0"
                };
                string SpriteData = sprite.SortData();
                //create sprite
                _ = Directory.CreateDirectory(project + "/offices/default/sprites/" + FileName);
                File.WriteAllText(project + "/offices/default/sprites/" + FileName + "/data.txt", SpriteData);
                File.Copy(FilePath, project + "/offices/default/sprites/" + FileName + "/" + FileName);
            }
        }
        public void Intiate()
        {
            foreach (Control ctrl in reborn.officePreview.Controls)
            {
                if (ctrl.Tag == "Sprite") reborn.officePreview.Controls.Remove(ctrl);
            }
            string[] AllSprites = Directory.GetDirectories(project + "/offices/default/sprites/");
            foreach (string Sprite in AllSprites) // for each sprite found
            {
                //setting vars

                string SpritePropertiesText = File.ReadAllText(Sprite + "/data.txt");
                string[] SpriteProperties = SpritePropertiesText.Split('~');

                if (SpritePropertiesText.Contains("[ptp]")) // if deleted
                {

                }
                else
                {
                    string Name = SpriteProperties[1];
                    string Image = SpriteProperties[3];
                    string Layer = SpriteProperties[5];
                    string X = SpriteProperties[7];
                    string Y = SpriteProperties[9];
                    Image img = System.Drawing.Image.FromFile(Image);

                    //code

                    Sprite NewSprite = new Sprite(reborn)
                    {
                        Name = Name,
                        Image = Image,
                        Layer = Layer,
                        X = X,
                        Y = Y
                    };
                    int PicBoxX = Convert.ToInt32(NewSprite.X);
                    int PicBoxY = Convert.ToInt32(NewSprite.Y);

                    //setting up the image preview

                    PictureBox sprite = new PictureBox
                    {
                        Tag = "Sprite",
                        Name = NewSprite.Name,
                        MinimumSize = new Size(0, 0),
                        MaximumSize = new Size(581, 342),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Size = img.Size,
                        BackColor = Color.Transparent
                    };
                    Console.WriteLine();
                    sprite.BackgroundImage = System.Drawing.Image.FromFile(project + "/offices/default/sprites/" + NewSprite.Name + "/" + NewSprite.Name);
                    Console.WriteLine();
                    sprite.Location = new Point(PicBoxX, PicBoxY);
                    sprite.Move += Sprite_Move;
                    sprite.Draggable(true);
                    sprite.MouseEnter += Sprite_MouseEnter;
                    sprite.MouseLeave += Sprite_MouseLeave;
                    sprite.MouseClick += Sprite_MouseClick;
                    sprite.MouseDoubleClick += Sprite_Delete;
                    void Sprite_MouseLeave(object sender, EventArgs e)
                    {
                        sprite.BorderStyle = BorderStyle.None;
                    }
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

                        sprite.BorderStyle = BorderStyle.FixedSingle;
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
                        sprite.BorderStyle = BorderStyle.Fixed3D;
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
}
