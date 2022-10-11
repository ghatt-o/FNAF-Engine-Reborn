using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_Engine_Game
{
    public partial class FNAF_Engine_Game : Form
    {
        //private readonly reborn reborn;
        private string project;
        string curMenu;
        bool open = true;
        bool inNight;
        int CurrentHour;
        int curNight;
        int time = 0;

        public FNAF_Engine_Game(object key/*reborn reborn*/)
        {
            this.Dock = DockStyle.Fill;
            //this.reborn = reborn;
            //project = reborn.projecto;
            InitializeComponent();
        }

        private async void FNAF_Engine_Game_VisibleChanged(object sender, EventArgs e)
        {
            while (true)
            {
                await Task.Delay(1);
                curNight = Convert.ToInt32(File.ReadAllText(project + "/data.txt").Split(':')[1].Split(',')[0]);
            }
        }

        private async void FNAF_Engine_Game_Load_1(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Refresh();
            //project = reborn.projecto;
            Load_Game();
            try
            {
                this.Controls["Main"].BringToFront();
            }
            catch (Exception)
            {

            }
        }
        private void Load_Game()
        {
            this.Text = File.ReadAllText(project + "/game.txt");
            if (File.ReadAllText(project + "/options.txt").StartsWith("fullscreen=false"))
            {
                this.MaximizeBox = true;
                this.Size = new Size(1280, 720);
                this.FormBorderStyle = FormBorderStyle.Sizable;
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNAF_Engine_Game));
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            }
            Load_Menus();
        }

        private async void Load_Menus()
        {
            string[] menus = Directory.GetDirectories(project + "/menus/");
            foreach (string Menu in menus)
            {
                string MenuName = File.ReadAllText(Menu + "/name.txt");

                Panel menu_panel = new Panel
                {
                    Size = Size,
                    Name = MenuName,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackColor = Color.Black
                };

                try
                {
                    await Task.Delay(100);
                    menu_panel.BackgroundImage = Image.FromFile(project + "/images/" + File.ReadAllText(project + $"/menus/{menu_panel.Name}/bg.txt"));
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"Failed to load menu {menu_panel.Name} image: Image file not found");
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine($"Failed to load menu {menu_panel.Name} image: Bad file");
                }

                menu_panel.Visible = false;

                menu_panel.Controls.Clear();

                this.Controls.Add(menu_panel);

                if (MenuName == "Main")
                {
                    menu_panel.Tag = 1;
                    menu_panel.BringToFront();
                }

                menu_panel.VisibleChanged += Menu_Load;

                menu_panel.Visible = true;

                menu_panel.Paint += Menu_Start;

                async void Menu_Start(object sender, EventArgs e)
                {
                    //SCRIPTS!
                    #region
                    string[] instructions = { };
                    string instructions_loop = "";

                    //ON MENU START
                    try
                    {
                        instructions = File.ReadAllLines(project + "/menus/" + MenuName + "/onmenustart.txt");
                    }
                    catch (Exception)
                    {

                    }

                    foreach (string instruction in instructions)
                    {
                        string Condition = instruction;

                        if (Condition.StartsWith("*"))
                        {
                            //IF CONDITIONS

                            if (Condition.StartsWith("*If ("))
                            {
                                if (Condition.StartsWith("*If ()")) // If() Do
                                {
                                    continue;
                                }
                                //No key conditions because you can't press/hold a key on menu START.
                            }

                            //IF NOT CONDITIONS

                            if (Condition.StartsWith("*If not"))
                            {
                                if (Condition.StartsWith("*If not ()")) // If not() Do
                                {

                                }
                            }
                        }
                        else
                        {
                            RunStandardScript(Condition);
                        }
                    }

                    //ON GAME LOOP

                    try
                    {
                        instructions_loop = File.ReadAllText(project + "/menus/" + MenuName + "/ongameloop.txt");
                    }
                    catch (Exception)
                    {

                    }
                    while (menu_panel.Tag == (object)1)
                    {
                        await Task.Delay(1);
                        string[] Lines2 = instructions_loop.Split('*');
                        var Condition2 = Lines2[0].Split('\n')[0];
                        Lines2.SetValue("", 0);

                        //IF CONDITIONS

                        if (Condition2.StartsWith("If ("))
                        {
                            if (Condition2.StartsWith("If ()")) // If() Do
                            {
                                foreach (string line2 in Lines2)
                                {
                                    RunStandardScript(line2);
                                }
                            }
                        }

                        //IF NOT CONDITIONS

                        if (Condition2.StartsWith("If not"))
                        {
                            if (Condition2.StartsWith("If not ()")) // If not() Do
                            {
                                foreach (string line2 in Lines2)
                                {
                                    RunStandardScript(line2);
                                }
                            }
                        }
                    }
                    #endregion
                }

                void Menu_Load(object sender, EventArgs e)
                {
                    try
                    {
                        //System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(File.ReadAllText(project + "/menus/" + MenuName + "/audio.txt"));
                        //while (true)
                        //{
                        //    await Task.Delay(1);
                        //}
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Could not play " + MenuName + "'s background audio.");
                    }
                    string[] texts = Directory.GetDirectories(project + $"/menus/{MenuName}/text_elements/");
                    string[] images = Directory.GetDirectories(project + $"/menus/{MenuName}/image_elements/");
                    menu_panel.Controls.Clear();
                    foreach (string text in texts)
                    {
                        string args = File.ReadAllText(text + "/args.txt");
                        if (args == "False")
                        {

                            Label Text = new Label();

                            menu_panel.Controls.Add(Text);

                            menu_panel.Show();

                            string Path = text;
                            double X = Convert.ToInt32(File.ReadAllText(Path + "/x.txt"));
                            double Y = Convert.ToInt32(File.ReadAllText(Path + "/y.txt"));
                            //X
                            /*
                            if (X < 190)
                            {
                                X += 70;
                            }
                            else if (X >= 190 && X < 285)
                            {
                                X += 400;
                            }
                            else if (X >= 285)
                            {
                                X += 650;
                            }
                            //Y
                            if (Y < 111)
                            {
                                Y += 50;
                            }
                            else if (Y >= 111 && Y < 165)
                            {
                                Y += 250;
                            }
                            else if (Y >= 165)
                            {
                                Y += 470;
                            }
                            */
                            X = X * 2.13333333;
                            Y = Y * 2.13649852;
                            string xS = X.ToString();
                            string yS = Y.ToString();
                            if (xS.Contains(".5") || xS.Contains(".6") || xS.Contains(".7") || xS.Contains(".8") || xS.Contains(".9")) X += 0.4;
                            if (yS.Contains(".5") || yS.Contains(".6") || yS.Contains(".7") || yS.Contains(".8") || yS.Contains(".9")) Y += 0.4;
                            string TXTText = File.ReadAllText(Path + "/text.txt");
                            string ID = File.ReadAllText(Path + "/id.txt");

                            string fontname = File.ReadAllText(Path + "/font.txt");
                            string fontsize_string = File.ReadAllText(Path + "/fontsize.txt");

                            int fontsize = Convert.ToInt32(fontsize_string) + 20;

                            FontFamily fontfamily;

                            try
                            {
                                fontfamily = new FontFamily(fontname);
                            }
                            catch (Exception)
                            {
                                fontfamily = new FontFamily("Microsoft Sans Serif");
                            }

                            Font font = new Font(fontfamily, fontsize, FontStyle.Regular);

                            string RGBtxt = File.ReadAllText(Path + "/color.txt");

                            string[] SeparatedRGB = RGBtxt.Split(',');

                            int R = Convert.ToInt32(SeparatedRGB[0]);
                            int G = Convert.ToInt32(SeparatedRGB[1]);
                            int B = Convert.ToInt32(SeparatedRGB[2]);

                            Text.Location = new Point((int)X, (int)Y);
                            Text.AutoSize = true;
                            Text.BackColor = Color.Transparent;
                            Text.FlatStyle = FlatStyle.Flat;
                            Text.ForeColor = Color.FromArgb(R, G, B);
                            Text.Font = new Font(font, FontStyle.Regular);
                            Text.Text = TXTText;
                            Text.Name = ID;

                            Text.Click += Element_Click;
                            Text.MouseEnter += Element_Hover;
                            Text.MouseLeave += Element_Unhover;
                            Text.MouseDown += Element_Hold;

                            void Element_Click(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functions.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                            void Element_Hover(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functionshover.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                            void Element_Unhover(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functionsunhover.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                            void Element_Hold(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functionshold.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                        }
                    }
                    foreach (string image in images)
                    {
                        string args = File.ReadAllText(image + "/args.txt");
                        if (args == "False")
                        {

                            PictureBox Sprite = new PictureBox();

                            menu_panel.Controls.Add(Sprite);

                            menu_panel.Show();

                            string Path = image;
                            int X = Convert.ToInt32(File.ReadAllText(Path + "/x.txt"));
                            int Y = Convert.ToInt32(File.ReadAllText(Path + "/y.txt"));
                            //X
                            if (X < 190)
                            {
                                X += 70;
                            }
                            else if (X >= 190 && X < 285)
                            {
                                X += 400;
                            }
                            else if (X >= 285)
                            {
                                X += 650;
                            }
                            //Y
                            if (Y < 111)
                            {
                                Y += 50;
                            }
                            else if (Y >= 111 && Y < 165)
                            {
                                Y += 250;
                            }
                            else if (Y >= 165)
                            {
                                Y += 470;
                            }
                            string ID = File.ReadAllText(Path + "/id.txt");

                            Sprite.Location = new Point(X, Y);
                            Sprite.Size = Image.FromFile(project + "/images/" + ID).Size;
                            Sprite.BackColor = Color.Transparent;
                            Sprite.BackgroundImageLayout = ImageLayout.None;
                            Sprite.BackgroundImage = Image.FromFile(project + "/images/" + ID);
                            Sprite.Name = ID;

                            Sprite.Click += Element_Click;
                            Sprite.MouseEnter += Element_Hover;
                            Sprite.MouseLeave += Element_Unhover;
                            Sprite.MouseDown += Element_Hold;

                            void Element_Click(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functions.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                            void Element_Hover(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functionshover.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                            void Element_Unhover(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functionsunhover.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                            void Element_Hold(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functionshold.txt");
                                foreach (string instruction in functions)
                                {
                                    RunStandardScript(instruction);
                                }
                            }
                        }
                    }
                    MF_OnEngineStart();
                }
                async void RunScript(string[] file)
                {

                }
                async void RunStandardScript(string instruction)
                {
                    await RunCode();
                    async Task RunCode()
                    {
                        await Task.Delay(1);
                        if (time == 0)
                        {
                            //Console.WriteLine($"{time}");
                        }
                        else if (time > 0)
                        {
                            await Task.Delay(time);
                            time = 0;
                        }
                    }

                    if (instruction.StartsWith("Goto Menu ")) //Goto Menu "menu"
                    {
                        await RunCode();
                        MF_GotoMenu(instruction.Split('"')[1]);
                    }

                    if (instruction.StartsWith("Start Night ")) //Start Night "0"
                    {
                        await RunCode();
                        MF_NightStart(1);
                    }

                    if (instruction == "New Game")
                    {
                        await RunCode();
                        MF_NewGame();
                    }

                    if (instruction == "Continue")
                    {
                        await RunCode();
                        //todo
                    }

                    if (instruction.StartsWith("Error ")) //Error "error"
                    {
                        await RunCode();
                        MF_CustomError(instruction.Split('"')[1]);
                    }

                    if (instruction.StartsWith("Popup ")) //Popup "my popup desc"
                    {
                        await RunCode();
                        MF_Popup(instruction.Split('"')[1]);
                    }

                    if (instruction.StartsWith("Set Variable ")) //Set Variable "varname" to "varvalue"
                    {
                        await RunCode();
                        try
                        {
                            string[] instructions = instruction.Split('"');
                            Directory.CreateDirectory(project + "/menus/" + MenuName + "/variables/" + instructions[1]);
                            File.WriteAllText(project + "/menus/" + MenuName + "/variables/" + instructions[1], instructions[3]);
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to set variable", "Failed to set variable: '" + instruction.Split('"')[1] + "', Original code: " + instruction);
                        }
                    }

                    if (instruction == "Break")
                    {
                        await RunCode();
                        MF_Break();
                    }

                    if (instruction.StartsWith("If (")) // If ("myfuckingvariable" = "1") Do []
                    {
                        await RunCode();
                        try
                        {
                            string param = instruction.Split(' ')[3];
                            string value = instruction.Split('"')[3];
                            string block = instruction.Split('[', ']')[1];
                            string variable = instruction.Split('"')[1];
                            switch (param)
                            {
                                case "=":
                                    if (File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable) == value)
                                    {
                                        RunStandardScript(block);
                                    }
                                    break;
                                case "<":
                                    if (Convert.ToInt32(File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable)) < Convert.ToInt32(value))
                                    {
                                        RunStandardScript(block);
                                    }
                                    break;
                                case "<=":
                                    if (Convert.ToInt32(File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable)) <= Convert.ToInt32(value))
                                    {
                                        RunStandardScript(block);
                                    }
                                    break;
                                case ">":
                                    if (Convert.ToInt32(File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable)) > Convert.ToInt32(value))
                                    {
                                        RunStandardScript(block);
                                    }
                                    break;
                                case ">=":
                                    if (Convert.ToInt32(File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable)) >= Convert.ToInt32(value))
                                    {
                                        RunStandardScript(block);
                                    }
                                    break;
                                case "<>":
                                    if (File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable) != value || File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable) == null)
                                    {
                                        RunStandardScript(block);
                                    }
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to parse in if statement", "Couldn't parse in if statement. Original code: " + instruction);
                        }
                    }

                    if (instruction == "Quit")
                    {
                        await RunCode();
                        this.Close();
                    }

                    if (instruction.StartsWith("Wait ")) // Wait 1000
                    {
                        await RunCode();
                        time = Convert.ToInt32(instruction.Split(' ')[1]);
                    }

                    if (instruction.StartsWith("Set Text ")) //Set Text "TEXT" to "text"
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(' ');
                        try
                        {
                            string TextName = instruction.Split('"')[1];
                            if (instruction.Split('"')[1].Contains("%var(") || instructions[2].Contains("%data("))
                            {
                                //not done yet
                                string variable_args = instructions[2].Split('%')[1];
                                string variable = variable_args.Split('(', ')')[1];

                                menu_panel.Controls[instructions[1]].Text = File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable);
                            }
                            else
                            {
                                string Value = instruction.Split('"')[3];
                                menu_panel.Controls[TextName].Text = Value; //the text value
                            }
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to change text", "Failed to change text. Original code: " + instruction);
                        }
                    }

                    if (instruction.StartsWith("Change Text ")) // Change Text "text" Font to "Consolas"
                    {
                        await RunCode();
                        string[] instructions = instruction.Split('"');
                        try
                        {
                            menu_panel.Controls[instructions[1]].Font = new Font(instructions[3], Convert.ToInt32(instructions[3]) + 22); //the text value
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to change font", "Failed to change text font. Original code: " + instruction + "! You might've inputted a wrong font.");
                        }
                    }

                    if (instruction.StartsWith("Recolor Text ")) //Recolor Text "text" to "255,255,255"
                    {
                        await RunCode();
                        string[] instructions = instruction.Split('"');
                        int argsR = Convert.ToInt32(instructions[3].Split(',')[0]);
                        int argsG = Convert.ToInt32(instructions[3].Split(',')[1]);
                        int argsB = Convert.ToInt32(instructions[3].Split(',')[2]);
                        try
                        {
                            menu_panel.Controls[instructions[1]].ForeColor = Color.FromArgb(argsR, argsG, argsB); //the text value
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to change color", "Failed to change text color. Original code: " + instruction);
                        }
                    }

                    if (instruction.StartsWith("Hide Element ")) //Hide Element "text"
                    {
                        await RunCode();
                        string[] instructions = instruction.Split('"');
                        try
                        {
                            menu_panel.Controls[instructions[1]].Hide(); //the element
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to hide element: " + menu_panel.Controls[instructions[1]].Name, "Failed to hide element. Original code: " + instruction);
                        }
                    }

                    if (instruction.StartsWith("Show Element ")) //Show Element "text"
                    {
                        await RunCode();
                        string[] instructions = instruction.Split('"');
                        try
                        {
                            menu_panel.Controls[instructions[1]].Show(); //the element
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to show element: " + menu_panel.Controls[instructions[1]].Name, "Failed to show element. Original code: " + instruction);
                        }
                    }

                    if (instruction.StartsWith("Set Background to ")) //Set Background to "myimage.png"
                    {
                        await RunCode();
                        string[] instructions = instruction.Split('"');
                        try
                        {
                            menu_panel.BackgroundImage = Image.FromFile(project + "/images/" + instructions[1]);
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to change background to: " + instructions[1], "Failed to change background. Original code: " + instruction);
                        }
                    }

                    if (instruction.StartsWith("Set Sprite ")) //Set Sprite "myimage.png" image to "otherimage.png"
                    {
                        await RunCode();
                        string[] instructions = instruction.Split('"');
                        try
                        {
                            menu_panel.Controls[instructions[1]].BackgroundImage = Image.FromFile(project + "/images/" + instructions[3]);
                        }
                        catch (Exception)
                        {
                            MF_Error("Failed to change sprite: " + instructions[1] + "'s image to " + instructions[2], "Failed to change sprite. Original code: " + instruction);
                        }
                    }

                    if (instruction == "Run Script")
                    {
                        await RunCode();
                        RunStandardScript(instruction);
                    }

                }
            }
        }

        private void MF_NewGame()
        {
            MF_NightStart(1);
        }

        private void MF_NightStart(int night)
        {
            Console.WriteLine("Night " + night);
            Night_Start.Show();
            Night_Start.BringToFront();
            nightLBL.Text = "Night " + night;
        }

        private async void Night_Start_VisibleChanged(object sender, EventArgs e)
        {
            if (Night_Start.Visible == true)
            {
                await Task.Delay(45);
                Invisible.Show();
                label1.Hide();
                label2.Hide();
                await Task.Delay(35);
                Invisible.Hide();
                await Task.Delay(15);
                label3.Hide();
                await Task.Delay(2700);
                nightLBL.Hide();
                TwelveAM.Hide();
                MF_OnNightStart();
            }
        }
        private async void MF_OnNightStart()
        {
            MF_ChangeOfficeState("Default");
            await Task.Delay(1500);
            Office.Show();
            Office.BringToFront();
            inNight = true;
            CurrentHour = Convert.ToInt32(File.ReadAllText(project + "/offices/default/office.txt").Split(',')[9].Split('=')[1]);
            //while (inNight == true)
            //{
            //await Task.Delay(1);
            MF_GameUpdate();
            //}
        }
        private async void MF_GameUpdate()
        {
            //clock.Text = CurrentHour + " AM";
            //time
            int hours = Convert.ToInt32(File.ReadAllText(project + "/offices/default/office.txt").Split(',')[9].Split('=')[1]) * 1200;
            try
            {
                string hour = File.ReadAllText(project + "/offices/default/office.txt").Split(',')[9].Split('=')[1];
            }
            catch (System.Reflection.TargetInvocationException)
            {
                MF_Error("Could not load the night hours in lenght.", "Did you leave the Hours box blank in [OFFICE EDITOR]?");
            }
            while (inNight)
            {
                await Task.Delay(8000); //1.20 seconds
                if (CurrentHour == 1)
                {
                    MF_OnNightEnd();
                }
                else
                {
                    CurrentHour -= 1;
                }
            }
        }
        private void MF_Break()
        {
            inNight = false;
            open = false;
            MF_OnEngineEnd();
            curMenu = "";
            Error.Show();
            Error.BringToFront();
            this.Title.Text = "Operation cancelled.";
            this.Description.Text = "Game has been terminated.";
            this.Close();
        }
        private void MF_StopThreads()
        {
            inNight = false;
            open = false;
            curMenu = "";
        }
        private async void MF_OnEngineStart()
        {
            while (open == true)
            {
                await Task.Delay(1);
                MF_OnEngineUpdate();
            }
        }
        private void MF_OnEngineUpdate()
        {

        }
        private void MF_OnEngineEnd()
        {

        }
        private void MF_OnNightEnd()
        {
            inNight = false;
            MF_NightEnd();
        }
        private void Office_Paint(object sender, EventArgs e)
        {
            MF_ChangeOfficeState("Default");
        }
        private void MF_Popup(string message)
        {
            MessageBox.Show(message, "Custom Popup");
        }
        private void MF_ChangeOfficeState(string State)
        {
            try
            {
                Console.WriteLine("Changing office state image...");
                Console.WriteLine("");
                Console.WriteLine("Loading image...");
                Console.WriteLine("");
                OfficeBackground.BackgroundImage = Image.FromFile(project + "/images/" + File.ReadAllText(project + $"/offices/default/office_states/{State}/mainsprite.txt"));
                Console.WriteLine("Image loaded.");
                Console.WriteLine("");
                Console.WriteLine("Successfully loaded office state image.");
            }
            catch (Exception)
            {
                Console.WriteLine("Default office state image not found!");
                Console.WriteLine("Failed to load office state image.");
            }
        }
        private void MF_GotoMenu(string Menu)
        {
            try
            {
                foreach (Control control in Controls)
                {
                    control.Tag = 0;
                }
                this.Controls[Menu].BringToFront();
                this.Controls[Menu].Tag = 0;
            }
            catch (Exception)
            {
                MF_Error("Failed to show menu.", "Failed to show menu '" + Menu + "'!");
            }
        }
        private void MF_Error(string Title, string Description)
        {
            MF_StopThreads();
            Error.Show();
            Error.BringToFront();
            this.Title.Text = Title;
            this.Description.Text = Description;
        }
        private void MF_CustomError(string Description)
        {
            MF_StopThreads();
            Error.Show();
            Error.BringToFront();
            this.Title.Text = "User has thrown an error";
            this.Description.Text = Description;
        }
        private void MF_NightEnd()
        {
            string txt = File.ReadAllText(project + "/data.txt");
            txt.Replace("night:" + curNight, "night:" + curNight + 1);
            File.WriteAllText(project + "data.txt", txt);
            MF_GotoMenu("6AM");
        }
    }
}