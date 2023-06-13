using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class ReleaseOrDebug : Form
    {
        private readonly reborn reborn;
        private string style;

        public ReleaseOrDebug(reborn reborn)
        {
            this.reborn = reborn;
            InitializeComponent();
        }

        public ReleaseOrDebug(reborn reborn, string style) : this(reborn)
        {
            this.style = style;
        }

        private void button113_MouseEnter(object sender, EventArgs e)
        {
            label71.Location = new Point(43, 78); // change the location of image
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label71.Location = new Point(215, 78); // change the location of image
        }

        private void ReleaseOrDebug_Load(object sender, EventArgs e)
        {
            label2.Text = "Game Style: " + style;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            await Task.Delay(1000);
            if (style == "standard")
            {
                FNAF_Engine_Game.FNAF_Engine_Game sunset = new FNAF_Engine_Game.FNAF_Engine_Game(reborn);
                sunset.ShowDialog();
            }
            else
            {
                FNAF_Engine_Game.FNAF_Engine_Game fnaf_Engine_Game = new FNAF_Engine_Game.FNAF_Engine_Game(reborn);
                fnaf_Engine_Game.ShowDialog();
            }
        }
    }
}
