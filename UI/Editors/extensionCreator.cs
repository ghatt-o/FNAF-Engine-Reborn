using System;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class extensionCreator : Form
    {
        public extensionCreator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button5.Text = textBox2.Text;
        }
    }
}
