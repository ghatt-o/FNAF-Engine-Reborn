using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
