using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class ReleaseOrDebug : Form
    {
        private readonly reborn reborn;

        public ReleaseOrDebug(reborn reborn)
        {
            this.reborn = reborn;
            InitializeComponent();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            FNAF_Engine_Game fnaf_Engine_Game = new FNAF_Engine_Game(reborn);
            fnaf_Engine_Game.ShowDialog();
        }
    }
}
