using System;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn.UI.Editors
{
    public partial class ExpressionEditor : Form
    {
        public ExpressionEditor()
        {
            InitializeComponent();
        }

        private void PiBtn_Click(object sender, EventArgs e)
        {
            Expression.Text += "3.141592654";
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
