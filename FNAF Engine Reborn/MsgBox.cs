using System;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class MsgBox : Form
    {
        public MsgBox(string txt = "Warning!", string nam = "Message")
        {
            InitializeComponent();
            this.Text = nam;
            label1.Text = "> " + txt;
        }

        private void createProjectbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public static class Logger
    {
        public static void Log(string txt = "Warning!", string nam = "Message")
        {
            MsgBox box = new(txt, nam);
            box.ShowDialog();
        }
    }
}
