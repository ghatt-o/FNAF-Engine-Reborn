using FNAF_Engine_GameData.BinaryData.MenuStuff;
using FNAF_Engine_Reborn_GameData;
using FNAF_Engine_Reborn_GameData.BinaryData.Scripts;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations;
using System;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class createProject : Form
    {

        public GameData game;

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
            if (gameStyleOptions.SelectedItem == null)
            {
                MessageBox.Show("Choose a game style first!");
            }
            if (projectNamebox.Text == "")
            {
                _ = MessageBox.Show("Input your project name in the first box!");
            }
            else
            {
                try
                {
                    _ = MessageBox.Show("Creating your project! This may take a few seconds. (CLICK OK TO CONTINUE!)");
                    string projectPath = @"assets/custom_assets/projects/" + projectNamebox.Text;
                    Directory.CreateDirectory(projectPath);
                    game = new GameData();
                    game.Name = projectPath;
                    if (gameStyleOptions.SelectedIndex == 0) //standard game style
                    {
                        FNAF_Engine_Menu menu = new FNAF_Engine_Menu();
                        game.Menus.Add(menu);
                    }
                    else if (gameStyleOptions.SelectedIndex == 1) //fnaf game style
                    {
                        game.Style = "fmaf1";
                        FNAF_Engine_Menu menu = new FNAF_Engine_Menu();
                        menu.Name = "Main";
                        FNAF_Engine_Menu menu2 = new FNAF_Engine_Menu();
                        menu.Name = "Warning";
                        FNAF_Engine_Menu menu3 = new FNAF_Engine_Menu();
                        menu.Name = "6AM";
                        game.Menus.Add(menu);
                        game.Menus.Add(menu2);
                        game.Menus.Add(menu3);

                        switch (comboBox1.SelectedIndex)
                        {
                            case 1: //premade assets
                                premadeAssets();
                                break;
                            case 2: //premade menus
                                premadeMenus();
                                break;
                            case 3: //required empty menus
                                rMenus();
                                break;
                            case 4: //johns template
                                JohnsTemplate();
                                break;
                            case 5: //james template
                                JamesTemplate();
                                break;
                            default:
                                game.Template = "None";
                                break;
                        }

                        if (comboBox1.SelectedItem.Equals("Premade Assets")) //1
                        {
                            premadeAssets();
                        }
                        else if (comboBox1.SelectedItem.Equals("Premade Menus")) //2
                        {
                            premadeMenus();
                        }
                        else if (comboBox1.SelectedItem.Equals("Required Empty Menus")) //3
                        {
                            rMenus();
                        }
                        else if (comboBox1.SelectedItem.Equals("John's Template")) //4
                        {
                            JohnsTemplate();
                        }
                        else if (comboBox1.SelectedItem.Equals("James' Template")) //5
                        {
                            JamesTemplate();
                        }
                        else if (comboBox1.SelectedItem.Equals("None")) //0
                        {
                            game.Template = "None";
                        }
                        else if (comboBox1.SelectedItem == null) //null???
                        {
                            game.Template = "None";
                        }
                    }
                    else if (gameStyleOptions.SelectedIndex == 2) //fnaf 4 game style
                    {
                        game.Style = "fmaf4";
                    }
                    else if (gameStyleOptions.SelectedIndex == 3) //fnaf 5 game style
                    {
                        game.Style = "fmaf5";
                    }
                    else if (gameStyleOptions.SelectedIndex == 4) //fnaf 6 game style
                    {
                        game.Style = "fmaf6";
                    }
                    else if (gameStyleOptions.SelectedIndex == 5) //fnaf world game style
                    {
                        if (comboBox1.SelectedItem.Equals("Premade Assets")) //1
                        {
                            var Fishing = new FNAF_Engine_Menu();
                            Fishing.Name = "Fishing";
                            var ShoppingUpgrade = new FNAF_Engine_Menu();
                            Fishing.Name = "Shopping Upgrade";
                            game.Menus.Add(Fishing);
                            game.Menus.Add(ShoppingUpgrade);
                        }
                    }
                    game.Write(null, false, projectPath);
                    _ = MessageBox.Show("Project created succesfully!");
                }
                catch (Exception ex)
                {
                    Logger.Log("Failed to create project! Error: 11 or " + ex);
                }
                finally
                {
                    Hide();
                }
            }
        }
        private void premadeAssets()
        {
            game.Template = "Premade Assets";

            FNAF_Engine_Menu menu = new FNAF_Engine_Menu();
            menu.Name = "CustomNight";
            FNAF_Engine_Menu menu2 = new FNAF_Engine_Menu();
            menu.Name = "News";
            FNAF_Engine_Menu menu3 = new FNAF_Engine_Menu();
            menu.Name = "Ending5";
            FNAF_Engine_Menu menu4 = new FNAF_Engine_Menu();
            menu.Name = "Ending6";
            FNAF_Engine_Menu menu5 = new FNAF_Engine_Menu();
            menu.Name = "Ending7";

            Animation anim = new Animation();
            anim.Name = "Camera";
            Animation anim2 = new Animation();
            anim.Name = "Mask";

            Script script = new Script();
            script.Name = "Endings";

            game.Menus.Add(menu);
            game.Menus.Add(menu2);
            game.Menus.Add(menu3);
            game.Menus.Add(menu4);
            game.Menus.Add(menu5);

            game.Animations.Add(anim);
            game.Animations.Add(anim2);

            game.Scripts.Add(script);
        }
        private void JamesTemplate()
        {
            game.Template = "James' Template";

            FNAF_Engine_Menu menu = new FNAF_Engine_Menu();
            menu.Name = "CustomNight";
            FNAF_Engine_Menu menu2 = new FNAF_Engine_Menu();
            menu.Name = "News";
            FNAF_Engine_Menu menu3 = new FNAF_Engine_Menu();
            menu.Name = "Ending5";
            FNAF_Engine_Menu menu4 = new FNAF_Engine_Menu();
            menu.Name = "Ending6";
            FNAF_Engine_Menu menu5 = new FNAF_Engine_Menu();
            menu.Name = "Ending7";

            FNAF_Engine_Menu menu6 = new FNAF_Engine_Menu();
            menu.Name = "Secret";
            FNAF_Engine_Menu menu7 = new FNAF_Engine_Menu();
            menu.Name = "Extras";

            Animation anim = new Animation();
            anim.Name = "Camera";
            Animation anim2 = new Animation();
            anim.Name = "Mask";

            Script script = new Script();
            script.Name = "Endings";

            game.Menus.Add(menu);
            game.Menus.Add(menu2);
            game.Menus.Add(menu3);
            game.Menus.Add(menu4);
            game.Menus.Add(menu5);
            game.Menus.Add(menu6);
            game.Menus.Add(menu7);

            game.Animations.Add(anim);
            game.Animations.Add(anim2);

            game.Scripts.Add(script);
        }
        private void JohnsTemplate()
        {
            game.Template = "John's Template";

            FNAF_Engine_Menu menu = new FNAF_Engine_Menu();
            menu.Name = "CustomNight";
            FNAF_Engine_Menu menu2 = new FNAF_Engine_Menu();
            menu.Name = "News";
            FNAF_Engine_Menu menu3 = new FNAF_Engine_Menu();
            menu.Name = "Ending5";
            FNAF_Engine_Menu menu4 = new FNAF_Engine_Menu();
            menu.Name = "Ending6";
            FNAF_Engine_Menu menu5 = new FNAF_Engine_Menu();
            menu.Name = "Ending7";

            FNAF_Engine_Menu menu6 = new FNAF_Engine_Menu();
            menu.Name = "Secret";
            FNAF_Engine_Menu menu7 = new FNAF_Engine_Menu();
            menu.Name = "Extras";

            Animation anim = new Animation();
            anim.Name = "Camera";
            Animation anim2 = new Animation();
            anim.Name = "Mask";

            Script script = new Script();
            script.Name = "Endings";

            game.Menus.Add(menu);
            game.Menus.Add(menu2);
            game.Menus.Add(menu3);
            game.Menus.Add(menu4);
            game.Menus.Add(menu5);
            game.Menus.Add(menu6);
            game.Menus.Add(menu7);

            game.Animations.Add(anim);
            game.Animations.Add(anim2);

            game.Scripts.Add(script);
        }
        private void premadeMenus()
        {
            game.Template = "Premade Menus";

            FNAF_Engine_Menu menu = new FNAF_Engine_Menu();
            menu.Name = "CustomNight";
            FNAF_Engine_Menu menu2 = new FNAF_Engine_Menu();
            menu.Name = "News";

            game.Menus.Add(menu);
            game.Menus.Add(menu2);
        }
        private void rMenus()
        {
            game.Template = "Required Menus";
            //This is already here even if the user didn't set a template.
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
        private void CreateMenu(string projectPath, string Name) //PRE-REWRITE DONT USE DONT USE
        {
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name);
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name + "/text_elements");
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name + "/image_elements");
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name + "/variables");
            _ = Directory.CreateDirectory(projectPath + "/menus/" + Name + "/events");
            File.WriteAllText(projectPath + "/menus/" + Name + "/name.txt", Name);
        }

        private void gameStyleOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gameStyleOptions.SelectedIndex == 1)
            {
                fnaf4style_CheckBox.Show();
            }
            else
            {
                fnaf4style_CheckBox.Hide();
            }
        }
    }
}