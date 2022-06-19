using System;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class changelogs : Form
    {
        public changelogs()
        {
            InitializeComponent();
        }

        private void changelogs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            releases.Visible = false;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            panel1.Visible = false;
            releases.Visible = true;
        }
    }
}
