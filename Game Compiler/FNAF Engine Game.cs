using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class FNAF_Engine_Game : Form
    {
        private reborn reborn;
        private string project;

        public FNAF_Engine_Game(reborn reborn)
        {
            this.reborn = reborn;
            this.project = reborn.projecto;
            InitializeComponent();
        }

        private void FNAF_Engine_Game_VisibleChanged(object sender, EventArgs e)
        {

        }
        private void FNAF_Engine_Game_Load_1(object sender, EventArgs e)
        {
            project = reborn.projecto;
            Load_Game();
        }
        private void Load_Game()
        {
            this.Text = File.ReadAllText(project + "/game.txt");
            Main.Show();
            Office.Hide();
        }

        private void Load_Menus()
        {
            var menus = Directory.GetDirectories(project + "/menus/");
            foreach (string Menu in menus)
            {
                Panel panel = new Panel
                {
                    Size = this.Size,
                    Name = Menu,
                    BackColor = Color.White
                };
                this.Controls.Add(panel);
                panel.BringToFront();
            }
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            var texts = Directory.GetDirectories(project + "/menus/Main/text_elements");
            foreach (string text in texts)
            {
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
                //X

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
                //Y

                string TXTText = File.ReadAllText(Path + "/text.txt");
                string ID = File.ReadAllText(Path + "/id.txt");

                string fontname = File.ReadAllText(Path + "/font.txt");
                string fontsize_string = File.ReadAllText(Path + "/fontsize.txt");

                int fontsize = Convert.ToInt32(fontsize_string) + 30;

                FontFamily fontfamily = new FontFamily(fontname);

                Font font = new Font(fontfamily, fontsize, FontStyle.Regular);

                string RGBtxt = File.ReadAllText(Path + "/color.txt");

                var SeparatedRGB = RGBtxt.Split(',');

                int R = Convert.ToInt32(SeparatedRGB[0]);
                int G = Convert.ToInt32(SeparatedRGB[1]);
                int B = Convert.ToInt32(SeparatedRGB[2]);

                Label Text = new Label();
                Text.Location = new Point(X, Y);
                Text.AutoSize = true;
                Text.BackColor = Color.Transparent;
                Text.FlatStyle = FlatStyle.Flat;
                Text.ForeColor = Color.FromArgb(R, G, B);
                Text.Font = new Font(font, FontStyle.Regular);
                Text.Text = TXTText;
                Text.Name = ID;

                try
                {
                    Main.BackgroundImage = Image.FromFile(File.ReadAllText(project + "/menus/Main/bg.txt"));
                }
                catch (Exception)
                {
                    Main.BackgroundImage = null;
                }

                Main.Controls.Add(Text);
            }
        }

        private void Office_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
