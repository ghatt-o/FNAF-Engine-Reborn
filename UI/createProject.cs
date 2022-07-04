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
                MessageBox.Show("Put something in there!");
            }
            else
            {
                try
                {
                    MessageBox.Show("Creating your project! This may take a few seconds. (CLICK OK TO CONTINUE!)");
                    string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
                    Directory.CreateDirectory(projectPath);
                    Directory.CreateDirectory(projectPath + "/offices/");
                    Directory.CreateDirectory(projectPath + "/offices/default/");
                    Directory.CreateDirectory(projectPath + "/offices/default/sprites");
                    Directory.CreateDirectory(projectPath + "/offices/default/office_states/");
                    Directory.CreateDirectory(projectPath + "/offices/default/office_states/Default/");
                    Directory.CreateDirectory(projectPath + "/statics/");
                    Directory.CreateDirectory(projectPath + "/images");
                    Directory.CreateDirectory(projectPath + "/animations");
                    Directory.CreateDirectory(projectPath + "/animatronics");
                    Directory.CreateDirectory(projectPath + "/animatronics/normal/");
                    Directory.CreateDirectory(projectPath + "/animatronics/phantom/");
                    Directory.CreateDirectory(projectPath + "/sounds");
                    Directory.CreateDirectory(projectPath + "/menus");
                    CreateMenu(projectPath, "GameOver");
                    CreateMenu(projectPath, "Main");
                    CreateMenu(projectPath, "Warning");
                    CreateMenu(projectPath, "6AM");
                    Directory.CreateDirectory(projectPath + "/scripts");
                    Directory.CreateDirectory(projectPath + "/scripts/visual");
                    Directory.CreateDirectory(projectPath + "/scripts/csharp");
                    Directory.CreateDirectory(projectPath + "/scripts/scriptic");
                    File.CreateText(projectPath + "/game.txt");
                    File.CreateText(projectPath + "/gameid.txt");
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
                    File.WriteAllText(projectPath + "/offices/default/sprites.txt", "");
                    File.WriteAllText(projectPath + "/name.txt", projectNamebox.Text);
                    MessageBox.Show("Project created succesfully!");
                    this.Hide();
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
                    else if(comboBox1.SelectedItem == null)
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
            Directory.CreateDirectory(projectPath + "/animations/" + "Camera");
            Directory.CreateDirectory(projectPath + "/animations/" + "Mask");
            Directory.CreateDirectory(projectPath + "/scripts/visual/Endings");
            Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder");
            this.Hide();
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
            Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder1");
            Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder2");
            Directory.CreateDirectory(projectPath + "/scripts/visual/Endings");
            Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder2");
            Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder2");
            Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder2");
            Directory.CreateDirectory(projectPath + "/statics/Static1");
            Directory.CreateDirectory(projectPath + "/statics/Static2");
            this.Hide();
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
            Directory.CreateDirectory(projectPath + "/animations/" + "Camera");
            Directory.CreateDirectory(projectPath + "/animations/" + "Mask");
            Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder1");
            Directory.CreateDirectory(projectPath + "/animations/" + "Placeholder2");
            Directory.CreateDirectory(projectPath + "/scripts/visual/Endings");
            Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder");
            Directory.CreateDirectory(projectPath + "/scripts/visual/placeholder2");
            Directory.CreateDirectory(projectPath + "/scripts/csharp/placeholder2");
            Directory.CreateDirectory(projectPath + "/scripts/scriptic/placeholder2");
            Directory.CreateDirectory(projectPath + "/statics/Static1");
            Directory.CreateDirectory(projectPath + "/statics/Static2");
            this.Hide();
        }
        private void premadeMenus()
        {
            string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
            File.WriteAllText(projectPath + "/template.txt", "Premade Menus");
            CreateMenu(projectPath, "CustomNight");
            CreateMenu(projectPath, "News");
            CreateMenu(projectPath, "Ending5");
            CreateMenu(projectPath, "Ending6");
            CreateMenu(projectPath, "Ending7");
            this.Hide();
        }
        private void rMenus()
        {
            string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
            File.WriteAllText(projectPath + "/template.txt", "Required Menus");
            this.Hide();
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
            Directory.CreateDirectory(projectPath + "/menus/" + Name);
            Directory.CreateDirectory(projectPath + "/menus/" + Name + "/text_elements");
            File.WriteAllText(projectPath + "/menus/" + Name + "/name.txt", Name);
        }
    }
}