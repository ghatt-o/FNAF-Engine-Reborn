using System;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class FNAF_Engine_Game : Form
    {
        public FNAF_Engine_Game()
        {
            InitializeComponent();
        }
        private void FNAF_Engine_Game_VisibleChanged(object sender, EventArgs e)
        {
            loadFERproject projectloader = new loadFERproject();
            string projecto = projectloader.label3.Text;
            Console.WriteLine(projecto);
            //this.Text = File.ReadAllText(projecto + "/game.txt");
            //if(File.ReadAllText(projecto + "/options.txt") == "fullscreen=true")
            //{
            //     this.FormBorderStyle = (FormBorderStyle)BorderStyle.None;
            //    this.WindowState = FormWindowState.Minimized;
            // }
            // else
            // {
            //      this.WindowState = FormWindowState.Normal;
            //     this.FormBorderStyle = (FormBorderStyle)BorderStyle.None;
            //}
        }
        private void FNAF_Engine_Game_Load(object sender, EventArgs e)
        {

        }
    }
}
