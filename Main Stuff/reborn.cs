using FNAF_Engine_Reborn.bin;
using FNAF_Engine_Reborn.Main_Stuff;
using FNAF_Engine_Reborn.Object_Editors;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class reborn : Form
    {
        public bool showProject;
        public string Version = "pre-1.0.0";
        public string Build_Version = "pre-rf1.0.0.-1";
        public bool isopen = false;
        internal bool usableEngine = true;
        public string script;
        public bool editable;

        public string style;
        //private DiscordRpc.EventHandlers handlers;
        //private DiscordRpc.RichPresence presence;
        internal static loadFERproject projectloader = new loadFERproject();

        public string projecto;

        private string v;

        public reborn()
        {
            InitializeComponent();
        }

        private void createFolder(string folder)
        {
            _ = Directory.CreateDirectory(projecto + folder);
        }
        public void GetFunctions(string v)
        {
            this.v = v;
        }
        private void reborn_Load(object sender, EventArgs e)
        {
            File.WriteAllText("DO_NOT_MODIFY.txt", "");
#if DEBUG
            {
                //button67.Visible = true; //load editors button gets visible lol so useless
            }
#endif
            if (Version == "pre-1.0.0")
            {
                label93.Location = new Point(850, 1);
            }
            else
            {
                label93.Location = new Point(872, 1);
            }
            this.Text = "Sunset Creator";
            Random random = new Random();
            int randomNumber = random.Next(1, 38);
            //switch (randomNumber)
            //{
            //
            //}
            if (randomNumber == 1)
            {
                label84.Text = "Good Morning!";
            }
            if (randomNumber == 2)
            {
                label84.Text = "You're Amazing!";
            }
            if (randomNumber == 3)
            {
                label84.Text = "Reborn!";
            }
            if (randomNumber == 4)
            {
                label84.Text = "Do you like cheese?";
            }
            if (randomNumber == 5)
            {
                label84.Text = "Better late than never!";
            }
            if (randomNumber == 6)
            {
                label84.Text = "Made by lily!";
            }
            if (randomNumber == 7)
            {
                label84.Text = "I'm John!";
            }
            if (randomNumber == 8)
            {
                label84.Text = "What's your name?";
            }
            if (randomNumber == 9)
            {
                label84.Text = "Funny!";
            }
            if (randomNumber == 10)
            {
                label84.Text = "Hmm hold on I'm thinking...";
            }
            if (randomNumber == 11)
            {
                label84.Text = "Do you read these?";
            }
            if (randomNumber == 12)
            {
                label84.Text = "Tons of effort!";
            }
            if (randomNumber == 13)
            {
                label84.Text = "There's no limit!";
            }
            if (randomNumber == 14)
            {
                label84.Text = "Was that an jojo reference?";
            }
            if (randomNumber == 15)
            {
                label84.Text = "FE Was a blessing.";
            }
            if (randomNumber == 16)
            {
                label84.Text = "How are you?";
            }
            if (randomNumber == 17)
            {
                label84.Text = "Beatiful day outside!";
            }
            if (randomNumber == 18)
            {
                label84.Text = "Feb 27 is an special day!";
            }
            if (randomNumber == 19)
            {
                label84.Text = "Wow!";
            }
            if (randomNumber == 20)
            {
                label84.Text = "Pigs :)";
            }
            if (randomNumber == 21)
            {
                label84.Text = "69";
            }
            if (randomNumber == 22)
            {
                label84.Text = "420";
            }
            if (randomNumber == 23)
            {
                label84.Text = "Jokes!";
            }
            if (randomNumber == 24)
            {
                label84.Text = "April Fools!";
            }
            if (randomNumber == 25)
            {
                label84.Text = "Perhaps.";
            }
            if (randomNumber == 26)
            {
                label84.Text = "Check out Scriptic!";
            }
            if (randomNumber == 27)
            {
                label84.Text = "I won!";
            }
            if (randomNumber == 28)
            {
                label84.Text = "FNF Engine?";
            }
            if (randomNumber == 28)
            {
                label84.Text = "Wait what?";
            }
            if (randomNumber == 30)
            {
                label84.Text = "For real!?";
            }
            if (randomNumber == 31)
            {
                label84.Text = "For real?";
            }
            if (randomNumber == 32)
            {
                label84.Text = "Did you do your homework yet?";
            }
            if (randomNumber == 33)
            {
                label84.Text = "Do you love god?";
            }
            if (randomNumber == 34)
            {
                label84.Text = "Check out FNAF Maker!";
            }
            if (randomNumber == 35)
            {
                label84.Text = "Who's joe?";
            }
            if (randomNumber == 36)
            {
                label84.Text = "Still beta!";
            }
            if (randomNumber == 37)
            {
                label84.Text = "Yeah!";
            }
            if (randomNumber == 38)
            {
                label84.Text = "Snow!";
            }
            //this.handlers = default(DiscordRpc.EventHandlers);
            //DiscordRpc.Initialize("970030742241439774", ref this.handlers, true, null);
            //this.handlers = default(DiscordRpc.EventHandlers);
            //DiscordRpc.Initialize("970030742241439774", ref this.handlers, true, null);
            //this.presence.details = "Version: " + Version;
            //this.presence.state = "No project loaded";
            //this.presence.largeImageKey = "1";
            //this.presence.largeImageText = "";
            //this.presence.smallImageText = "";
            //DiscordRpc.UpdatePresence(ref this.presence);
            //if (File.Exists("DO_NOT_MODIFY.txt"))
            //{
            //    if (File.ReadAllText("DO_NOT_MODIFY.txt") == "2QVZ-V2Q5-CS6Z-S8AY-4YE9-SDAQ-5AR3-GUSJ-PQDQ-UMZP-E7JH-6JLU")
            //    {
            //        usableEngine = true;
            //    }
            //    else
            //    {
            //        usableEngine = false;
            //    }
            //}
            label93.Text = "Version: " + Version;
            label72.Text = "FE:R Build Version: \"" + Build_Version + "\"";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changelogs rebornChangelogs = new changelogs();
            rebornChangelogs.Show();
            Text = "Sunset Creator - Changelogs";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createProject createNew = new createProject();
            _ = createNew.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            templateCreator templateMaker = new templateCreator();
            _ = templateMaker.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            createProject projectmaker = new createProject();
            projectmaker.Show();
        }

        private void createProjectBTN_MouseHover(object sender, EventArgs e)
        {
            bigProjectICON.BackColor = Color.FromArgb(39, 39, 39);
        }

        private void createProjectBTN_MouseLeave(object sender, EventArgs e)
        {
            bigProjectICON.BackColor = Color.FromArgb(34, 34, 34);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            FNAF_Engine_Game theGameTest = new FNAF_Engine_Game(this);
            theGameTest.Show();
            Text = "Sunset Creator - Testing Game";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                File.WriteAllText(projecto + "/game.txt", textBox6.Text);
            }
            else
            {

            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            _ = new FNAF_Engine_Game(this)
            {
                Text = textBox6.Text
            };
            textBox6.Text = textBox6.Text;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (comboBox43.SelectedItem == null)
                {
                    _ = MessageBox.Show("Select a animation!");
                }
                else
                {
                    Directory.Delete(comboBox43.SelectedItem.ToString());
                    _ = MessageBox.Show("Animation deleted!");
                    comboBox43.Items.Clear();
                    comboBox43.Items.AddRange(Directory.GetDirectories(projecto + "/animations/"));
                }
            }
            else
            {

            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            AnimAdd.Visible = true;
        }

        private void createSpritebtn_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                AnimAdd.Visible = false;
                if (spriteName.Text == "")
                {
                    _ = MessageBox.Show("Please insert something in the name box!");
                }
                else
                {
                    string animName = spriteName.Text;
                    _ = Directory.CreateDirectory(projecto + "/animations/" + animName);
                    comboBox43.Items.Clear();
                    comboBox43.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/animations/"));
                }
            }
            else
            {

            }
        }

        private void createProjectBTN_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Create Project";
            createProject projectMaker = new createProject();
            _ = projectMaker.ShowDialog();
        }

        private void loadProjectBTN_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Load Project";
            loadFERproject projectLoader = new loadFERproject();
            _ = projectLoader.ShowDialog();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator";
        }

        private void button66_Click(object sender, EventArgs e)
        {
            cutsceneMoment.Visible = true;
            menu.Hide();
        }

        private void playMusic(string musicS)
        {
            try
            {
                SoundPlayer music = new SoundPlayer("assets/music/" + musicS);
                music.Load();
                music.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void stopMusic(string music)
        {
            System.Media.SoundPlayer musicP = new System.Media.SoundPlayer(@"assets/music/" + music);
            musicP.Stop();
        }

        private void cutsceneMoment_VisibleChanged(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer(@"assets/music/fnaf_engine_reborn_credits.wav");
            music.Load();
            music.Play();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            load_editors(projecto); //calls function below
        }

        public void load_editors(string projec) // loads all the editors, public so "loadFERproject.cs" can access and call this function. :)
        {
            //label108.Size = new Size(74, 60);
            //REBORNtitle.Location = new Point(-55, 1);
            //REBORNtitle.Size = new Size(1000, 60);
            menu.Hide();
            editable = true;
            Text = "Sunset Creator";
            button38.Visible = true;
            //_ = projectloader.label3.Text;
            this.projecto = projec;
            if (showProject == true)
            {
                //this.presence.state = "Project: " + projecto;
                //DiscordRpc.UpdatePresence(ref this.presence);
            }
            else
            {
                //this.presence.state = "Version " + Version;
                //DiscordRpc.UpdatePresence(ref this.presence);
            }
            style = File.ReadAllText(v + "/style.txt");

        }

        public void j() //testing purposes
        {
            Console.WriteLine("testing purposes!");
        }

        private void AssetManagerPanel_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator";
        }

        private void ProjectStuffs_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator";
        }

        private void button75_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Show();
        }

        private void label108_Click(object sender, EventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://discord.gg/gGCdUpKDrW");
        }

        private void reborn_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator";
        }

        private void menuEditorPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                //comboBox9.Items.Clear();
                if (Directory.Exists(projecto + "/menus"))
                {
                    Menus.Nodes.Clear();
                    //comboBox9.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/menus"));
                    string[] dirs = Directory.GetDirectories(projecto + "/menus");
                    foreach (string node in dirs)
                    {
                        string Name = File.ReadAllText(node + "/name.txt");
                        TreeNode menu = new TreeNode
                        {
                            Name = "Menu",
                            Text = Name,
                            ImageIndex = 0,
                            Tag = node
                        };
                        _ = Menus.Nodes.Add(menu);

                        string[] texts = Directory.GetDirectories(projecto + "/menus/" + Name + "/text_elements");

                        foreach (string text in texts)
                        {
                            string element_name = File.ReadAllText(text + "/id.txt");
                            TreeNode element = new TreeNode
                            {
                                Name = "Text",
                                Text = element_name,
                                ImageIndex = 1,
                                SelectedImageIndex = 1
                            };
                            TreeNode[] Menus = this.Menus.Nodes.Find("Menu", true);
                            foreach (TreeNode Frame in Menus)
                            {
                                if (Frame.Tag.ToString() == node)
                                {
                                    Frame.Nodes.Add(element);
                                }
                            }
                        }
                    }
                }
                else
                {
                    _ = MessageBox.Show("Something went wrong! Fixing...");
                    createFolder(projecto + "/menus");
                    _ = MessageBox.Show("Fixed!");
                }
            }
            else
            {

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                createShit.Show();
            }
            else
            {

            }
        }

        private void minigameEditor_Click(object sender, EventArgs e)
        {
            MinigameMaker minigameMaker = new MinigameMaker();
            _ = minigameMaker.ShowDialog();
        }

        private void bigProjectICON_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Create Project";
            createProject projectMaker = new createProject();
            _ = projectMaker.ShowDialog();
        }

        private void bigFolderICON_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Load Project";
            loadFERproject projectLoader = new loadFERproject();
            _ = projectLoader.ShowDialog();
        }

        private void funTools_Click(object sender, EventArgs e)
        {
            templateCreator templateMaker = new templateCreator();
            _ = templateMaker.ShowDialog();
        }

        private void label87_Click(object sender, EventArgs e)
        {
            cutsceneMoment.Visible = true;
            menu.Hide();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            menu.Show();
            cutsceneMoment.Visible = false;
        }

        private void label98_Click(object sender, EventArgs e)
        {
            MinigameMaker minigameMaker = new MinigameMaker();
            _ = minigameMaker.ShowDialog();
        }

        private void toolC_Click(object sender, EventArgs e)
        {
            templateCreator templateMaker = new templateCreator();
            _ = templateMaker.ShowDialog();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Image = Image.FromFile(@"assets/images/johnBruh.png");
        }

        private void label166_Click(object sender, EventArgs e)
        {
            buildSettingsPanelMoment.BringToFront();
        }

        private void label165_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                if (usableEngine == true)
                {
                    //this.presence.details = "Editing game...";
                    //DiscordRpc.UpdatePresence(ref this.presence);
                    if (Directory.Exists(projecto + "/animations"))
                    {
                        //aight
                    }
                    else
                    {
                        //_ = MessageBox.Show("Something went wrong!");
                        //_ = Directory.CreateDirectory(projecto + "/animations");
                        //_ = MessageBox.Show("Fixed!");
                    }
                }
                else
                {

                }
                AssetManagerPanel.Show();
                AssetManagerPanel.BringToFront();
                buildSettingsPanelMoment.Show();
                SoundEditorPanel.Show();
                menuEditorPanel.Show();
                staticeffecteditor.Show();
                GameDebugMenu.Show();
                if (style == "standard")
                {
                    //officeEditorPanel.Show();
                    //cameraEditorPanel.Show();
                    //ExtensionsPanel.Show();
                    //animationEditorPanel.Show();
                    //cutsceneEditorPanel.Show();
                    //ScriptEditorPanel.Show();
                    //animatronicEditorPNL2.Show();
                }
                else
                {
                    officeEditorPanel.Show();
                    cameraEditorPanel.Show();
                    ExtensionsPanel.Show();
                    animationEditorPanel.Show();
                    cutsceneEditorPanel.Show();
                    ScriptEditorPanel.Show();
                    animatronicEditorPNL2.Show();
                }
            }
        }

        private void label163_Click(object sender, EventArgs e)
        {
            animatronicEditorPNL2.BringToFront();
            if (usableEngine == true)
            {
                if (Directory.Exists(projecto + "/animatronics"))
                {
                    //aight
                }
                else
                {
                    _ = MessageBox.Show("Something went wrong!");
                    _ = Directory.CreateDirectory(projecto + "/animatronics");
                    _ = MessageBox.Show("Fixed!");
                }
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Directory.GetDirectories(projecto + "/animatronics/normal"));
                comboBox1.Items.AddRange(Directory.GetDirectories(projecto + "/animatronics/phantom"));
            }
            else
            {

            }
        }

        private void label162_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (Directory.Exists(projecto + "/cameras"))
                {
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/cameras/"));
                    cameraEditorPanel.BringToFront();
                }
                else
                {
                    _ = MessageBox.Show("Something went wrong! Fixing...");
                    createFolder("/cameras");
                    comboBox4.Items.Clear();
                    _ = MessageBox.Show("Fixed!");
                    cameraEditorPanel.BringToFront();
                }
            }
            else
            {

            }
        }

        private void label164_Click(object sender, EventArgs e)
        {
            menuEditorPanel.BringToFront();
        }

        private void label161_Click(object sender, EventArgs e)
        {
            officeEditorPanel.BringToFront();
        }

        private void label160_Click(object sender, EventArgs e)
        {
            animationEditorPanel.BringToFront();
        }

        private void label158_Click(object sender, EventArgs e)
        {
            cutsceneEditorPanel.BringToFront();
        }

        private void label157_Click(object sender, EventArgs e)
        {
            MinigameMaker minigameMaker = new MinigameMaker();
            _ = minigameMaker.ShowDialog();
        }

        private void label159_Click(object sender, EventArgs e)
        {
            ScriptEditorPanel.BringToFront();
        }

        private void label156_Click(object sender, EventArgs e)
        {
            SoundEditorPanel.BringToFront();
        }

        private void label91_Click_1(object sender, EventArgs e)
        {
            ExtensionsPanel.BringToFront();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            extensionCreator extensionCreator = new extensionCreator();
            _ = extensionCreator.ShowDialog();
            Text = "Sunset Creator - Custom Extensions";
        }

        private void AssetManagerPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                comboBox36.Items.Clear();
                comboBox36.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/animations"));
            }
            else
            {

            }
            plocation.Text = "Project Location: " + projecto;
            pname.Text = "Project Name: " + File.ReadAllText(projecto + "/name.txt");
            try
            {
                ptemplate.Text = "Project Template: " + File.ReadAllText(projecto + "/template.txt");
            }
            catch (Exception)
            {
                File.WriteAllText(projecto + "/template.txt", "None");
                ptemplate.Text = "Project Template: " + File.ReadAllText(projecto + "/template.txt");
            }

            if (style == "standard")
            {
                comboBox63.Hide(); //animatronic
                comboBox62.Hide(); //office
                comboBox60.Hide(); //cameras
                comboBox58.Hide(); //minigame maker
                comboBox39.Hide(); //cutscenes
                comboBox38.Hide(); //script editor
                label163.Hide();
                label162.Hide();
                label161.Hide();
                label159.Hide();
                label158.Hide();
                label157.Hide();
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                _ = System.Diagnostics.Process.Start(projecto);
            }
            else
            {

            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (Directory.Exists(projecto))
                {
                    _ = System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath + projecto);
                }
                else
                {
                    _ = MessageBox.Show("Something went wrong!, Fixing...");
                    _ = MessageBox.Show("Fixed!");
                    _ = System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath + projecto);
                }
                try
                {
                    _ = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = projecto,
                        UseShellExecute = true,
                        Verb = "open"
                    });
                }
                catch (Exception oh)
                {
                    Console.WriteLine("cringe exception: " + oh);
                }
            }
            else
            {

            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
        }

        private void buildSettingsPanelMoment_VisibleChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                string optionstxt = File.ReadAllText(projecto + "/options.txt");
                string[] options = optionstxt.Split(',');
                _ = string.Join(",", options);
                if (File.Exists(projecto + "/options.txt"))
                {
                    checkBox8.Checked = options[0] == "fullscreen=true";
                    checkBox7.Checked = options[1] == "minigamesenabled=true";
                    checkBox10.Checked = options[2] == "watermarks=true";
                    checkBox9.Checked = options[3] == "sourcecode=true";
                }
                if (File.Exists(projecto + "/options.txt") == false)
                {
                    _ = MessageBox.Show("Something went wrong!, Fixing...");
                    _ = File.CreateText(projecto + "/options.txt");
                    _ = MessageBox.Show("Fixed!");
                }
                if (File.Exists(projecto + "/game.txt"))
                {
                    textBox6.Text = File.ReadAllText(projecto + "/game.txt");
                }
                if (File.Exists(projecto + "/game.txt") == false)
                {
                    _ = MessageBox.Show("Something went wrong!, Fixing...");
                    _ = File.CreateText(projecto + "/game.txt");
                    _ = MessageBox.Show("Fixed!");
                    textBox6.Text = File.ReadAllText(projecto + "/game.txt");
                }
                if (File.Exists(projecto + "/gameid.txt"))
                {
                    textBox5.Text = File.ReadAllText(projecto + "/gameid.txt");
                }
                if (File.Exists(projecto + "/gameid.txt") == false)
                {
                    _ = MessageBox.Show("Something went wrong!, Fixing...");
                    _ = File.CreateText(projecto + "/gameid.txt");
                    _ = MessageBox.Show("Fixed!");
                    textBox5.Text = File.ReadAllText(projecto + "/gameid.txt");
                }
                try
                {
                    label33.Image = Image.FromFile(projecto + "/images/icon.png");
                }
                catch (Exception)
                {
                    //uhm so you dont have the icon there, thats sad! letting the default one rn :)
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox8.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[0] = "fullscreen=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[0] = "fullscreen=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
            }
        }

        private void deleteProjectBTN_Click(object sender, EventArgs e)
        {
            Deleteproject deleteproject = new Deleteproject();
            _ = deleteproject.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (File.Exists(projecto + "/gameid.txt"))
                {
                    File.WriteAllText(projecto + "/gameid.txt", textBox5.Text);
                }
                else
                {
                    _ = MessageBox.Show("Something went wrong!, Fixing...");
                    _ = File.CreateText(project + "/gameid.txt");
                    _ = MessageBox.Show("Fixed!");
                    textBox5.Text = File.ReadAllText(projecto + "/gameid.txt");
                }
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(menuName.Text))
                    {
                        _ = MessageBox.Show("Please insert something in the box!");
                    }
                    else
                    {
                        string menuNam = menuName.Text;
                        _ = Directory.CreateDirectory(projecto + "/menus/" + menuNam);
                        _ = Directory.CreateDirectory(projecto + "/menus/" + menuNam + "/text_elements");
                        _ = Directory.CreateDirectory(projecto + "/menus/" + menuNam + "/variables");
                        File.WriteAllText(projecto + "/menus/" + menuNam + "/name.txt", menuNam);
                        File.WriteAllText(projecto + "/menus/" + menuNam + "/ongameloop.txt", "");
                        File.WriteAllText(projecto + "/menus/" + menuNam + "/onmenustart.txt", "");
                        Menus.Nodes.Clear();
                        createShit.Hide();
                        menuEditorPanel.Hide();
                        menuEditorPanel.Show();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cringe exception: " + ex);
                    _ = MessageBox.Show("Special characters aren't allowed!");
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (Menus.SelectedNode == null)
                {
                    _ = MessageBox.Show("Select an menu to delete!");
                }
                else
                {
                    DialogResult Confirmation = MessageBox.Show($"This can't be undone! Are you sure you want to delete the menu {Menus.SelectedNode.Text}?", "Menu Deletion", MessageBoxButtons.YesNo);

                    if (Confirmation == DialogResult.Yes)
                    {
                        Directory.Delete(Menus.SelectedNode.Tag.ToString(), true);
                        Menus.Refresh();
                        menuEditorPanel.Hide();
                        menuEditorPanel.Show();
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                comboBox4.Items.Clear();
                if (Directory.Exists(projecto + "/cameras"))
                {
                    panel6.Show();
                }
                else
                {
                    _ = MessageBox.Show("Something went wrong! Fixing...");
                    createFolder("/cameras");
                    _ = MessageBox.Show("Fixed!");
                    panel6.Show();
                }
            }
            else
            {

            }
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                string cameraName = textBox17.Text;
                _ = Directory.CreateDirectory(projecto + "/cameras/" + cameraName);
                panel6.Hide();
                comboBox4.Items.Clear();
                comboBox4.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/cameras"));
                _ = Directory.CreateDirectory(projecto + "/cameras/" + cameraName + "/animations");
                //_ = File.CreateText("settings.txt");
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (comboBox4.SelectedItem == null)
                {
                    _ = MessageBox.Show("Select an menu to delete!");
                }
                else
                {
                    Directory.Delete(comboBox4.SelectedItem.ToString());
                    _ = MessageBox.Show("Deleted camera!");
                    comboBox4.Items.Clear();
                    comboBox4.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/cameras"));
                }
            }
            else
            {

            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            comboBox43.Items.Clear();
            comboBox43.Items.AddRange(Directory.GetDirectories(projecto + "/animations/"));
            _ = MessageBox.Show("Updated!");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                _ = listView1.Items.Add("frame2");
            }
            else
            {

            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox13.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[3] = "camera=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[3] = "camera=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                panel7.Show();
            }
            else
            {

            }
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                string staticname = textBox20.Text;
                _ = Directory.CreateDirectory(projecto + "/statics" + staticname);
                AnimationList_StaticEffectEditor.Items.Clear();
                AnimationList_StaticEffectEditor.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/animations"));
                panel7.Hide();
            }
            else
            {

            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true)
            {
                DeleteFrameInfo_StaticEffectEditor.Show();
                StaticEffectEditor_addFrameInfo.Show();
                DeleteFrame_StaticEffectEditor.Show();
                AddFrame_StaticEffectEditor.Show();
                StaticEffectEditor_FrameList.Show();
            }
            else
            {
                DeleteFrameInfo_StaticEffectEditor.Hide();
                StaticEffectEditor_addFrameInfo.Hide();
                DeleteFrame_StaticEffectEditor.Hide();
                AddFrame_StaticEffectEditor.Hide();
                StaticEffectEditor_FrameList.Hide();
            }
        }

        private void label96_Click(object sender, EventArgs e)
        {
            staticeffecteditor.BringToFront();
        }

        private void button113_Click_1(object sender, EventArgs e)
        {
            if (Directory.Exists("assets/custom_assets/projects_cloud"))
            {

            }
        }

        private void exception(string ex)
        {
            throw new Exception(ex);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                panel8.Show();
            }
            else
            {

            }
        }

        private void button114_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                string animatronicName = textBox21.Text;
                try
                {
                    _ = Directory.CreateDirectory(projecto + "/animatronics/" + animatronicName);
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(Directory.GetDirectories(projecto + "/animatronics/normal/"));
                    comboBox1.Items.AddRange(Directory.GetDirectories(projecto + "/animatronics/phantom/"));
                    if (checkBox2.Checked == true)
                    {
                        File.WriteAllText(projecto + "/animatronics/phantom/" + animatronicName + "/options.txt", "ignoremask=false,audiolure=false,likebb=false");
                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {

            }
        }

        private void button115_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                comboBox57.Items.Clear();
                comboBox57.Items.AddRange(Directory.GetDirectories(projecto + "/statics"));
            }
            else
            {

            }
        }

        private void button110_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                try
                {
                    Directory.Delete(projecto + "/statics/" + comboBox57.SelectedItem.ToString());
                    comboBox57.Items.Clear();
                    comboBox57.Items.AddRange(Directory.GetDirectories(projecto + "/statics"));
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Error 3: Failed to delete static effect");
                }
            }
            else
            {

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {

                if (checkBox7.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[1] = "minigamesenabled=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[1] = "minigamesenabled=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox9.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[3] = "sourcecode=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[3] = "sourcecode=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox10.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[2] = "watermarks=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[2] = "watermarks=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                OpenFileDialog icon = new OpenFileDialog
                {
                    Filter = "Images (*.png)|*.png"
                };
                _ = icon.ShowDialog();
                if (icon.ShowDialog() == DialogResult.OK)
                {
                    string filePath = icon.FileName;
                    _ = icon.OpenFile();
                    System.IO.File.Copy(filePath, projecto + "/images/icon.png");
                    label33.Image = Image.FromFile(projecto + "/images/icon.png");
                }
            }
            else
            {

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox4.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[3] = "sourcecode=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/options.txt");
                    string[] options = optionstxt.Split(',');
                    options[3] = "sourcecode=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/options.txt", newoptions);
                }
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                Directory.Delete(comboBox1.SelectedItem.ToString());
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Directory.GetDirectories(projecto + "/animatronics/"));
            }
            else
            {

            }
        }

        private void s() //function to enter the manual, i couldn't find a good name lol
        {
            if (isopen == false)//checks if the manual is already open, theres a bool up in the code for determining that. if manual is closed, open, if manual is open, do nothing since i only want it to open 1 time
            {
                manual form = new manual(); //determining manual form
                isopen = true; //it now tells the engine that manual is open
                form.Show(); //show manual
            }
            else
            {
                //uh it's open so do nothing
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            s(); // call function above ^^^^!
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                if (usableEngine == true)
                {
                    Compiler compiler = new Compiler(this, style);
                    _ = compiler.ShowDialog();
                    //this.presence.details = "Compiling game...";
                    //DiscordRpc.UpdatePresence(ref this.presence);
                }
            }
        }

        private void label94_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                if (usableEngine == true)
                {
                    ReleaseOrDebug releaseordebug = new ReleaseOrDebug(this, style);
                    _ = releaseordebug.ShowDialog();
                    //this.presence.details = "Testing game...";
                    //DiscordRpc.UpdatePresence(ref this.presence);
                }
            }
        }

        private void button40_Click(object sender, EventArgs e) // add image
        {
            if (usableEngine == true)
            {
                OpenFileDialog p = new OpenFileDialog
                {
                    Filter = "Images (*.png)|*.png"
                };
                _ = p.ShowDialog();
                if (p.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = Path.GetFullPath(p.FileName);
                        string fileName = p.SafeFileName;
                        Import_Sprites.CreateSprite(filePath, fileName, projecto);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cringe exception: " + ex);
                        _ = MessageBox.Show("File already exists! If you want to overwrite it, select your image, delete it and insert again!");
                    }
                }
            }
            else
            {

            }
        }

        private void button39_Click(object sender, EventArgs e) // delete image
        {
        }

        private void button27_Click(object sender, EventArgs e) // add office state
        {
            panel9.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                string officename = textBox25.Text;
                try
                {
                    _ = System.IO.Directory.CreateDirectory(projecto + "/offices/default/office_states/" + officename);
                    panel9.Hide();
                    comboBox17.Items.Clear();
                    comboBox17.Items.AddRange(Directory.GetDirectories(projecto + "/offices/default/office_states/"));
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Special characters are not allowed!");
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                try
                {
                    if (comboBox17.SelectedItem.Equals(projecto + "/offices/default/office_states/Default")) // if default office state selected, can't delete!
                                                                                                             // this is meant to avoid errors.
                    {
                        //yeah do nothing
                    }
                    else
                    {
                        Directory.Delete(comboBox17.SelectedItem.ToString(), true);
                        comboBox17.Items.Clear();
                        comboBox17.Items.AddRange(Directory.GetDirectories(projecto + "/offices/default/office_states/"));
                        _ = MessageBox.Show("Office state deleted!");
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void button36_Click(object sender, EventArgs e) //set office state image
        {
            if (usableEngine == true)
            {
                if (comboBox17.SelectedItem == null)
                {

                }
                else
                {
                    try
                    {
                        OpenFileDialog p = new OpenFileDialog
                        {
                            Filter = "Images (*.png)|*.png"
                        };
                        _ = p.ShowDialog();
                        if (p.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = Path.GetFullPath(p.FileName);
                            string png = p.SafeFileName;
                            Import_Sprites.CreateSprite(filePath, png, projecto);
                            File.WriteAllText(comboBox17.SelectedItem.ToString() + "/mainsprite.txt", png);
                            officePreview.BackgroundImage = Image.FromFile(projecto + "/images/" + png);
                        }
                    }
                    catch (Exception)
                    {
                        //exception(ex.ToString());
                    }
                }
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e) //selected office state
        {
            if (usableEngine == true)
            {
                try
                {
                    string image = File.ReadAllText(comboBox17.SelectedItem.ToString() + "/mainsprite.txt");
                    officePreview.BackgroundImage = Image.FromFile(project + "/images/" + image);
                }
                catch (Exception)
                {
                    officePreview.BackgroundImage = null;
                }
            }
        }

        private void officeEditorPanel_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine(usableEngine);
            if (usableEngine == true)
            {
                Console.WriteLine(usableEngine);
                Sprite amagos = new Sprite(this)
                {
                    project = projecto
                };
                amagos.Intiate();
                CameraAnim_ComboBox.Items.Clear();
                CameraAnim_ComboBox.Items.AddRange(Directory.GetDirectories(projecto + "/animations/"));
                MaskAnim_ComboBox.Items.Clear();
                MaskAnim_ComboBox.Items.AddRange(Directory.GetDirectories(projecto + "/animations/"));
                PowerOutAnim_ComboBox.Items.Clear();
                PowerOutAnim_ComboBox.Items.AddRange(Directory.GetDirectories(projecto + "/animations/"));
                comboBox14.Items.Clear();
                comboBox14.Items.AddRange(Directory.GetDirectories(projecto + "/animatronics/phantom/"));
                comboBox17.Items.Clear();
                comboBox17.Items.AddRange(Directory.GetDirectories(projecto + "/offices/default/office_states/"));
                comboBox14.Items.Clear();
                comboBox14.Items.AddRange(Directory.GetDirectories(projecto + "/animatronics/normal/"));
                string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                string[] options = optionstxt.Split(',');
                if (File.Exists(projecto + "/offices/default/office.txt"))
                {
                    checkBox16.Checked = options[0] == "power=true";
                    checkBox12.Checked = options[1] == "toxic=true";
                    checkBox11.Checked = options[2] == "mask=true";
                    checkBox13.Checked = options[3] == "camera=true";
                    checkBox14.Checked = options[4] == "flashlight=true";
                    checkBox15.Checked = options[5] == "panorama=true";
                    checkBox24.Checked = options[6] == "perspective=true";
                    checkBox17.Checked = options[7] == "ucnstyle=true";
                    if (options[8] == "animatronic=")
                    {

                    }
                    else
                    {
                        _ = comboBox14.Controls.IndexOfKey(options[9]);
                    }
                }
                try
                {
                    //GetPreviewSprites(p.SafeFileName);
                }
                catch (Exception)
                {

                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                OpenFileDialog p = new OpenFileDialog
                {
                    Filter = "Images (*.png)|*.png"
                };
                _ = p.ShowDialog();
                if (p.ShowDialog() == DialogResult.OK)
                {
                    Sprite s = new Sprite(this)
                    {
                        project = projecto
                    };
                    s.Add(p.SafeFileName, p.FileName);
                    s.Intiate();
                }
            }
        }

        private void createProjectBTN_Click_1(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Create Project";
            createProject projectMaker = new createProject();
            _ = projectMaker.ShowDialog();
        }

        private void label170_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Create Project";
            createProject projectMaker = new createProject();
            _ = projectMaker.ShowDialog();
        }

        private void label171_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Create Project";
            createProject projectMaker = new createProject();
            _ = projectMaker.ShowDialog();
        }

        private void label153_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Load Project";
            loadFERproject projectLoader = new loadFERproject();
            _ = projectLoader.ShowDialog();
        }

        private void label154_Click(object sender, EventArgs e)
        {
            Text = "Sunset Creator - Load Project";
            loadFERproject projectLoader = new loadFERproject();
            _ = projectLoader.ShowDialog();
        }

        private void label168_Click(object sender, EventArgs e)
        {
            Deleteproject deleteproject = new Deleteproject();
            _ = deleteproject.ShowDialog();
        }

        private void label169_Click(object sender, EventArgs e)
        {
            Deleteproject deleteproject = new Deleteproject();
            _ = deleteproject.ShowDialog();
        }

        private void label155_Click(object sender, EventArgs e)
        {
            templateCreator templateMaker = new templateCreator();
            _ = templateMaker.ShowDialog();
        }

        private void label167_Click(object sender, EventArgs e)
        {
            templateCreator templateMaker = new templateCreator();
            _ = templateMaker.ShowDialog();
        }

        private void label172_Click(object sender, EventArgs e)
        {
            cutsceneMoment.Visible = true;
            menu.Hide();
        }

        private void label173_Click(object sender, EventArgs e)
        {
            cutsceneMoment.Visible = true;
            menu.Hide();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox16.Checked == true)
                {
                    textBox7.Show();
                    powerPercentage_label.Show();
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[0] = "power=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    textBox7.Hide();
                    powerPercentage_label.Hide();
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[0] = "power=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (comboBox17.SelectedItem == null)
            {

            }
            else
            {
                CreateDoorButton_OfficeEditor.Hide();
                CreateLightButton_OfficeEditor.Hide();
                button30.Hide();
                button33.Hide();
                CreatePanel_OfficeEditor.Hide();
                button37.Show();
                comboBox65.Show();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            CreateDoorButton_OfficeEditor.Show();
            CreateLightButton_OfficeEditor.Show();
            button30.Show();
            button33.Show();
            CreatePanel_OfficeEditor.Show();
            button37.Hide();
            comboBox65.Hide();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox17.Checked == true)
                {
                    displayOfficeEditorInfoAnimatronicKill.Hide();
                    comboBox14.Hide();
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[7] = "ucnstyle=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    displayOfficeEditorInfoAnimatronicKill.Show();
                    comboBox14.Show();
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[7] = "ucnstyle=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox12.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[1] = "toxic=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[1] = "toxic=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox11.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[2] = "mask=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[2] = "mask=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox14.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[4] = "flashlight=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[4] = "flashlight=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox15.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[5] = "panorama=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[5] = "panorama=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (checkBox24.Checked == true)
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[6] = "perspective=true";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[6] = "perspective=false";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Thread.Sleep(10000);
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                textBox7.Text = "0";
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                if (comboBox14.SelectedItem == null)
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[8] = "animatronic=,";
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
                else
                {
                    string optionstxt = File.ReadAllText(projecto + "/offices/default/office.txt");
                    string[] options = optionstxt.Split(',');
                    options[8] = "animatronic=," + comboBox14.Text;
                    string newoptions = string.Join(",", options);
                    File.WriteAllText(projecto + "/offices/default/office.txt", newoptions);
                }
            }
        }

        private void Code()
        {

        }
        private void label39_VisibleChanged(object sender, EventArgs e)
        {
            Code();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Code();
        }

        private void Offices_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Menus.SelectedNode.Name == "Text")
            {

            }
            else
            {
                Menu_Name_MenuCodeEditor_InfoLBL.Text = (string)Menus.SelectedNode.Tag;
                Menu_Editor menu_Editor = new Menu_Editor(this)
                {
                    Menu = (string)Menus.SelectedNode.Tag
                };
                MenuPreview.Controls.Clear();
                Menu_Elements_Create.Show();
                menu_Editor.RefreshText(Menus.SelectedNode.Tag.ToString());
                if (File.Exists(Menus.SelectedNode.Tag.ToString() + "/bg.txt"))
                {
                    try
                    {
                        MenuPreview.BackgroundImage = Image.FromFile(projecto + "/images/" + File.ReadAllText(Menus.SelectedNode.Tag.ToString() + "/bg.txt"));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to load menu background: Invalid Image", "Corrupted Image");
                    }
                }
                else
                {
                    MenuPreview.BackgroundImage = null;
                }
            }
        }

        private void label119_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                GameDebugMenu.BringToFront();
                //this.presence.details = "Debugging game...";
                //DiscordRpc.UpdatePresence(ref this.presence);
            }
        }

        private void staticeffecteditor_VisibleChanged(object sender, EventArgs e)
        {
            AnimationList_StaticEffectEditor.Items.Clear();
            AnimationList_StaticEffectEditor.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/animations"));
        }

        private void panel4_VisibleChanged(object sender, EventArgs e)
        {
            _ = ScriptEditor_Scripts_ComboBox.SelectedItem.ToString();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            PanelCreatingNewScript.Show();
        }

        private void CreateScript_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                string Name = ScriptEditor_TextBoxname.Text;
                ScriptEditor scriptEditor = new ScriptEditor
                {
                    Project = projecto
                };
                scriptEditor.CreateScript(Name);
                ScriptEditor_Scripts_ComboBox.Items.Clear();
                ScriptEditor_Scripts_ComboBox.Items.AddRange(Directory.GetDirectories(projecto + "/scripts/visual/"));
                PanelCreatingNewScript.Hide();
            }
        }

        private void ScriptEditorPanel_VisibleChanged(object sender, EventArgs e)
        {
            ScriptEditor_Scripts_ComboBox.Items.Clear();
            ScriptEditor_Scripts_ComboBox.Items.AddRange(Directory.GetDirectories(projecto + "/scripts/visual/"));
        }
        private void GetEvent()
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                string script = ScriptEditor_Scripts_ComboBox.SelectedItem.ToString();
                ScriptEditor scripteditor = new ScriptEditor();
                panel4.Show();
                if (File.Exists(script + "/event.txt"))
                {
                    if (scripteditor.HasEvent(script))
                    {
                        string event_ = scripteditor.ToEvent(script);
                        button25.Show();
                        button25.Text = event_;
                        button26.Show();
                    }
                    else
                    {
                        button25.Hide();
                        button26.Hide();
                        button10.Show();
                    }
                }
                else
                {
                    button25.Hide();
                    button26.Hide();
                    button10.Show();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                script = ScriptEditor_Scripts_ComboBox.SelectedItem.ToString();
                CodeblockSelector selector = new CodeblockSelector(this);
                _ = selector.ShowDialog();
            }
        }

        private void button25_MouseClick(object sender, MouseEventArgs e)
        {
            if (usableEngine == true)
            {
                if (e.Button == MouseButtons.Right)
                {
                    CodeblockSelector codeblockselector = new CodeblockSelector(this)
                    {
                        Path = ScriptEditor_Scripts_ComboBox.SelectedItem.ToString()
                    };
                    _ = codeblockselector.ShowDialog();
                }
            }
        }

        private void create_text_menuEditorBTN_Click(object sender, EventArgs e)
        {
            Menu_Editor menu_Editor = new Menu_Editor(this)
            {
                Menu = projecto + "/menus/" + text_ID_MenuEditor_Create
            };
            if (Directory.Exists(projecto + "/menus/" + text_ID_MenuEditor_Create))
            {
                _ = MessageBox.Show("Unable to create new text element: Error 1");
            }
            else
            {
                string id = text_ID_MenuEditor_Create.Text;
                menu_Editor.CreateText(id, Menu_Name_MenuCodeEditor_InfoLBL.Text);
                //menu_Editor.RefreshText(Menus.SelectedNode.Name.ToString());
                textCreate_MenuEditor.Hide();
                menuEditorPanel.Hide();
                menuEditorPanel.Show();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                script = ScriptEditor_Scripts_ComboBox.SelectedItem.ToString();
                CodeblockSelector selector = new CodeblockSelector(this);
                _ = selector.ShowDialog();
            }
        }

        private void button125_Click(object sender, EventArgs e)
        {
            textCreate_MenuEditor.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (usableEngine == true)
            {
                OpenFileDialog p = new OpenFileDialog
                {
                    Filter = "Images (*.png)|*.png"
                };
                _ = p.ShowDialog();
                if (p.ShowDialog() == DialogResult.OK)
                {
                    string FileName = p.SafeFileName;
                    Import_Sprites.CreateSprite(p.FileName, FileName, projecto);
                    File.WriteAllText(Menus.SelectedNode.Tag.ToString() + "/bg.txt", FileName);
                    MenuPreview.BackgroundImage = Image.FromFile(projecto + "/images/" + File.ReadAllText(Menus.SelectedNode.Tag.ToString() + "/bg.txt"));
                }
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cutsceneMoment_VisibleChanged_1(object sender, EventArgs e)
        {

        }

        private void animationEditorPanel_VisibleChanged(object sender, EventArgs e)
        {
            comboBox43.Items.Clear();
            comboBox43.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/animations/"));
        }

        private void GameManager_Variables_View_VisibleChanged(object sender, EventArgs e)
        {
            DataValues.Project = projecto;
            DataValues.Engine = this;
            DataValues.RefreshDataValues();
        }

        private void addDataValue_GameManager_Click(object sender, EventArgs e)
        {
            if (DataValue_Name.Visible == false)
            {
                DataValue_Name.Show();
            }
            else
            {
                DataValues.CreateDataValue(DataValue_Name.Text);
                DataValues.RefreshDataValues();
                DataValue_Name.Hide();
            }
        }

        private void reassignDataValue_GameManager_Click(object sender, EventArgs e)
        {
            if (reassign_Value_GameManager_Textbox.Visible == false)
            {
                object tag = "Data_Values_List";
                if (GameManager_Variables_View.SelectedNode == null || GameManager_Variables_View.SelectedNode.Tag == tag || GameManager_Variables_View.SelectedNode.Name == "value")
                {
                    _ = MessageBox.Show("Please select a data value to change the value!");
                }
                else
                {
                    reassign_Value_GameManager_Textbox.Show();
                }
            }
            else
            {
                string DataValue = GameManager_Variables_View.SelectedNode.Name;
                string Value = reassign_Value_GameManager_Textbox.Text;
                DataValues.ReassignDataValue(DataValue, Value);
                DataValues.RefreshDataValues();
                reassign_Value_GameManager_Textbox.Hide();
            }
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GameDebugMenu_VisibleChanged(object sender, EventArgs e)
        {
            DataValuesFileLabel.Draggable(true);
            DataValuesFileLabel.Text = File.ReadAllText(projecto + "/data.txt");
        }

        private void MenuEditor_ScriptEditor_Click(object sender, EventArgs e)
        {
            Menu_CodeEditor.Show();
        }

        private void X_Leave_MenuCodeEditor_Click(object sender, EventArgs e)
        {
            Menu_CodeEditor.Hide();
        }

        private void MenuStart_CodeEditor_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(projecto + "/menus/" + Menu_Name_MenuCodeEditor_InfoLBL.Text + "/onmenustart.txt", MenuStart_CodeEditor.Text);
        }

        private void OnGameLoop_MenuEditor_CodeEditor_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(projecto + "/menus/" + Menu_Name_MenuCodeEditor_InfoLBL.Text + "/ongameloop.txt", OnGameLoop_MenuEditor_CodeEditor.Text);
        }

        private void Menu_CodeEditor_VisibleChanged(object sender, EventArgs e)
        {
            if (Menus.SelectedNode == null)
            {
                Menu_CodeEditor.Hide();
            }
            else
            {
                Menu_Name_MenuCodeEditor_InfoLBL.Text = Menus.SelectedNode.Text;
            }

            try
            {
                MenuStart_CodeEditor.Text = File.ReadAllText(projecto + "/menus/" + Menu_Name_MenuCodeEditor_InfoLBL.Text + "/onmenustart.txt");
                OnGameLoop_MenuEditor_CodeEditor.Text = File.ReadAllText(projecto + "/menus/" + Menu_Name_MenuCodeEditor_InfoLBL.Text + "/ongameloop.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Warning: This project is unsupported with the newer versions of FNAF Engine: Reborn! Do you wish to create the needed files?", "Unsupported Version", MessageBoxButtons.YesNo);
            }
        }

        private void DownloadFontBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://cdn.discordapp.com/attachments/966684909739601952/1001816335837315082/digital-7.ttf");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Code_MenuEditor_GroupBox.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                if (usableEngine == true)
                {
                    //this.presence.details = "Editing game...";
                    //DiscordRpc.UpdatePresence(ref this.presence);
                    if (Directory.Exists(projecto + "/animations"))
                    {
                        //aight
                    }
                    else
                    {
                        //_ = MessageBox.Show("Something went wrong!");
                        //_ = Directory.CreateDirectory(projecto + "/animations");
                        //_ = MessageBox.Show("Fixed!");
                    }
                }
                else
                {

                }
                AssetManagerPanel.Show();
                AssetManagerPanel.BringToFront();
                buildSettingsPanelMoment.Show();
                SoundEditorPanel.Show();
                menuEditorPanel.Show();
                staticeffecteditor.Show();
                GameDebugMenu.Show();
                if (style == "standard")
                {
                    //officeEditorPanel.Show();
                    //cameraEditorPanel.Show();
                    //ExtensionsPanel.Show();
                    //animationEditorPanel.Show();
                    //cutsceneEditorPanel.Show();
                    //ScriptEditorPanel.Show();
                    //animatronicEditorPNL2.Show();
                }
                else
                {
                    officeEditorPanel.Show();
                    cameraEditorPanel.Show();
                    ExtensionsPanel.Show();
                    animationEditorPanel.Show();
                    cutsceneEditorPanel.Show();
                    ScriptEditorPanel.Show();
                    animatronicEditorPNL2.Show();
                }
            }
        }

        private void label124_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                GameDebugMenu.BringToFront();
                //this.presence.details = "Debugging game...";
                //DiscordRpc.UpdatePresence(ref this.presence);
            }
        }

        private void label143_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                if (usableEngine == true)
                {
                    ReleaseOrDebug releaseordebug = new ReleaseOrDebug(this, style);
                    _ = releaseordebug.ShowDialog();
                    //this.presence.details = "Testing game...";
                    //DiscordRpc.UpdatePresence(ref this.presence);
                }
            }
        }

        private void label83_Click(object sender, EventArgs e)
        {
            if (editable == true)
            {
                if (usableEngine == true)
                {
                    Compiler compiler = new Compiler(this, style);
                    _ = compiler.ShowDialog();
                    //this.presence.details = "Compiling game...";
                    //DiscordRpc.UpdatePresence(ref this.presence);
                }
            }
        }

        private async void REBORNtitle_Click(object sender, EventArgs e)
        {
            REBORNtitle.Image = Properties.Resources.Sunset_Creator_old;
            await Task.Delay(30);
            REBORNtitle.Image = Properties.Resources.Sunset_Creator;
        }
    }
}
