using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class ReleaseOrDebug : Form
    {
        public bool testmode; // bool to check if its testing not compiling because this form is used for both compile and test
        public bool compilemode; // same thing as above but compile instead
        public ReleaseOrDebug()
        {
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
            if (!testmode)
            {
                compilemode = false; //if its test mode, then turn compile mode off because if you click on one of these it'll compile instead of test!
            }
            if (!compilemode)
            {
                testmode = false; // same thing, just turn off test mode
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            Thread.Sleep(1000);
            this.Hide();
        }
    }
}
