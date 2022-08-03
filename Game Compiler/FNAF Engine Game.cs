using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class FNAF_Engine_Game : Form
    {
        private readonly reborn reborn;
        private string project;
        int time = 0;

        public FNAF_Engine_Game(reborn reborn)
        {
            this.reborn = reborn;
            project = reborn.projecto;
            InitializeComponent();
        }

        private void FNAF_Engine_Game_VisibleChanged(object sender, EventArgs e)
        {
            //while (true)
            //{
            //    await Task.Delay(5000);
            //    if (Controls.ContainsKey("Main"))
            //    {
            //        Console.WriteLine("Main");
            //    }
            //}
        }

        private void FNAF_Engine_Game_Load_1(object sender, EventArgs e)
        {
            project = reborn.projecto;
            Load_Game();
        }
        private void Load_Game()
        {
            this.Text = File.ReadAllText(project + "/game.txt");
            Load_Menus();
        }

        private async void Load_Menus()
        {
            string[] menus = Directory.GetDirectories(project + "/menus/");
            foreach (string Menu in menus)
            {
                string MenuName = File.ReadAllText(Menu + "/name.txt");

                Panel panel = new Panel
                {
                    Size = Size,
                    Name = MenuName,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackColor = Color.Black
                };

                try
                {
                    panel.BackgroundImage = Image.FromFile(project + "/images/" + File.ReadAllText(project + $"/menus/{panel.Name}/bg.txt"));
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Failed to load image: Image file not found");
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Failed to load image: Bad file");
                }

                panel.Visible = false;

                panel.Controls.Clear();

                this.Controls.Add(panel);

                if (MenuName == "Main")
                {
                    panel.BringToFront();
                }

                panel.VisibleChanged += Menu_Load;

                panel.Visible = true;

                panel.Paint += Menu_Start;

                async void Menu_Start(object sender, EventArgs e)
                {
                    string[] instructions = { };
                    string[] instructions_onloop = { };
                    try
                    {
                        instructions = File.ReadAllLines(project + "/menus/" + MenuName + "/onmenustart.txt");
                    }
                    catch (Exception)
                    {

                    }
                    foreach (string instruction in instructions)
                    {
                        RunScript(instruction);
                    }

                    try
                    {
                        instructions_onloop = File.ReadAllLines(project + "/menus/" + MenuName + "/ongameloop.txt");
                    }
                    catch (Exception)
                    {

                    }
                    while (panel.Visible == true)
                    {
                        await Task.Delay(1);
                        foreach (string instruction in instructions_onloop)
                        {
                            RunScript(instruction);
                        }
                    }
                }

                void Menu_Load(object sender, EventArgs e)
                {
                    string[] texts = Directory.GetDirectories(project + $"/menus/{MenuName}/text_elements/");
                    panel.Controls.Clear();
                    foreach (string text in texts)
                    {
                        string args = File.ReadAllText(text + "/args.txt");
                        if (args == "False")
                        {

                            Label Text = new Label();

                            panel.Controls.Add(Text);

                            panel.Show();

                            string Path = text;
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
                                fontfamily = new FontFamily("Consolas");
                            }

                            Font font = new Font(fontfamily, fontsize, FontStyle.Regular);

                            string RGBtxt = File.ReadAllText(Path + "/color.txt");

                            string[] SeparatedRGB = RGBtxt.Split(',');

                            int R = Convert.ToInt32(SeparatedRGB[0]);
                            int G = Convert.ToInt32(SeparatedRGB[1]);
                            int B = Convert.ToInt32(SeparatedRGB[2]);

                            Text.Location = new Point(X, Y);
                            Text.AutoSize = true;
                            Text.BackColor = Color.Transparent;
                            Text.FlatStyle = FlatStyle.Flat;
                            Text.ForeColor = Color.FromArgb(R, G, B);
                            Text.Font = new Font(font, FontStyle.Regular);
                            Text.Text = TXTText;
                            Text.Name = ID;

                            Text.Click += Element_Click;

                            void Element_Click(object object_sender, EventArgs event_args)
                            {
                                string[] functions = File.ReadAllLines(Path + "/functions.txt");
                                foreach (string instruction in functions)
                                {
                                    RunScript(instruction);
                                }
                            }
                        }
                    }
                }
                async void RunScript(string instruction)
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
                    if (instruction.StartsWith("goto:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        foreach (Panel panel_menu in Controls)
                        {
                            if (panel_menu.Name == instructions[1]) // the menu inputted
                            {
                                panel_menu.BringToFront();
                                panel_menu.BringToFront();
                                panel_menu.BringToFront();
                            }
                            else
                            {
                                panel_menu.SendToBack();
                                panel_menu.SendToBack();
                            }
                        }
                    }
                    if (instruction == "newgame")
                    {
                        await RunCode();
                        Console.WriteLine("Night 1");
                        Night_Start.Show();
                        Night_Start.BringToFront();
                        nightLBL.Text = "Night 1";
                    }
                    if (instruction == "continue")
                    {
                        await RunCode();
                        //todo
                    }

                    if (instruction.StartsWith("set_var:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        File.WriteAllText(project + "/menus/" + MenuName + "/variables/" + instructions[1], instructions[2]);
                    }

                    if (instruction.StartsWith("set_data:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        long Value = 0;
                        if (instructions[2].Contains("("))
                        {
                            Value = Value + Convert.ToInt64(File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + instructions[2].Split('(', ')')[1]));
                            string NewValue = Value.ToString();
                            NewValue.Replace("(" + instructions[2].Split('(', ')')[1] + ")", "");
                            Value = Convert.ToInt64(NewValue);
                        }
                        File.WriteAllText(project + "/menus/" + MenuName + "/variables/" + instructions[1], Value.ToString());
                    }

                    if (instruction.StartsWith("if("))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':', '[');
                        string value = instructions[1];
                        string block = instruction.Split('[', ']')[1];
                        string variable = instruction.Split('(', ')')[1];
                        if (File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable) == value)
                        {
                            RunScript(block);
                        }
                    }

                    if (instruction == "quit")
                    {
                        await RunCode();
                        this.Close();
                    }

                    if (instruction.StartsWith("wait:"))
                    {
                        await RunCode();
                        time = Convert.ToInt32(instruction.Split(':')[1]);
                    }

                    if (instruction.StartsWith("set_text:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        try
                        {
                            if (instructions[2].Contains("%var(") || instructions[2].Contains("%data("))
                            {
                                string variable_args = instructions[2].Split('%')[1];
                                string variable = variable_args.Split('(', ')')[1];
                                panel.Controls[instructions[1]].Text = File.ReadAllText(project + "/menus/" + MenuName + "/variables/" + variable);
                            }
                            else
                            {
                                panel.Controls[instructions[1]].Text = instructions[2]; //the text value
                            }
                        }
                        catch (Exception)
                        {
                            Error.Show();
                            Error.BringToFront();
                            Title.Text = "Failed to change text";
                            Description.Text = "Failed to change text. Original code: " + instruction;
                        }
                    }

                    if (instruction.StartsWith("set_font:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        try
                        {
                            panel.Controls[instructions[1]].Font = new Font(instructions[2], Convert.ToInt32(instructions[3]) + 22); //the text value
                        }
                        catch (Exception)
                        {
                            Error.Show();
                            Error.BringToFront();
                            Title.Text = "Failed to change font";
                            Description.Text = "Failed to change font. Original code: " + instruction;
                        }
                    }

                    if (instruction.StartsWith("set_color:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        int argsR = Convert.ToInt32(instructions[2].Split(',')[0]);
                        int argsG = Convert.ToInt32(instructions[2].Split(',')[1]);
                        int argsB = Convert.ToInt32(instructions[2].Split(',')[2]);
                        try
                        {
                            panel.Controls[instructions[1]].ForeColor = Color.FromArgb(argsR, argsG, argsB); //the text value
                        }
                        catch (Exception)
                        {
                            Error.Show();
                            Error.BringToFront();
                            Title.Text = "Failed to change color";
                            Description.Text = "Failed to change color. Original code: " + instruction;
                        }
                    }

                    if (instruction.StartsWith("hide_text"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        try
                        {
                            panel.Controls[instructions[1]].Hide(); //the text value
                        }
                        catch (Exception)
                        {
                            Error.Show();
                            Error.BringToFront();
                            Title.Text = "Failed to hide text: " + panel.Controls[instructions[1]].Name;
                            Description.Text = "Failed to hide text. Original code: " + instruction;
                        }
                    }

                    if (instruction.StartsWith("show_text:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        try
                        {
                            panel.Controls[instructions[1]].Show(); //the text value
                        }
                        catch (Exception)
                        {
                            Error.Show();
                            Error.BringToFront();
                            Title.Text = "Failed to show text: " + panel.Controls[instructions[1]].Name;
                            Description.Text = "Failed to show text. Original code: " + instruction;
                        }
                    }

                    if (instruction.StartsWith("set_bg:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        try
                        {
                            //panel.Controls[instructions[1]].Show(); //the text value
                        }
                        catch (Exception)
                        {
                            Error.Show();
                            Error.BringToFront();
                            Title.Text = "Failed to change background: "; //+ panel.Controls[instructions[1]].Name;
                            Description.Text = "Failed to change background. Original code: (SET BACKGROUND IS WIP, THIS ISNT A BUG!!!)";// + instruction;
                        }
                    }

                    if (instruction.StartsWith("set_data:"))
                    {
                        await RunCode();
                        string[] instructions = instruction.Split(':');
                        string name = instructions[1];
                        string value = instructions[2];
                        string data_values = File.ReadAllText(project + "/data.txt");

                        if (data_values.Contains($",{name}:")) //if theres already a data value
                        {
                            //data_values.Replace($",{name}:", );
                        }
                    }

                    if (instruction == "run_script")
                    {
                        await RunCode();
                        RunScript(instruction);
                    }
                }

                await Task.Delay(500);

                Loading.Hide();
            }
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
                MF_ChangeOfficeState("Default");
                await Task.Delay(1500);
                Office.Show();
                Office.BringToFront();
            }
        }
        private void Office_Paint(object sender, EventArgs e)
        {
            MF_ChangeOfficeState("Default");
        }
        private async void MF_ChangeOfficeState(string State)
        {
            try
            {
                Console.WriteLine("Changing office state image...");
                await Task.Delay(50);
                Console.WriteLine("");
                Console.WriteLine("Loading image...");
                Console.WriteLine("");
                Office.BackgroundImage = Image.FromFile(project + "/images/" + File.ReadAllText(project + $"/offices/default/office_states/{State}/mainsprite.txt"));
                await Task.Delay(50);
                Console.WriteLine("Image loaded.");
                Console.WriteLine("");
                await Task.Delay(525);
                Console.WriteLine("Successfully loaded office state image.");
            }
            catch (Exception)
            {
                await Task.Delay(50);
                Console.WriteLine("Default office state image not found!");
                await Task.Delay(350);
                Console.WriteLine("Failed to load office state image.");
            }
        }
    }
}