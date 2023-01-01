using FNAF_Engine_GameData.BinaryData.MenuStuff;
using FNAF_Engine_Reborn_GameData;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Game
{
    public class FER_Game
    {
        public FNAF_Engine_Game ferg;
        public FER_Game(FNAF_Engine_Game ferg)
        {
            this.ferg = ferg;
        }

        public bool Init()
        {
            return true;
        }

        public void DrawMenu(FNAF_Engine_Menu Menu)
        {
            Panel menu_panel = new Panel
            {
                Size = ferg.Size,
                Name = Menu.Name,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Black
            };

            try
            {
                File.WriteAllBytes(Path.GetTempPath() + "/" + Menu.BackgroundImage.Name, Menu.BackgroundImage.Data);
                menu_panel.BackgroundImage = Image.FromFile(Path.GetTempPath() + "/" + Menu.BackgroundImage.Name);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Failed to load menu {menu_panel.Name} image: Image file not found");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine($"Failed to load menu {menu_panel.Name} image: Bad file!");
            }

            menu_panel.Visible = false;

            if (menu_panel.Name == "Main" || menu_panel.Name == "Warning")
            {
                menu_panel.Tag = 1;
                menu_panel.BringToFront(); 
            }

            menu_panel.VisibleChanged += Menu_Load;

            menu_panel.Visible = true;

            menu_panel.Paint += Menu_Start;

            async void Menu_Load(object sender, EventArgs e)
            {
                //TODO: Scripts
            }

            async void Menu_Start(object sender, EventArgs e)
            {
                try
                {
                    //System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(File.ReadAllText(project + "/menus/" + Menu.Name + "/audio.txt"));
                    //while (true)
                    //{
                    //    await Task.Delay(1);
                    //}
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not play " + Menu.Name + "'s background audio.");
                }
            }
        }

        public void DrawTextElement(Elements.TextElement text_element, Panel menu)
        {
            //Add the TextElement on Menu's Controls
            menu.Controls.Add(text_element);
        }
    }
}
