using System;
using System.Linq;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class manual : Form
    {
        public manual()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIDefinition.Show();
        }

        private void funTools_Click(object sender, EventArgs e)
        {
            UIDefinition.Hide();
        }

        private void manual_FormClosing(object sender, FormClosingEventArgs e)
        {
            reborn rebor = Application.OpenForms.OfType<reborn>().Single();
            rebor.isopen = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://discord.gg/gGCdUpKDrW");
        }
    }
}
