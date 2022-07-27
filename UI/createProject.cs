using System;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class createProject : Form

    {
        public static string projectPath
        {
            get;
            protected set;
        }
        public createProject()
        {
            InitializeComponent();
        }
        private void createProjectbtn_Click(object sender, EventArgs e)
        {
            if (projectNamebox.Text == "")
            {
                _ = MessageBox.Show("Put something in there!");
            }
            else
            {
                try
                {
                    _ = MessageBox.Show("Creating your project! This may take a few seconds. (CLICK OK TO CONTINUE!)");
                    string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
                    _ = Directory.CreateDirectory(projectPath);
                    _ = Directory.CreateDirectory(projectPath + "/offices/");
                    _ = Directory.CreateDirectory(projectPath + "/offices/default/");
                    _ = Directory.CreateDirectory(projectPath + "/offices/default/sprites");
                    _ = Directory.CreateDirectory(projectPath + "/offices/default/office_states/");
                    _ = Directory.CreateDirectory(projectPath + "/offices/default/office_states/Default/");
                    _ = Directory.CreateDirectory(projectPath + "/statics/");
                    _ = Directory.CreateDirectory(projectPath + "/images");
                    _ = Directory.CreateDirectory(projectPath + "/animations");
                    _ = Directory.CreateDirectory(projectPath + "/animatronics");
                    _ = Directory.CreateDirectory(projectPath + "/animatronics/normal/");
                    _ = Directory.CreateDirectory(projectPath + "/animatronics/phantom/");
                    _ = Directory.CreateDirectory(projectPath + "/sounds");
                    _ = Directory.CreateDirectory(projectPath + "/menus");
                    CreateMenu(projectPath, "GameOver");
                    CreateMenu(projectPath, "Main");
                    CreateMenu(projectPath, "Warning");
                    CreateMenu(projectPath, "6AM");
                    _ = Directory.CreateDirectory(projectPath + "/scripts");
                    _ = Directory.CreateDirectory(projectPath + "/scripts/visual");
                    _ = Directory.CreateDirectory(projectPath + "/scripts/csharp");
                    _ = Directory.CreateDirectory(projectPath + "/scripts/scriptic");
                    _ = File.CreateText(projectPath + "/game.txt");
                    _ = File.CreateText(projectPath + "/gameid.txt");
                    if (checkBox1.Checked == true)
                    {
                        File.WriteAllText(projectPath + "/style.txt", "fnaf4");
                    }
                    else
                    {
                        File.WriteAllText(projectPath + "/style.txt", "fnaf1");
                    }
                    File.WriteAllText(projectPath + "/options.txt", "fullscreen=false,minigamesenabled=false,watermarks=false,sourcecode=false");
                    File.WriteAllText(projectPath + "/offices/default/office.txt", "power=false,toxic=false,mask=false,camera=false,flashlight=false,panorama=false,perspective=false,ucnstyle=false,animatronic=,");
                    File.WriteAllText(projectPath + "/offices/default/misc.txt", "camera=,mask=,powerout=");
                    File.WriteAllText(projectPath + "/data.txt", "night:1,6thnight:false");
                    File.WriteAllText(projectPath + "/offices/default/sprites.txt", "");
                    File.WriteAllText(projectPath + "/name.txt", projectNamebox.Text);
                    _ = MessageBox.Show("Project created succesfully!");
                    Hide();
                    if (comboBox1.SelectedItem.Equals("Premade Assets"))
                    {
                        premadeAssets();
                    }
                    else if (comboBox1.SelectedItem.Equals("Premade Menus"))
                    {
                        premadeMenus();
                    }
                    else if (comboBox1.SelectedItem.Equals("Required Empty Menus"))
                    {
                        rMenus();
                    }
                    else if (comboBox1.SelectedItem.Equals("John's Template"))
                    {
                        JohnsTemplate();
                    }
                    else if (comboBox1.SelectedItem.Equals("James' Template"))
                    {
                        JamesTemplate();
                    }
                    else if (comboBox1.SelectedItem.Equals("None"))
                    {
                        File.WriteAllText(projectPath + "/template.txt", "None");
                    }
                    else if (comboBox1.SelectedItem == null)
                    {
                        File.WriteAllText(projectPath + "/template.txt", "None");
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        private void premadeAssets()
        {
            string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
            File.WriteAllText(projectPath + "/template.txt", "Premade Assets");
            CreateMenu(projectPath, "CustomNight");
            CreateMenu(projectPath, "News");
            CreateMenu(projectPath, "Ending5");
            CreateMenu(projectPath, "Ending6");
            CreateMenu(projectPath, "Ending7");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Camera");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Mask");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/Endings");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder");
            Hide();
        }
        private void JamesTemplate()
        {
            string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
            File.WriteAllText(projectPath + "/template.txt", "James' Template");
            CreateMenu(projectPath, "CustomNight");
            CreateMenu(projectPath, "News");
            CreateMenu(projectPath, "Ending5");
            CreateMenu(projectPath, "Ending6");
            CreateMenu(projectPath, "Ending7");
            CreateMenu(projectPath, "My_Menu");
            CreateMenu(projectPath, "My_Menu2");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder1");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/Endings");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/statics/Static1");
            _ = Directory.CreateDirectory(projectPath + "/statics/Static2");
            Hide();
        }
        private void JohnsTemplate()
        {
            string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
            File.WriteAllText(projectPath + "/template.txt", "John's Template");
            CreateMenu(projectPath, "CustomNight");
            CreateMenu(projectPath, "News");
            CreateMenu(projectPath, "Ending5");
            CreateMenu(projectPath, "Ending6");
            CreateMenu(projectPath, "Ending7");
            CreateMenu(projectPath, "My_Menu");
            CreateMenu(projectPath, "My_Menu2");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Camera");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Mask");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder1");
            _ = Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/Endings");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder");
            _ = Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder2");
            _ = Directory.CreateDirectory(projectPath + "/statics/Static1");
            _ = Directory.CreateDirectory(projectPath + "/statics/Static2");
            Hide();
        }
        private void premadeMenus()
        {
            string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
            File.WriteAllText(projectPath + "/template.txt", "Premade Menus");
            CreateMenu(projectPath, "CustomNight");
            CreateMenu(projectPath, "News");
            Hide();
        }
        private void rMenus()
        {
            string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
            File.WriteAllText(projectPath + "/template.txt", "Required Menus");
            Hide();
        }

        private void createProject_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.AddRange(System.IO.Directory.GetDirectories("assets/custom_assets/templates/"));
            }
            catch (Exception)
            {

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("John's Template"))
            {
                pictureBox1.Show();
            }
            else
            {
                pictureBox1.Hide();
            }
        }
        private void CreateMenu(string projectPath, string Name)
        {
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name);
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name + "/text_elements");
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name + "/variables");
            File.WriteAllText(projectPath + "/menus/" + Name + "/name.txt", Name);
            File.WriteAllText(projectPath + "/menus/" + Name + "/ongameloop.txt", "");
            File.WriteAllText(projectPath + "/menus/" + Name + "/onmenustart.txt", "");
        }
    }
}